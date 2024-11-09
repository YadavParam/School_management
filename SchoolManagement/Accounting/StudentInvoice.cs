using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Dapper;
using SchoolManagement.Accounting.IM_CrystalReports;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentInvoice : Form
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);

        public StudentInvoice()
        {
            InitializeComponent();
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
           
        }

        private void StudentInvoice_Load(object sender, EventArgs e)
        {
            string studentid = EditStaffViewModel.StudentId;
            int schoolId = EditStaffViewModel.SchoolId;
            //try
            //{
            //    var schoolid = schoolId;
            //    FeeInvoiceCrystalReport cr = new FeeInvoiceCrystalReport();

            //    using (var connection = new SqlConnection(ConnectionString))
            //    {

            //        var sql = "FeeInvoice";
            //        var properties = connection.Query<FeeInvoiceCrystalReportViewModel>(sql, new { SchoolId = schoolId, StudentId = studentid }, commandType: CommandType.StoredProcedure).ToList();


            //        foreach (var item in properties)
            //        {
            //            cr.SetParameterValue("SchoolName", item.SchoolName);
            //            cr.SetParameterValue("SchoolAddress", item.SchoolAddress);
            //            cr.SetParameterValue("Email", item.Email);
            //            cr.SetParameterValue("Phone", item.Phone);
            //            cr.SetParameterValue("StudentName", item.Name);
            //            cr.SetParameterValue("StudentAddress", item.Address);
            //            cr.SetParameterValue("PhoneNumber", item.PhoneNumber);
            //            cr.SetParameterValue("FatherName", item.FathersName);
            //            cr.SetParameterValue("Class", item.ClassId);
            //            cr.SetParameterValue("RollNumber", item.StudentId);
            //            cr.SetParameterValue("TotalFee", item.FeeAmount);
            //            cr.SetParameterValue("PaidPayment", item.FirstPayPayment);

            //        }

            //        crystalReportViewer.ReportSource = cr;
            //        crystalReportViewer.Refresh();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

            try
            {
                FeeInvoiceCrystalReport cr = new FeeInvoiceCrystalReport();
                using (var connection = new SqlConnection(ConnectionString))
                {

                    var sql = "FeeInvoice";
                    var properties = connection.Query<FeeInvoiceCrystalReportViewModel>(sql, new { SchoolId = schoolId, StudentId = studentid }, commandType: CommandType.StoredProcedure).ToList();

                    foreach (var item in properties)
                    {
                        crystalReportViewer.ReportSource = cr;

                        cr.SetParameterValue("SchoolName", item.SchoolName);
                        cr.SetParameterValue("SchoolAddress", item.SchoolAddress);
                        cr.SetParameterValue("Email", item.Email);
                        cr.SetParameterValue("Phone", item.Phone);
                        cr.SetParameterValue("StudentName", item.Name);
                        cr.SetParameterValue("StudentAddress", item.Address);
                        cr.SetParameterValue("PhoneNumber", item.PhoneNumber);
                        cr.SetParameterValue("FatherName", item.FathersName);
                        cr.SetParameterValue("Class", item.ClassId);
                        cr.SetParameterValue("RollNumber", item.StudentId);
                        cr.SetParameterValue("TotalFee", item.FeeAmount);
                        cr.SetParameterValue("PaidPayment", item.FirstPayPayment);

                        crystalReportViewer.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
