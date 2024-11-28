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
using Dapper;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagement.Academic;
using SchoolManagement.Accounting;
using SchoolManagement.Helper;
using  SchoolManagement.HelperClasses;
using SchoolManagement.Model;
using SchoolManagement.Users;

namespace SchoolManagement
{
    public partial class StaffDetails : Form
    {
        private List<SchoolStaffViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        Form form;
        private int Id;
        private int SchoolId;
        private int UserId;
        SchoolManagementEntities1 DbContext;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        public StaffDetails()
        {
            InitializeComponent();
            DbContext = new SchoolManagementEntities1();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            
            GetdataFromDatabase();
            UpdateDataGridView();
        }

        private void GetdataFromDatabase()
        {
            try
            {
                var schoolid = 2008;
                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select stf.UserId,stf.Id,stf.SchoolId,CONCAT(COALESCE(FirstName, ''), ' ', COALESCE(LastName, '')) AS Name,stf.Gender,stf.Address,cla.ClassName,sub.SubjectName,stf.Designation
                    from SchoolStaff stf left join Subject sub on sub.SubjectId = stf.SubjectId left join Class cla on cla.ClassId = stf.ClassId 
                    where stf.IsActive=1 and stf.SchoolId={schoolid}");
                    allData = connection.Query<SchoolStaffViewModel>(sql.ToString()).ToList();

                    SchoolStaffDataGridView.Rows.Clear();

                    foreach (var item in allData)
                    {
                        SchoolStaffDataGridView.Rows.Add(item.UserId, item.Id, item.SchoolId, item.Name, item.Gender, item.Address, item.ClassName, item.SubjectName, item.Designation);

                    }

                    SchoolStaffDataGridView.AutoGenerateColumns = false;

                    TotalCount.Text = "Total Count: " + SchoolStaffDataGridView.Rows.Count.ToString();

                    UpdateDataGridView();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SchoolStaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            EditStaffViewModel.SchoolId = 0;
            EditStaffViewModel.UserId = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                SchoolId = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                UserId = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["UserIdColumn"].Value);
                EditStaffViewModel.Id = Id;
                EditStaffViewModel.SchoolId = SchoolId;
                EditStaffViewModel.UserId = UserId;
                if (Id != null && Id != 0 && SchoolId != 0 && UserId !=0)
                {
                    SchoolSatff form = new SchoolSatff();
                    form.TopLevel = false;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                    form.BringToFront();
                    form.Show();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = DbContext.SchoolStaffs.Find(Id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        entityToDelete.IsActive = false;
                        DbContext.SaveChanges();

                        GetdataFromDatabase();

                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Staff Details")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                SchoolId = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                EditStaffViewModel.Id = Id;
                EditStaffViewModel.SchoolId = SchoolId;

                if (form == null || form.IsDisposed)
                {
                    form = new StaffDetailsPopUp();
                    form.Show();
                }
                else
                {
                    form.BringToFront();
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            form = (SchoolSatff)Application.OpenForms["SchoolSatff"];
            if (form == null)
            {
                form = new SchoolSatff();
            }
            form.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void UpdateDataGridView()
        {
            SchoolStaffDataGridView.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                SchoolStaffDataGridView.Rows.Add(item.UserId, item.Id, item.SchoolId, item.Name, item.Gender, item.Address, item.ClassName, item.SubjectName, item.Designation);
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


        private void UpdateDataGridView(List<SchoolStaffViewModel> data = null)
        {
            SchoolStaffDataGridView.Rows.Clear();

            var sourceData = data ?? allData.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in sourceData)
            {
                SchoolStaffDataGridView.Rows.Add(
                    item.UserId,
                    item.Id,
                    item.SchoolId,
                    item.Name,
                    item.Gender,
                    item.Address,
                    item.ClassName,
                    item.SubjectName,
                    item.Designation
                );
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
            if (Search.Text == "Enter Staff Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Staff Name";

            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text) || Search.Text == "Enter Staff Name")
            {
                UpdateDataGridView();
            }
            else
            {
                var filteredData = allData.Where(x => x.Name.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                UpdateDataGridView(filteredData);
            }

            SchoolStaffDataGridView.Refresh();
        }
    }
}
