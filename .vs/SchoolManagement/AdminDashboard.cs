using Dapper;
using SchoolManagement.Academic;
using SchoolManagement.Accounting;
using SchoolManagement.Model;
using SchoolManagement.Users;
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

namespace SchoolManagement
{
    public partial class AdminDashboard : Form
    {
        private List<AccountsOfMonthWiseViewModel> acountData;
        private List<ExpenseManagerViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        Form frm;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            NoOfStudentShow();
            NoOfTeacherShow();
            NoOfParentShow();
            NoOfStaffsShow();
            NextEventDates();
            ExpenseMonthDynamicallyChange();
            AccountsMonthDynamicallyChange();
            expensesrecord();
            Accountsrecord();
        }

        private void NoOfStudentShow()
        {
            int studentCount = DbContext.Students.Count();

            NoOfStudentsShow.Text = $"{studentCount}";
        }

        private void NoOfTeacherShow()
        {
            int teacherCount = DbContext.Users.Count(x => x.UserType == 2 && x.IsActive == true);

            NoOfTeachersShow.Text = $"{teacherCount}";
        }

        private void NoOfParentShow()
        {
            int parentCount = DbContext.Parents.Count();

            NoOfParentsShow.Text = $"{parentCount}";
        }

        private void NoOfStaffsShow()
        {
            int staffCount = DbContext.Users.Count();

            NoOfStaffShow.Text = $"{staffCount}";
        }

        private void NextEventDates()
        {
            DateTime currentDate = DateTime.Now;

            var nextEvent = DbContext.Events.Where(x => x.IsActive == true && x.StartingDate >= currentDate)
                .OrderBy(x => x.StartingDate)
                .FirstOrDefault();

            if (nextEvent != null)
            {
                EventTitle.Text = nextEvent.EventTitle;

                string output = string.Empty;

                string startingDate = nextEvent.StartingDate?.ToString("ddd, dd-MMM-yyyy");

                if (nextEvent.EndingDate.HasValue)
                {
                    string endingDate = nextEvent.EndingDate.Value.ToString("ddd, dd-MMM-yyyy");

                    output = $"{startingDate} - {endingDate}";
                }
                else
                {
                    output = startingDate;
                }

                NextEventDate.Text = output;
            }
            else
            {
                EventTitle.Text = "No upcoming events";
            }
        }

        private void NoOfStudentsClick_Click(object sender, EventArgs e)
        {
            frm = (StudentDetails)Application.OpenForms["StudentDetails"];
            if (frm == null)
            {
                frm = new StudentDetails();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void NoOfTeachersClick_Click(object sender, EventArgs e)
        {
            frm = (StaffDetails)Application.OpenForms["StaffDetails"];
            if (frm == null)
            {
                frm = new StaffDetails();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void NoOfParentsClick_Click(object sender, EventArgs e)
        {
            frm = (ParentDetails)Application.OpenForms["ParentDetails"];
            if (frm == null)
            {
                frm = new ParentDetails();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void NoOfStaffClick_Click(object sender, EventArgs e)
        {
            frm = (StaffDetails)Application.OpenForms["StaffDetails"];
            if (frm == null)
            {
                frm = new StaffDetails();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void GoToAttendence_Click(object sender, EventArgs e)
        {
            frm = (StudentAttandence)Application.OpenForms["StudentAttandence"];
            if (frm == null)
            {
                frm = new StudentAttandence();
            }
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void RecentEventClick_Click(object sender, EventArgs e)
        {
            try
            {
                EventCalenderDetails frm = new EventCalenderDetails();
                frm.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExpenseMonthDynamicallyChange()
        {
            DateTime currentDate = DateTime.Now;

            string monthName = currentDate.ToString("MMMM").ToUpper(); 
            int year = currentDate.Year; 

            string output = $"{monthName}";

            ExpenseMonthDynamic.Text = output;
        }

        private void expensesrecord()
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month;
                int currentYear = currentDate.Year;

                var data = DbContext.Expenses.Where(m => m.IsDelete != true && m.Date.HasValue && m.Date.Value.Month == currentMonth && m.Date.Value.Year == currentYear)
                .OrderBy(m => m.Id)
                .Select(m => new ExpenseManagerViewModel
                 {
                    Id = m.Id,
                    SchoolId = m.SchoolId,
                    Date = m.Date.Value,
                    ExpenseCategory = m.ExpenseCategory,
                    Amount = m.Amount,
                 }).ToList();

                allData = data;

                ExpensesOfMonthsDataGridView.AutoGenerateColumns = false;
                ExpensesOfMonthsDataGridView.DataSource = allData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExpensesOfMonths_Click(object sender, EventArgs e)
        {
            try
            {
                ExpensesOfMonthWise frm = new ExpensesOfMonthWise();
                frm.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AccountsMonthDynamicallyChange()
        {
            DateTime currentDate = DateTime.Now;

            string monthName = currentDate.ToString("MMMM").ToUpper();
            int year = currentDate.Year;

            string output = $"{monthName}";

            AccountsMonthDynamic.Text = output;
        }

        private void Accountsrecord()
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
                    WHERE stu.IsActive = 1 AND stu.SchoolId = @SchoolId AND MONTH(stuFeeIns.DateModified) = @CurrentMonth AND YEAR(stuFeeIns.DateModified) = @CurrentYear
                    GROUP BY stu.Id,stu.StudentId,stu.SchoolId, stu.ClassId,stu.SectionId,stu.Name,cla.ClassName,stuFeeIns.FeeAmount,
                    stuFeeIns.NegotiableAmount;");

                    acountData = connection.Query<AccountsOfMonthWiseViewModel>(sql.ToString(), new { SchoolId = schoolid, CurrentMonth = currentMonth, CurrentYear = currentYear }).ToList();

                    AccountsOfMonthDataGridView.Rows.Clear();

                    foreach (var item in acountData)
                    {
                         
                        AccountsOfMonthDataGridView.Rows.Add(item.SchoolId, item.StudentId, item.ClassId, item.SectionId, item.Name, item.ClassName, item.FeeAmount, item.TotalPaidPayment, item.LatestStatus);
                    }

                    AccountsOfMonthDataGridView.AutoGenerateColumns = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AccountsOfMonths_Click(object sender, EventArgs e)
        {
            try
            {
                AccountsOfMonthWise frm = new AccountsOfMonthWise();
                frm.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
