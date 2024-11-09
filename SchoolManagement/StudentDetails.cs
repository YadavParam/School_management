using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchoolManagement.Helper;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Bibliography;
using System.IO;
using Dapper;
using SchoolManagement.Accounting;
using System.Data.Entity;
using DocumentFormat.OpenXml.Office2010.Excel;
using SchoolManagement;
namespace SchoolManagement
{
    public partial class StudentDetails : Form
    {
        private List<StudentViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int schoolid;
        private int classid;
        private string studentid;
        private string sectionid;
        private string remainingAmount;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Form frm;
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

            studentrecord();
            StudentDetail();
        }

        private void studentrecord()
        {
            try
            {
                var schoolid = 2008;
                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select stu.Id,stu.StudentId,stu.Name,stu.ClassId,stu.SchoolId,stu.StudentType,cla.ClassName,stu.SectionId,stu.Email,stu.PhoneNumber,par.FathersName, COALESCE(stuFeeIns.RemainingAmount, null) AS RemainingAmount,
                    par.MothersName,par.FathersMailId,par.MothersMailId,par.FathersMobileNumber,par.MothersMobileNumber,par.FathersOccupation,par.MothersOccupation 
                    from Student stu left join parent par on par.ParentId = stu.ParentId left join Class cla on cla.ClassId = stu.ClassId 
				    left join StudentFeeInstallment stuFeeIns on stuFeeIns.StudentId = stu.StudentId
                    where stu.IsActive=1 and stu.SchoolId={schoolid}");
                    allData = connection.Query<StudentViewModel>(sql.ToString()).ToList();

                    StudentRecord.Rows.Clear();

                    foreach (var item in allData)
                    {
                        StudentRecord.Rows.Add(item.StudentId, item.Name, item.ClassId, item.SchoolId, item.StudentType, item.ClassName, item.SectionId, item.Email, item.PhoneNumber, item.FathersName, item.MothersName, item.FathersMobileNumber, item.MothersMobileNumber, item.RemainingAmount);

                    }

                    StudentRecord.AutoGenerateColumns = false;

                    TotalCount.Text = "Total Count: " + StudentRecord.Rows.Count.ToString();

                    UpdateDataGridView();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void StudentDetail()
        {
            var combinations = Db.StudentFeeInstallments.Where(s => s.IsDelete != true)
            .Select(s => new { s.SchoolId, s.ClassId, s.StudentId }).ToList().Select(s => (s.SchoolId, s.ClassId, s.StudentId)).ToHashSet();

            for (int i = 0; i < StudentRecord.Rows.Count; i++)
            {
                DataGridViewRow row = StudentRecord.Rows[i];

                string studentId = row.Cells["StudentIdColumn"].Value?.ToString();
                int? schoolId = row.Cells["SchoolIdColumn"].Value as int?;
                int? classId = row.Cells["ClassIdColumn"].Value as int?;
                string remainingAmount = row.Cells["RemainingAmountColumn"].Value?.ToString() ?? string.Empty;

                if (combinations.Contains((schoolId, classId, studentId)))
                {
                    if (string.IsNullOrEmpty(remainingAmount))
                    {
                        row.Cells["FeePay"].Value = "Fees Pay";
                    }
                    else if (int.TryParse(remainingAmount, out int amount) && amount == 0)
                    {
                        row.Cells["FeePay"].Value = "Paid";
                    }
                    else
                    {
                        row.Cells["FeePay"].Value = "Installment";
                    }
                }
                else
                {
                    row.Cells["FeePay"].Value = "Fees Pay";
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frm = (Student_MainForm)Application.OpenForms["Student_MainForm"];
            if (frm == null)
            {
                frm = new Student_MainForm();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void StudentRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.ClassId = 0;
            EditStaffViewModel.SchoolId = 0;
            EditStaffViewModel.StudentId = "";
            EditStaffViewModel.SectionId = "";
            if (e.ColumnIndex == StudentRecord.Columns["FeePay"].Index && e.RowIndex >= 0)
            {
                studentid = StudentRecord.Rows[e.RowIndex].Cells["StudentIdColumn"]?.Value.ToString();
                schoolid = Convert.ToInt32(StudentRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                classid = Convert.ToInt32(StudentRecord.Rows[e.RowIndex].Cells["ClassIdColumn"]?.Value);
                sectionid = StudentRecord.Rows[e.RowIndex].Cells["Section"]?.Value.ToString();
                remainingAmount = StudentRecord.Rows[e.RowIndex].Cells["RemainingAmountColumn"]?.Value != null
                ? StudentRecord.Rows[e.RowIndex].Cells["RemainingAmountColumn"].Value.ToString() : string.Empty;

                EditStaffViewModel.StudentId = studentid;
                EditStaffViewModel.SchoolId = schoolid;
                EditStaffViewModel.ClassId = classid;
                EditStaffViewModel.SectionId = sectionid;

                if (schoolid != null && schoolid != 0 && studentid != null && classid != null)
                {
                    if (string.IsNullOrEmpty(remainingAmount))
                    {
                        frm = (StudentFeeInstallmentDetail)Application.OpenForms["StudentFeeInstallmentDetail"];
                        if (frm == null)
                        {
                            frm = new StudentFeeInstallmentDetail();
                        }
                        frm.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                        frm.BringToFront();
                        frm.Show();
                    }
                    else if (int.TryParse(remainingAmount, out int amount) && amount > 0)
                    {
                        frm = (StudentInstallmentPaymentDetails)Application.OpenForms["StudentInstallmentPaymentDetails"];
                        if (frm == null)
                        {
                            frm = new StudentInstallmentPaymentDetails();
                        }
                        frm.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                        frm.BringToFront();
                        frm.Show();
                    }
                    else if (remainingAmount == "0")
                    {
                        MessageBox.Show("Fees already Paid", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            if (e.ColumnIndex == StudentRecord.Columns["InvoiceColumn"].Index && e.RowIndex >= 0)
            {
                studentid = StudentRecord.Rows[e.RowIndex].Cells["StudentIdColumn"]?.Value.ToString();
                schoolid = Convert.ToInt32(StudentRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                EditStaffViewModel.StudentId = studentid;
                EditStaffViewModel.SchoolId = schoolid;


                frm = new StudentInvoice();
                frm.Show();
            }
        }

        private void UpdateDataGridView()
        {
            StudentRecord.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                StudentRecord.Rows.Add(item.StudentId, item.Name, item.ClassId, item.SchoolId, item.StudentType, item.ClassName, item.SectionId, item.Email, item.PhoneNumber, item.FathersName, item.MothersName, item.FathersMobileNumber, item.MothersMobileNumber, item.RemainingAmount);
            }

            StudentDetail();

            previousBtn.Enabled = currentPage > 0;
            nextBtn.Enabled = currentPage < TotalPages - 1;

            btnBetweenPg.Text = $"Pages: {currentPage + 1} / {TotalPages}";
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateDataGridView();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages - 1)
            {
                currentPage++;
                UpdateDataGridView();
            }
        }

        private int TotalPages => allData != null ? (int)Math.Ceiling((double)allData.Count / pageSize) : 0;

    }
}
