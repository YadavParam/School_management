using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private List<ClassRoutineViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        Form form;
        private int Id;
        private int SchoolId;
        SchoolManagementEntities1 DbContext;
        public StaffDetails()
        {
            InitializeComponent();
            DbContext = new SchoolManagementEntities1();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            
            GetdataFromDatabase();
            //UpdateDataGridView();
        }

        private void GetdataFromDatabase()
        {
            var data = DbContext.SchoolStaffs.Where(m => m.IsDelete != true).Select(m => new
            {
                m.Id,
                m.SchoolId,
                FullName = m.FirstName + " " + m.LastName,
                m.Gender,
                m.Address,
                m.ClassId,
                m.SubjectId,
                m.Designation,
            }).ToList();
            SchoolStaffDataGridView.DataSource = data;

            //SchoolStaffDataGridView.AutoGenerateColumns = false;

            //TotalCount.Text = "Total Count: " + SchoolStaffDataGridView.Rows.Count.ToString();
        }

        private void SchoolStaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            EditStaffViewModel.SchoolId = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                EditStaffViewModel.Id = Id;
                if (Id != null && Id != 0)
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
            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();
            SchoolStaffDataGridView.DataSource = currentPageData;

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

    }
}
