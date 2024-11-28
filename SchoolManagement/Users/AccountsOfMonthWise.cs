using Dapper;
using DocumentFormat.OpenXml.Wordprocessing;
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

namespace SchoolManagement.Users
{
    public partial class AccountsOfMonthWise : Form
    {
        private List<AccountsOfMonthWiseViewModel> allData;
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
        public AccountsOfMonthWise()
        {
            InitializeComponent();
        }

        private void AccountsOfMonthWise_Load(object sender, EventArgs e)
        {
            studentrecord();
        }

        private void studentrecord()
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                var schoolid = 2008;  
                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"SELECT stu.Id,stu.StudentId,stu.SchoolId,stu.ClassId,stu.SectionId,stu.Name,cla.ClassName,CAST(stuFeeIns.FeeAmount AS DECIMAL(10, 2)) AS FeeAmount,COALESCE(
                    SUM(CAST(stuInstal.PaidPayment AS DECIMAL(10, 2))),
                    CASE 
                    WHEN stuFeeIns.NegotiableAmount IS NOT NULL 
                    THEN CAST(stuFeeIns.FeeAmount AS DECIMAL(10, 2)) - CAST(stuFeeIns.NegotiableAmount AS DECIMAL(10, 2))  
                    ELSE CAST(stuFeeIns.FeeAmount AS DECIMAL(10, 2)) 
                    END
                    ) AS TotalPaidPayment, COALESCE(MAX(stuInstal.Status), 'Paid') AS LatestStatus
                    FROM Student stu LEFT JOIN Class cla ON cla.ClassId = stu.ClassId LEFT JOIN StudentFeeInstallment stuFeeIns ON stuFeeIns.StudentId = stu.StudentId
                    LEFT JOIN StudentInstallment stuInstal ON stuInstal.StudentId = stu.StudentId
                    WHERE stu.IsActive = 1 AND stu.SchoolId = @schoolid AND MONTH(stuFeeIns.DateModified) = @CurrentMonth AND YEAR(stuFeeIns.DateModified) = @CurrentYear
                    GROUP BY stu.Id,stu.StudentId,stu.SchoolId, stu.ClassId,stu.SectionId,stu.Name,cla.ClassName,stuFeeIns.FeeAmount,
                    stuFeeIns.NegotiableAmount;");

                    allData = connection.Query<AccountsOfMonthWiseViewModel>(sql.ToString(), new { SchoolId = schoolid, CurrentMonth = currentMonth, CurrentYear = currentYear }).ToList();

                    AccountsMonthWiseRecord.Rows.Clear();

                    foreach (var item in allData)
                    {

                        AccountsMonthWiseRecord.Rows.Add(item.SchoolId, item.StudentId, item.ClassId, item.SectionId, item.Name,  item.ClassName, item.FeeAmount, item.TotalPaidPayment, item.LatestStatus);
                    }

                    AccountsMonthWiseRecord.AutoGenerateColumns = false;

                    TotalCount.Text = "Total Count: " + AccountsMonthWiseRecord.Rows.Count.ToString();

                    UpdateDataGridView();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateDataGridView()
        {
            AccountsMonthWiseRecord.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                AccountsMonthWiseRecord.Rows.Add(item.SchoolId, item.StudentId, item.ClassId, item.SectionId, item.Name, item.ClassName, item.FeeAmount, item.TotalPaidPayment, item.LatestStatus);
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


        private void UpdateDataGridView(List<AccountsOfMonthWiseViewModel> data = null)
        {
            AccountsMonthWiseRecord.Rows.Clear();

            var sourceData = data ?? allData.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in sourceData)
            {
                AccountsMonthWiseRecord.Rows.Add(item.SchoolId, item.StudentId, item.ClassId, item.SectionId, item.Name, item.ClassName, item.FeeAmount, item.TotalPaidPayment, item.LatestStatus);
            }

            if (data == null)
            {
                previousBtn.Enabled = currentPage > 0;
                nextBtn.Enabled = currentPage < TotalPages - 1;
                btnBetweenPg.Text = $"Pages: {currentPage + 1} / {TotalPages}";
            }
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Enter Student Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Student Name";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text) || Search.Text == "Enter Student Name")
            {
                UpdateDataGridView();
            }
            else
            {
                var filteredData = allData.Where(x => x.Name.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                UpdateDataGridView(filteredData);
            }

            AccountsMonthWiseRecord.Refresh();
        }
    }
}
