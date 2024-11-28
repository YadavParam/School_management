using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class ExpenseManagerDetails : Form
    {
        private List<ExpenseManagerViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        private int Id;
        private int schoolId;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        Form form;
        public ExpenseManagerDetails()
        {
            InitializeComponent();
        }

        private void ExpenseManagerDetails_Load(object sender, EventArgs e)
        {
            expensesrecord(1, pageSize);
            UpdateDataGridView();
        }

        private void ExpenseManager_Click(object sender, EventArgs e)
        {
            form = (ExpenseManager)Application.OpenForms["ExpenseManager"];
            if (form == null)
            {
                form = new ExpenseManager();
            }
            form.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void expensesrecord(int pageNumber, int pageSize)
        {
            try
            {
                var data = DbContext.Expenses.Where(m => m.IsDelete != true).OrderBy(m => m.Id)
                .Skip((pageNumber - 1) * pageSize).Take(pageSize)
                .Select(m => new ExpenseManagerViewModel
                {
                    Id = m.Id,
                    SchoolId = m.SchoolId,
                    Date = m.Date,
                    ExpenseCategory = m.ExpenseCategory,
                    Amount = m.Amount,
                    ExpenseType = m.ExpenseType,
                }).ToList();

                allData = data;
                ExpensesRecord.AutoGenerateColumns = false;

                totalRecords = DbContext.Expenses.Where(m => m.IsDelete != true).Count();

                TotalCount.Text = $"Total Count: {totalRecords}";

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExpensesRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            EditStaffViewModel.SchoolId = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ExpensesRecord.Columns.Count && ExpensesRecord.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Id = Convert.ToInt32(ExpensesRecord.Rows[e.RowIndex].Cells["IdColumn"].Value);
                schoolId = Convert.ToInt32(ExpensesRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                EditStaffViewModel.Id = Id;
                EditStaffViewModel.SchoolId = schoolId;
                if (Id != null && Id != 0 && schoolId != null && schoolId != 0)
                {
                    ExpenseManager form = new ExpenseManager();
                    form.TopLevel = false;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                    form.BringToFront();
                    form.Show();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ExpensesRecord.Columns.Count && ExpensesRecord.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Id = Convert.ToInt32(ExpensesRecord.Rows[e.RowIndex].Cells["IdColumn"].Value);
                schoolId = Convert.ToInt32(ExpensesRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = DbContext.Expenses.Find(Id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsActive = false;
                        entityToDelete.IsDelete = true;
                        DbContext.SaveChanges();

                        expensesrecord(1, pageSize);

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateDataGridView()
        {
            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();
            ExpensesRecord.DataSource = currentPageData;

            previousBtn.Enabled = currentPage > 0;
            nextBtn.Enabled = currentPage < TotalPages - 1;

            btnBetweenPg.Text = $"Pages: {currentPage + 1} / {TotalPages}";
        }

        private int TotalPages => allData != null ? (int)Math.Ceiling((double)allData.Count / pageSize) : 0;

        private void previousBtn_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateDataGridView();
            }
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            if (currentPage < TotalPages - 1)
            {
                currentPage++;
                UpdateDataGridView();
            }
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            if(Search.Text == "Enter Expense Category")
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
                ExpensesRecord.DataSource = allData;
            }
            else
            {
                var filteredData = allData.Where(x => x.ExpenseCategory.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                ExpensesRecord.DataSource = filteredData;
            }

            ExpensesRecord.Refresh();
        }
    }
}
