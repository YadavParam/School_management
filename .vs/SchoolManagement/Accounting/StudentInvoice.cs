using Dapper;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SchoolManagement.Accounting.IM_CrystalReports;
using System.Collections.Generic;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SchoolManagement.Accounting
{
    public partial class StudentInvoice : Form
    {
        private int SchoolId;
        private string StudentId;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);

        public StudentInvoice()
        {
            InitializeComponent();
        }

        private void StudentInvoice_Load(object sender, EventArgs e)
        {
            SchoolId = EditStaffViewModel.SchoolId;
            StudentId = EditStaffViewModel.StudentId;

            StudentInvoices();
        }

        public void StudentInvoices()
        {
            try
            {
                InvoiceCrystalReport cr = new InvoiceCrystalReport();

                try
                {
                    cr.Load(@"D:\schmament\schmament\SchoolManagement\Accounting\IM_CrystalReports\InvoiceCrystalReport.rpt");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cr.DataDefinition == null)
                {
                    MessageBox.Show("Report DataDefinition is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (cr.DataDefinition.ParameterFields == null || cr.DataDefinition.ParameterFields.Count == 0)
                {
                    MessageBox.Show("No parameters found in the report.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = "FeeInvoice";
                    var properties = connection.Query<FeeInvoiceCrystalReportViewModel>( sql, new { SchoolId = SchoolId, StudentId = StudentId },
                        commandType: CommandType.StoredProcedure ).ToList();

                    if (properties.Count == 0)
                    {
                        MessageBox.Show("No data found for the specified SchoolId and StudentId.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var item = properties.First();

                    var parameterMappings = new Dictionary<string, object>
                    {
                         { "@SchoolId", SchoolId },
                         { "SchoolName", item.SchoolName },
                         { "SchoolAddress", item.SchoolAddress },
                         { "Email", item.Email },
                         { "Phone", item.Phone },
                         { "StudentName", item.Name },
                         { "StudentAddress", item.Address },
                         { "PhoneNumber", item.PhoneNumber },
                         { "FatherName", item.FathersName },
                         { "Class", item.ClassId },
                         { "@StudentId", item.StudentId },
                         { "TotalFee", item.FeeAmount },
                         { "PaidPayment", item.FirstPayPayment }
                    };

                    foreach (ParameterFieldDefinition parameter in cr.DataDefinition.ParameterFields)
                    {
                        if (parameterMappings.TryGetValue(parameter.Name, out var value))
                        {
                            cr.SetParameterValue(parameter.Name, value); 
                        }
                        else
                        {
                            MessageBox.Show($"Parameter '{parameter.Name}' not recognized.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    crystalReportViewer.ReportSource = cr;
                    crystalReportViewer.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, if the problem continues, please contact Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
