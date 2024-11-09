using CsvHelper;
using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.VariantTypes;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentInstallmentPaymentDetails : Form
    {
        private int schoolId;
        private string studentId;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Form frm;
        public StudentInstallmentPaymentDetails()
        {
            InitializeComponent();
        }

        private void StudentInstallmentPaymentDetails_Load(object sender, EventArgs e)
        {
            studentInstallment();
            StudentInstallmentPaymentDetail();
        }

        private void studentInstallment()
        {
            try
            {
                string StudentId = EditStaffViewModel.StudentId;
                var SchoolId = EditStaffViewModel.SchoolId;

                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = $@"select stuIns.Id,stuIns.SchoolId,stuIns.StudentId,stuIns.ClassId,stuIns.SectionId,stuIns.InstallmentDate,
                    stuIns.DateOfPay,stuIns.PaidPayment,stuIns.RemainingAmount,stuIns.Status from StudentInstallment stuIns
                    where stuIns.IsActive=1 and stuIns.SchoolId=@SchoolId and stuIns.StudentId=@StudentId;";
                    var properties = connection.Query<StudentInstallmentViewModel>(sql, new { SchoolId, StudentId }).ToList();

                    foreach (var item in properties)
                    {
                        string formattedInstallmentDate = item.InstallmentDate.ToString("dd-MM-yyyy");
                        string formattedDateOfPay = item.DateOfPay != DateTime.MinValue ? item.DateOfPay.ToString("dd-MM-yyyy") : string.Empty;

                        StudentInstallmentRecord.Rows.Add(item.Id, item.SchoolId, item.StudentId, item.ClassId, item.SectionId, formattedInstallmentDate, formattedDateOfPay, item.PaidPayment, item.RemainingAmount, item.Status);

                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void StudentInstallmentPaymentDetail()
        {
            var studentInstallments = Db.StudentInstallments.Where(s => s.IsDelete != true).Select(s => new
            {
                s.SchoolId,
                s.ClassId,
                s.StudentId,
                s.SectionId,
                s.PaidPayment,
                s.RemainingAmount
            }).ToList();

            var validRecords = studentInstallments.Where(s => int.TryParse(s.PaidPayment, out int paidPaymentValue) && paidPaymentValue > 0 && s.RemainingAmount > -1)
            .Select(s => (s.SchoolId, s.ClassId, s.StudentId, s.SectionId, s.PaidPayment, s.RemainingAmount)).ToHashSet();

            foreach (DataGridViewRow row in StudentInstallmentRecord.Rows)
            {
                row.ReadOnly = true;

                int schoolId = Convert.ToInt32(row.Cells["SchoolId"].Value);
                int classId = Convert.ToInt32(row.Cells["ClassId"].Value);
                string studentId = row.Cells["StudentId"].Value.ToString();
                string sectionId = row.Cells["SectionId"].Value.ToString();
                string paidPayment = row.Cells["PaidPayment"].Value?.ToString() ?? string.Empty;
                int remainingAmount = row.Cells["RemainingAmountColumn"].Value == null ? -1 : Convert.ToInt32(row.Cells["RemainingAmountColumn"].Value);

                if (validRecords.Contains((schoolId, classId, studentId, sectionId, paidPayment, remainingAmount))
                    || (!string.IsNullOrEmpty(paidPayment) && remainingAmount > -1))
                {
                    row.Cells["PaidPayment"].ReadOnly = true;

                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["Submit"];
                    buttonCell.Value = null;
                    buttonCell.Style.Padding = new Padding(0);
                    buttonCell.ReadOnly = true;
                }
                else
                {
                    row.Cells["PaidPayment"].ReadOnly = false;

                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["Submit"];
                    buttonCell.Value = "Submit";
                }
            }
        }

        private void StudentInstallmentRecord_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentInstallmentRecord.Columns["PaidPayment"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                if (decimal.TryParse(StudentInstallmentRecord.Rows[rowIndex].Cells["PaidPayment"].Value?.ToString(), out decimal paidPayment))
                {
                    decimal previousRemainingAmount = rowIndex > 0 ? Convert.ToDecimal(StudentInstallmentRecord.Rows[rowIndex - 1].Cells["RemainingAmountColumn"].Value) : 0;

                    decimal newRemainingAmount = previousRemainingAmount - paidPayment;
                    StudentInstallmentRecord.Rows[rowIndex].Cells["RemainingAmountColumn"].Value = newRemainingAmount;
                }
                else
                {
                    MessageBox.Show("Please enter a valid payment amount.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StudentInstallmentRecord.CurrentCell.Value = "";
                }
            }
        }

        private void StudentInstallmentRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StudentInstallmentRecord.Columns["Submit"].Index && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var buttonCell = StudentInstallmentRecord.Rows[e.RowIndex].Cells["Submit"] as DataGridViewButtonCell;
                if (buttonCell == null || buttonCell.Value == null)
                {
                    return;
                }
                UpdateInstallment(rowIndex);
            }
        }

        private void UpdateInstallment(int rowIndex)
        {
            try
            {
                DataGridViewRow row = StudentInstallmentRecord.Rows[rowIndex];
                int id = Convert.ToInt32(StudentInstallmentRecord.Rows[rowIndex].Cells["Id"]?.Value);
                int schoolid = Convert.ToInt32(StudentInstallmentRecord.Rows[rowIndex].Cells["SchoolId"]?.Value);
                string studentid = StudentInstallmentRecord.Rows[rowIndex].Cells["StudentId"].Value?.ToString();
                int classid = Convert.ToInt32(StudentInstallmentRecord.Rows[rowIndex].Cells["ClassId"]?.Value);
                string sectionid = StudentInstallmentRecord.Rows[rowIndex].Cells["SectionId"].Value?.ToString();
                string paidPayment = StudentInstallmentRecord.Rows[rowIndex].Cells["PaidPayment"].Value?.ToString();
                int remainingAmount = Convert.ToInt32(StudentInstallmentRecord.Rows[rowIndex].Cells["RemainingAmountColumn"]?.Value);

                if (paidPayment != null)
                {
                    var studentInstallmentUpdate = Db.StudentInstallments.AsNoTracking().FirstOrDefault(x => x.Id == id && x.SchoolId == schoolid && x.StudentId == studentid && x.ClassId == classid && x.SectionId == sectionid && x.IsActive == true);
                    if (studentInstallmentUpdate != null)
                    {
                        var studentFeeInstallmentUpdate = Db.StudentFeeInstallments.AsNoTracking().FirstOrDefault(x => x.SchoolId == schoolid && x.StudentId == studentid && x.ClassId == classid && x.SectionId == sectionid && x.IsActive == true);
                        if (studentFeeInstallmentUpdate != null)
                        {
                            studentInstallmentUpdate.PaidPayment = paidPayment;
                            studentInstallmentUpdate.RemainingAmount = remainingAmount;
                            studentInstallmentUpdate.Status = "Paid";
                            studentInstallmentUpdate.DateOfPay = DateTime.Now;
                            studentInstallmentUpdate.DateModified = DateTime.Now;
                            studentFeeInstallmentUpdate.RemainingAmount = remainingAmount;

                            Db.Entry(studentInstallmentUpdate).State = EntityState.Modified;
                            Db.SaveChanges();
                            Db.Entry(studentFeeInstallmentUpdate).State = EntityState.Modified;
                            Db.SaveChanges();
                            MessageBox.Show("Data submit successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentInstallmentPaymentDetail();
                            row.Cells["DateOfPay"].Value = studentInstallmentUpdate.DateOfPay?.ToShortDateString();
                            row.Cells["Status"].Value = studentInstallmentUpdate.Status;
                        }
                        else
                        {
                            MessageBox.Show("Data is null or faild to update please check it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data is null or faild to update please check it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Paid Payment is empty please check it!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
