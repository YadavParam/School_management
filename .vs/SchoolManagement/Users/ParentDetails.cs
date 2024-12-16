using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagement.Accounting;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Users
{
    public partial class ParentDetails : Form
    {
        private List<ParentsViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        private int Id;
        private int schoolId;
        private string parentId;
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Form form;
        public ParentDetails()
        {
            InitializeComponent();
        }

        private void ParentDetails_Load(object sender, EventArgs e)
        {
            DataOfParentDetails(1, pageSize);
        }

        private void DataOfParentDetails(int pageNumber, int pageSize)
        {
            var data = Db.Parents.Where(x => x.IsDelete != true).OrderBy(x => x.Id)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize)
            .Select(x => new ParentsViewModel
            {
                Id = x.Id,
                SchoolId = x.SchoolId,
                ParentId = x.ParentId,
                FathersName = x.FathersName,
                MothersName = x.MothersName,
                FathersMailId = x.FathersMailId,
                MothersMailId = x.MothersMailId,
                FathersMobileNumber = x.FathersMobileNumber,
                MothersMobileNumber = x.MothersMobileNumber,
                FathersOccupation = x.FathersOccupation,
                MothersOccupation = x.MothersOccupation,
                FathersBloodGroup = x.FathersBloodGroup,
                MothersBloodGroup = x.MothersBloodGroup,
                Password = x.Password,
                Address = x.Address,
            }).ToList();

            allData = data;
            ParentRecord.AutoGenerateColumns = false;

            totalRecords = Db.Parents.Where(m => m.IsDelete != true).Count();

            TotalCount.Text = $"Total Count: {totalRecords}";

            UpdateDataGridView();
        }

        private void ParentRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            EditStaffViewModel.SchoolId = 0;
            EditStaffViewModel.ParentId = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ParentRecord.Columns.Count && ParentRecord.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Id = Convert.ToInt32(ParentRecord.Rows[e.RowIndex].Cells["IdColumn"].Value);
                schoolId = Convert.ToInt32(ParentRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                parentId = ParentRecord.Rows[e.RowIndex].Cells["ParentIdColumn"]?.Value.ToString();
                EditStaffViewModel.Id = Id;
                EditStaffViewModel.SchoolId = schoolId;
                EditStaffViewModel.ParentId= parentId;
                if (Id != null && Id != 0 && schoolId != null && schoolId != 0 && parentId != "")
                {
                    Parents form = new Parents();
                    form.TopLevel = false;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                    form.BringToFront();
                    form.Show();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ParentRecord.Columns.Count && ParentRecord.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Id = Convert.ToInt32(ParentRecord.Rows[e.RowIndex].Cells["IdColumn"].Value);
                schoolId = Convert.ToInt32(ParentRecord.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = Db.Parents.Find(Id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsActive = false;
                        entityToDelete.IsDelete = true;
                        Db.SaveChanges();

                        DataOfParentDetails(1, pageSize);

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
            ParentRecord.DataSource = currentPageData;

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
            if (Search.Text == "Enter Parent's Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Parent's Name";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Enter Parent's Name")
            {
                ParentRecord.DataSource = allData;
            }
            else
            {
                var filteredData = allData.Where(x => x.FathersName.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                 x.MothersName.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                ParentRecord.DataSource = filteredData;
            }

            ParentRecord.Refresh();
        }
    }
}
