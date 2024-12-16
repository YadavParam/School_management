using CsvHelper;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement.Accounting
{
    public partial class ExpenseManager : Form
    {
        private int expenseIdToUpdate;
        private int SchoolId;
        private SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        Form frm;
        public ExpenseManager()
        {
            InitializeComponent();
        }

        private void ExpenseManager_Load(object sender, EventArgs e)
        {
            int Id = EditStaffViewModel.Id;
            SchoolId = EditStaffViewModel.SchoolId;
            if (Id != null && Id != 0 && SchoolId != null && SchoolId != 0)
            {
                GetExpenseData(Id, SchoolId);
            }
        }

        private void ExpenseSubmit_Click(object sender, EventArgs e)
        {
            var message = "";
            try
            {
                if (ExpenseSubmit.Text.Trim() == "Submit")
                {
                    var expense = new Expens
                    {
                        SchoolId = 2008,
                        Date = Convert.ToDateTime(Date.Text),
                        ExpenseCategory = ExpenseCategory.Text,
                        Amount = float.TryParse(Amount.Text, out float amountValue) ? amountValue : 0.0f,
                        ExpenseType = ExpenseType.Text,
                        IsActive = true,
                        IsDelete = false,
                        DateAdded = DateTime.Now,
                        DateModified = DateTime.Now,
                    };
                    var expenseValidate = validate.ValidateExpenseManager(expense);
                    if (expenseValidate.Status == true)
                    {
                        MessageBox.Show(expenseValidate.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DbContext.Expenses.Add(expense);
                        DbContext.SaveChanges();

                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExpenseCategory.Text = "";
                        Amount.Text = "";
                        ExpenseType.SelectedIndex = -1;
                    }
                }
                else if (ExpenseSubmit.Text == "Update")
                {
                    UpdateExpense();
                }
            }
            catch (Exception)
            {
                message = "Something went wrong, if problem occurs continue, please contact to Singhtek!!";
                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void GetExpenseData(int Id, int SchoolId)
        {
            try
            {
                var expenseDetails = DbContext.Expenses.AsNoTracking().FirstOrDefault(x => x.Id == Id && x.SchoolId == SchoolId);
                if (expenseDetails != null)
                {
                    expenseIdToUpdate = expenseDetails.Id;
                    if (expenseDetails.Date.HasValue)
                    {
                        Date.Value = expenseDetails.Date.Value;
                    }
                    ExpenseCategory.Text = expenseDetails.ExpenseCategory;
                    Amount.Text = (expenseDetails.Amount ?? 0.0f).ToString("N2");
                    ExpenseType.Text = expenseDetails.ExpenseType;

                    ExpenseSubmit.Text = "Update";
                }
                else
                {
                    MessageBox.Show("Expense details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateExpense()
        {
            try
            {
                var expenseDetails = DbContext.Expenses.AsNoTracking().FirstOrDefault(x => x.Id == expenseIdToUpdate && x.SchoolId == SchoolId);
                if (expenseDetails != null)
                {
                    expenseDetails.Date = Convert.ToDateTime(Date.Text);
                    expenseDetails.ExpenseCategory = ExpenseCategory.Text;
                    expenseDetails.Amount = float.TryParse(Amount.Text, out float amountValue) ? amountValue : 0.0f;
                    expenseDetails.ExpenseType = ExpenseType.Text;
                    var expenseValidate = validate.ValidateExpenseManager(expenseDetails);
                    if (expenseValidate.Status == true)
                    {
                        MessageBox.Show(expenseValidate.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        expenseDetails.DateModified = DateTime.Now;
                        DbContext.Entry(expenseDetails).State = EntityState.Modified;
                        DbContext.SaveChanges();

                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearFormFields();
                        ExpenseSubmit.Text = "Submit";
                        this.Hide();
                        frm = new ExpenseManagerDetails();
                        frm.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                        frm.BringToFront();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Expense details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearFormFields()
        {
            Date.Text = string.Empty;
            ExpenseCategory.Text = string.Empty;
            Amount.Text = string.Empty;
            ExpenseType.SelectedIndex = -1;
        }
    }
}
