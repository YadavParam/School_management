using DocumentFormat.OpenXml.Wordprocessing;
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

namespace SchoolManagement.Accounting
{
    public partial class ExpensesOfMonthWise : Form
    {
        private List<ExpenseManagerViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        Form form;
        public ExpensesOfMonthWise()
        {
            InitializeComponent();
        }

        private void ExpensesOfMonthWise_Load(object sender, EventArgs e)
        {
            expensesrecord(1, pageSize);
        }

        private void expensesrecord(int pageNumber, int pageSize)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                int currentMonth = currentDate.Month; 
                int currentYear = currentDate.Year;

                var data = DbContext.Expenses.Where(m => m.IsDelete != true && m.Date.HasValue && m.Date.Value.Month == currentMonth && m.Date.Value.Year == currentYear)
                .OrderBy(m => m.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize)
                .Select(m => new ExpenseManagerViewModel
                {
                    Id = m.Id,
                    SchoolId = m.SchoolId,
                    Date = m.Date.Value,
                    ExpenseCategory = m.ExpenseCategory,
                    Amount = m.Amount,
                    ExpenseType = m.ExpenseType,
                }).ToList();

                allData = data;
                ExpensesMonthWiseRecord.AutoGenerateColumns = false;

                totalRecords = DbContext.Expenses.Where(m => m.IsDelete != true && m.Date.HasValue && m.Date.Value.Month == currentMonth && m.Date.Value.Year == currentYear).Count();

                TotalCount.Text = $"Total Count: {totalRecords}";

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void UpdateDataGridView()
        {
            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();
            ExpensesMonthWiseRecord.DataSource = currentPageData;

            previousBtn.Enabled = currentPage > 0;
            nextBtn.Enabled = currentPage < TotalPages - 1;

            btnBetweenPg.Text = $"Pages: {currentPage + 1} / {TotalPages}";
        }

        private int TotalPages => allData != null ? (int)Math.Ceiling((double)allData.Count / pageSize) : 0;

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

        private void Search_Enter(object sender, EventArgs e)
        {
            if (Search.Text == "Enter Expense Category")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Expense Category";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Enter Expense Category")
            {
                ExpensesMonthWiseRecord.DataSource = allData;
            }
            else
            {
                var filteredData = allData.Where(x => x.ExpenseCategory.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                ExpensesMonthWiseRecord.DataSource = filteredData;
            }

            ExpensesMonthWiseRecord.Refresh();
        }
    }
}
