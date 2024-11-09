using DocumentFormat.OpenXml.Office2010.Excel;
using SchoolManagement.Accounting;
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

namespace SchoolManagement.Academic
{
    public partial class EventCalenderDetails : Form
    {
        private List<EventViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        private int EventId;
        private int schoolId;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        Form frm;
        public EventCalenderDetails()
        {
            InitializeComponent();
        }

        private void EventCalenderDetails_Load(object sender, EventArgs e)
        {
            eventsrecord(1, pageSize);
            UpdateDataGridView();
        }

        private void eventsrecord(int pageNumber, int pageSize)
        {
            try
            {
                var data = DbContext.Events.Where(x => x.IsDelete != true).OrderBy(x => x.EventId)
                .Skip((pageNumber - 1) * pageSize).Take(pageSize)
                .Select(x => new EventViewModel
                {
                    EventId = x.EventId,
                    SchoolId = x.SchoolId,
                    EventTitle = x.EventTitle,
                    StartingDate = x.StartingDate,
                    EndingDate = x.EndingDate,
                    DescriptionSummary = x.DescriptionSummary,
                }).ToList();

                allData = data;
                EventRecordDataGridView.AutoGenerateColumns = false;

                totalRecords = DbContext.Events.Where(m => m.IsDelete != true).Count();

                TotalCount.Text = $"Total Count: {totalRecords}";

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AddNewEvent_Click(object sender, EventArgs e)
        {
            try
            {
                frm = (EventCalender)Application.OpenForms["EventCalender"];
                if (frm == null)
                {
                    frm = new EventCalender();
                }
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

        private void EventRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            EditStaffViewModel.SchoolId = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < EventRecordDataGridView.Columns.Count && EventRecordDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                EventId = Convert.ToInt32(EventRecordDataGridView.Rows[e.RowIndex].Cells["EventIdColumn"].Value);
                schoolId = Convert.ToInt32(EventRecordDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                EditStaffViewModel.Id = EventId;
                EditStaffViewModel.SchoolId = schoolId;
                if (EventId != null && EventId != 0 && schoolId != null && schoolId != 0)
                {
                    EventCalender form = new EventCalender();
                    form.TopLevel = false;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                    Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                    form.BringToFront();
                    form.Show();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < EventRecordDataGridView.Columns.Count && EventRecordDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                EventId = Convert.ToInt32(EventRecordDataGridView.Rows[e.RowIndex].Cells["EventIdColumn"].Value);
                schoolId = Convert.ToInt32(EventRecordDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = DbContext.Events.Find(EventId);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsActive = false;
                        entityToDelete.IsDelete = true;
                        DbContext.SaveChanges();

                        eventsrecord(1, pageSize);

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
            EventRecordDataGridView.DataSource = currentPageData;

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
    }
}
