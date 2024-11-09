using CsvHelper;
using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagement.Academic;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentFeeDetails : Form
    {
        private List<StudentFeeModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int schoolid;
        private int id;
        private int classid;
        private string yearFee;
        private string installment;
        private bool isRowBeingEdited = false;
        private bool isSaved = false;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        Form frm;
        public StudentFeeDetails()
        {
            InitializeComponent();

            StudentClassFeesRecord();
        }

        private void StudentFeeDetails_Load(object sender, EventArgs e)
        {
            StudentFeeEdit();
        }

        private void StudentFeeEdit()
        {
            foreach (DataGridViewRow row in StuFeeDetailsDataGridView.Rows)
            {
                row.ReadOnly = true;
            }

            foreach (DataGridViewRow row in StuFeeDetailsDataGridView.Rows)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["EditColumn"];
                buttonCell.Value = "Edit";
            }
        }

        private void StudentClassFeesRecord()
        {
            try
            {
                var schoolid = 2008;
                System.Data.DataTable dt = new System.Data.DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select StuFeeAC.Id,StuFeeAC.SchoolId,StuFeeAC.ClassId,StuFeeAC.YearFee,StuFeeAC.Installment,class.ClassName
                    from StudentFeeAccounting StuFeeAC left join Class class on class.ClassId=StuFeeAC.ClassId
                    where StuFeeAC.IsActive=1 and StuFeeAC.SchoolId={schoolid}");
                    allData = connection.Query<StudentFeeModel>(sql.ToString()).ToList();

                    StuFeeDetailsDataGridView.Rows.Clear();

                    foreach (var item in allData)
                    {
                        StuFeeDetailsDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassName, item.YearFee, item.Installment);
                    }

                    StuFeeDetailsDataGridView.AutoGenerateColumns = false;

                    TotalCount.Text = "Total Count: " + StuFeeDetailsDataGridView.Rows.Count.ToString();

                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void StuFeeDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StuFeeDetailsDataGridView.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["EditColumn"];

                if (buttonCell.Value.ToString() == "Edit")
                {
                    if (!isRowBeingEdited)
                    {
                        int rowIndex = e.RowIndex;
                        DataGridViewRow row = StuFeeDetailsDataGridView.Rows[rowIndex];
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGoldenrodYellow;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.ReadOnly = false;
                        }
                        row.Cells[2].ReadOnly = true;
                        buttonCell.Value = "Save";
                        isRowBeingEdited = true;
                        isSaved = false;
                    }
                }
                else if (buttonCell.Value.ToString() == "Save")
                {
                    int rowIndex = e.RowIndex;

                    bool updateSuccessful = UpdateRow(rowIndex);

                    if (updateSuccessful)
                    {
                        DataGridViewRow row = StuFeeDetailsDataGridView.Rows[rowIndex];
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            cell.ReadOnly = true;
                        }
                        buttonCell.Value = "Edit";
                        isRowBeingEdited = false;
                        isSaved = true;
                    }
                }

                StuFeeDetailsDataGridView.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < StuFeeDetailsDataGridView.Columns.Count && StuFeeDetailsDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                id = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                schoolid = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = DbContext.StudentFeeAccountings.Find(id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        entityToDelete.IsActive = false;
                        DbContext.SaveChanges();

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        StudentClassFeesRecord();
                        StudentFeeEdit();
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool UpdateRow(int rowIndex)
        {
            try
            {
                id = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[rowIndex].Cells["IdColumn"]?.Value);
                classid = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[rowIndex].Cells["ClassNameColumn"]?.Value);
                schoolid = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[rowIndex].Cells["SchoolIdColumn"]?.Value);
                yearFee = StuFeeDetailsDataGridView.Rows[rowIndex].Cells["YearlyFeeColumn"].Value?.ToString();
                installment = StuFeeDetailsDataGridView.Rows[rowIndex].Cells["InstallmentColumn"].Value?.ToString();

                var studentFeeToUpdate = DbContext.StudentFeeAccountings.FirstOrDefault(x => x.Id == id && x.SchoolId == schoolid && x.ClassId == classid && x.IsActive == true);
                if (studentFeeToUpdate != null)
                {
                    int yearFeeValue;

                    if (int.TryParse(yearFee, out yearFeeValue))
                    {
                        studentFeeToUpdate.YearFee = yearFee;
                        studentFeeToUpdate.Installment = installment;
                        studentFeeToUpdate.DateModified = DateTime.Now;

                        var isrowmessage = validate.ValidateStudentFee(studentFeeToUpdate);
                        if (isrowmessage.Status == true)
                        {
                            MessageBox.Show("Data is not filled please check it!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numeric values for Yearly Fees in row", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DbContext.Entry(studentFeeToUpdate).State = EntityState.Modified;
                    DbContext.SaveChanges();
                    MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Data is null or faild to update please check it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void StudentFee_Click(object sender, EventArgs e)
        {
            frm = (StudentFee)Application.OpenForms["StudentFee"];
            if (frm == null)
            {
                frm = new StudentFee();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void UpdateDataGridView()
        {
            StuFeeDetailsDataGridView.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                StuFeeDetailsDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassName, item.YearFee, item.Installment);
            }

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
