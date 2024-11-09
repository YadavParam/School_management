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
    public partial class StudentFeeInstallmentDetail : Form
    {
        private int schoolId;
        private int classId;
        private string studentId;
        private string sectionId;
        private int totalInstallments;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        Form frm;
        public StudentFeeInstallmentDetail()
        {
            InitializeComponent();
        }

        private void StudentFeeInstallmentDetail_Load(object sender, EventArgs e)
        {
            studentId = EditStaffViewModel.StudentId;
            schoolId = EditStaffViewModel.SchoolId;
            classId = EditStaffViewModel.ClassId;
            sectionId = EditStaffViewModel.SectionId;
            if (schoolId != null && classId != null)
            {
                var yearFee = DbContext.StudentFeeAccountings
                    .Where(x => x.SchoolId == schoolId && x.ClassId == classId && x.IsActive == true)
                    .Select(x => x.YearFee)
                    .FirstOrDefault();

                if (yearFee != null)
                {
                    feeAmount.Text = yearFee.ToString();
                    feeAmount.ReadOnly = true;
                }
                else
                {
                    feeAmount.Text = "No data found";
                }
            }
        }

        private void negotiableAmount_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(feeAmount.Text) && !string.IsNullOrEmpty(firstPayPayment.Text) && !string.IsNullOrEmpty(negotiableAmount.Text))
            {
                int feeAmountValue, firstPayPaymentValue, negotiableAmountValue;

                if (int.TryParse(feeAmount.Text, out feeAmountValue) &&
                    int.TryParse(firstPayPayment.Text, out firstPayPaymentValue) &&
                    int.TryParse(negotiableAmount.Text, out negotiableAmountValue))
                {
                    int remainingAmountValue = feeAmountValue - (firstPayPaymentValue + negotiableAmountValue);
                    remainingAmount.Text = remainingAmountValue.ToString();
                    if (remainingAmountValue <= 0)
                    {
                        kryptonLabel3.Visible = false;
                        totalNoOfInstallment.Visible = false;
                    }
                    else
                    {
                        kryptonLabel3.Visible = true;
                        totalNoOfInstallment.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for First Pay Payment and Negotiable Amount.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    firstPayPayment.Text = "";
                    negotiableAmount.Text = "";
                }
            }
        }

        private void firstPayPayment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstPayPayment.Text))
            {
                negotiableAmount.Text = string.Empty;
                remainingAmount.Text = string.Empty;
            }
            else if (!string.IsNullOrEmpty(firstPayPayment.Text))
            {
                negotiableAmount.Text = string.Empty;
                remainingAmount.Text = string.Empty;
            }
        }

        private void StudFeeInstallSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = (StudentDetails)Application.OpenForms["StudentDetails"];
                if (frm == null)
                {
                    frm = new StudentDetails();
                }

                int totalInstallments = 0;

                if (string.IsNullOrEmpty(totalNoOfInstallment.Text))
                {
                    if (string.IsNullOrEmpty(remainingAmount.Text))
                    {
                        totalInstallments = 0;
                    }
                }
                else if (int.TryParse(totalNoOfInstallment.Text, out int parsedTotalInstallments))
                {
                    if (parsedTotalInstallments == 0)
                    {
                        MessageBox.Show("Total Number of Installments cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        totalInstallments = parsedTotalInstallments;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid numeric value for Total Number of Installments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime baseDate = DateTime.Now;
                List<StudentInstallment> studentInstallment = new List<StudentInstallment>();

                var newStudentFeeInstall = new StudentFeeInstallment
                {
                    SchoolId = schoolId,
                    ClassId = classId,
                    StudentId = studentId,
                    SectionId = sectionId,
                    FeeAmount = feeAmount.Text,
                    FirstPayPayment = firstPayPayment.Text,
                    NegotiableAmount = negotiableAmount.Text ?? null,
                    TotalNoOfInstallment = totalNoOfInstallment.Text,
                    RemainingAmount = string.IsNullOrEmpty(remainingAmount.Text) ? (int?)null : int.Parse(remainingAmount.Text),
                    IsActive = true,
                    IsDelete = false,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                };
                var feemessage = validate.ValidateStudentFeeInstallment(newStudentFeeInstall);
                if (feemessage.Status == true)
                {
                    MessageBox.Show(feemessage.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime? firstInstallmentDate = null;
                string firstPayment = null;
                int? firstRemainingAmount = null;
                string status = null;
                if (firstInstallmentDate == null)
                {
                    firstInstallmentDate = DateTime.Now;
                    firstPayment = firstPayPayment.Text;
                    firstRemainingAmount = string.IsNullOrEmpty(remainingAmount.Text) ? (int?)null : int.Parse(remainingAmount.Text);
                    status = "Paid";
                }
                for (int i = 0; i < totalInstallments; i++)
                {
                    string payment = null;
                    DateTime? dateOfPay = null;
                    int? remainingAmountValue = null;
                    string statusValue = "UnPaid";
                    if (i == 0 && firstInstallmentDate.HasValue)
                    {
                        dateOfPay = firstInstallmentDate;
                        payment = firstPayment;
                        remainingAmountValue = firstRemainingAmount;
                        statusValue = status;
                    }

                    var newInstallment = new StudentInstallment
                    {
                        StudentId = studentId,
                        SchoolId = schoolId,
                        ClassId = classId,
                        SectionId = sectionId,
                        InstallmentDate = baseDate.AddMonths(i * 12 / totalInstallments),
                        DateOfPay = dateOfPay,
                        PaidPayment = payment,
                        RemainingAmount = remainingAmountValue,
                        Status = statusValue,
                        IsActive = true,
                        IsDelete = false,
                        DateAdded = DateTime.Now,
                        DateModified = DateTime.Now,
                    };
                    studentInstallment.Add(newInstallment);
                }

                DbContext.StudentFeeInstallments.Add(newStudentFeeInstall);
                DbContext.SaveChanges();
                DbContext.StudentInstallments.AddRange(studentInstallment);
                DbContext.SaveChanges();
                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                feeAmount.Text = "";
                firstPayPayment.Text = "";
                negotiableAmount.Text = "";
                totalNoOfInstallment.Text = "";
                remainingAmount.Text = "";

                if (!frm.Visible)
                {
                    frm.TopLevel = false;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                    frm.BringToFront();
                    frm.Show();
                }

                if (this != null)
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
