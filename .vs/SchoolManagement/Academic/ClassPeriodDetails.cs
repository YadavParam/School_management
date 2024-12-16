using Dapper;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.VariantTypes;
using Krypton.Toolkit;
using SchoolManagement.Accounting;
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

namespace SchoolManagement.Academic
{
    public partial class ClassPeriodDetails : Form
    {
        private List<ClassRoutineViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int classId;
        private string sectionId;
        private int schoolId;
        private int teacherId;
        private string periodEdit;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Form frm;
        public ClassPeriodDetails()
        {
            InitializeComponent();
        }

        private void ClassPeriodDetails_Load(object sender, EventArgs e)
        {
            ClassRecord();
        }

        private void ClassRecord()
        {
            try
            {
                var schoolid = 2008;
                System.Data.DataTable dt = new System.Data.DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select clteach.Id,clteach.SchoolId,clteach.ClassId,clteach.SectionId,clteach.ClassTeacher,clteach.Period,class.ClassName,concat(schstf.FirstName, ' ', schstf.LastName) as StaffName,clasec.SectionName
                    from ClassTeacherAcademic clteach left join Class class on class.ClassId=clteach.ClassId left join SchoolStaff schstf on schstf.Id = clteach.ClassTeacher 
                    left join Class_Section clasec on clasec.SectionId =clteach.SectionId 
                    where clteach.IsActive=1 and clteach.SchoolId={schoolid}");
                    allData = connection.Query<ClassRoutineViewModel>(sql.ToString()).ToList();

                    DetailPeriodDataGridView.Rows.Clear();

                    foreach (var item in allData)
                    {
                        DetailPeriodDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.StaffName, item.Period, item.ClassId, item.SectionId, item.SchoolId, item.ClassTeacher);
                    }

                }

                DetailPeriodDataGridView.AutoGenerateColumns = false;

                TotalCount.Text = "Total Count: " + DetailPeriodDataGridView.Rows.Count.ToString();

                UpdateDataGridView();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DetailPeriodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.ClassId = 0;
            EditStaffViewModel.SchoolId = 0;
            EditStaffViewModel.SectionId = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < DetailPeriodDataGridView.Columns.Count && DetailPeriodDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                classId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["ClassIdColumn"]?.Value);
                schoolId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                sectionId = DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value?.ToString();
                teacherId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["TeacherIdColumn"]?.Value);
                periodEdit = DetailPeriodDataGridView.Rows[e.RowIndex].Cells["TotalPeriodColumn"].Value?.ToString();

                EditStaffViewModel.SchoolId = schoolId;

                var a = classId;
                classperiods.Classid = a;
                var b = sectionId;
                classperiods.SectionId = b;

                var c = teacherId;
                classperiods.TeacherId = c;

                var d = periodEdit;
                classperiods.TotalPeriod = d;

                getPeriodData(classId, schoolId, sectionId);

            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < DetailPeriodDataGridView.Columns.Count && DetailPeriodDataGridView.Columns[e.ColumnIndex].HeaderText == "Show Period")
            {
                schoolId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                classId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["ClassIdColumn"]?.Value);
                sectionId = DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value?.ToString();
                
                EditStaffViewModel.SchoolId = schoolId;
                EditStaffViewModel.ClassId = classId;
                EditStaffViewModel.SectionId = sectionId;

                if (frm == null || frm.IsDisposed)
                {
                    frm = new ViewPeriodsPopUp();
                    frm.Show();
                }
                else
                {
                    frm.BringToFront();
                }

            }
        }

        public void getPeriodData(int classId, int schoolId, string sectionId)
        {
            try
            {
                ClassPeriod form = new ClassPeriod();
                
                var getTotalPeriods = Db.ClassTeacherAcademics.AsNoTracking().FirstOrDefault(x => x.ClassId == classId && x.SchoolId == schoolId && x.SectionId == sectionId);
                if (getTotalPeriods != null)
                {
                    var getPeriodDetails = Db.ClassPeriodAcademics.AsNoTracking().FirstOrDefault(x => x.ClassId == classId && x.SchoolId == schoolId && x.SectionId == sectionId);
                    if (getPeriodDetails != null)
                    {
                        using (var connection = new SqlConnection(ConnectionString))
                        {
                            var sql = new StringBuilder($@"select clP.Id as Id,clP.Period,clP.TimingFrom,clP.TimingTo,clP.Duration,sub.SubjectId,sub.SubjectName,schstf.Id as TeacherId, concat(schstf.FirstName, ' ', schstf.LastName) as TeacherName
                                from ClassPeriodAcademic clP left join Class class on class.ClassId=clP.ClassId left join Subject sub on sub.SubjectId=clP.SubjectId left join SchoolStaff schstf on schstf.Id = clP.TeacherId
                                where clP.IsActive=1 and clP.SchoolId={schoolId} and clP.ClassId={classId} and clP.SectionId='{sectionId}'");
                            var properties = connection.Query<ClassPeriodViewModel>(sql.ToString()).ToList();

                            var periodDataGridView = form.Controls.Find("PeriodDataGridView", true).FirstOrDefault() as DataGridView;
                            if (periodDataGridView != null)
                            {
                                foreach (var item in properties)
                                {
                                    
                                    periodDataGridView.Rows.Add(item.Id, item.Period, item.SubjectId, item.TeacherId, item.TimingFrom, item.TimingTo, item.Duration);
                                }

                                var subjectColumn = periodDataGridView.Columns["SubjectColumn"] as DataGridViewComboBoxColumn;
                                subjectColumn.DisplayMember = "Text";
                                subjectColumn.ValueMember = "Value";
                                subjectColumn.DataSource = properties.Select(p => new { Value = p.SubjectId, Text = p.SubjectName }).Distinct().ToList();

                                var teacherColumn = periodDataGridView.Columns["TeacherNameColumn"] as DataGridViewComboBoxColumn;
                                teacherColumn.DisplayMember = "Text";
                                teacherColumn.ValueMember = "Value";
                                teacherColumn.DataSource = properties.Select(p => new { Value = p.TeacherId, Text = p.TeacherName }).Distinct().ToList();
                            }

                            if (!form.Visible)
                            {
                                form.TopLevel = false;
                                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                                form.BringToFront();
                                form.Show();

                                form.PeriodSubmit.Text = "Update";
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Period record not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Total period record not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ClassPeriodAdd_Click(object sender, EventArgs e)
        {
            frm = (ClassPeriod)Application.OpenForms["ClassPeriod"];
            if (frm == null)
            {
                frm = new ClassPeriod();
            }
            ClearFormControls(frm);
            frm.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ClearFormControls(Form frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is KryptonTextBox textBox)
                {
                    textBox.Clear(); 
                }
                else if (control is KryptonComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; 
                }
            }
            if (frm is ClassPeriod form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is KryptonDataGridView datGridView)
                    {
                        form.PeriodDataGridView.Rows.Clear();
                    }
                }
            }
            if (frm is ClassPeriod frms && frms.PeriodSubmit.Text == "Update")
            {
                frms.PeriodSubmit.Text = "Submit";

                frms.classSelect.SelectedIndex = -1;
                frms.sectionSelect.SelectedIndex = -1;
                frms.teacherSelect.SelectedIndex = -1;
                frms.period.Text = "";
            }
        }

        private void UpdateDataGridView()
        {
            DetailPeriodDataGridView.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                DetailPeriodDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.StaffName, item.Period, item.ClassId, item.SectionId, item.SchoolId, item.ClassTeacher);
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


        private void UpdateDataGridView(List<ClassRoutineViewModel> data = null)
        {
            DetailPeriodDataGridView.Rows.Clear();

            var sourceData = data ?? allData.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in sourceData)
            {
                DetailPeriodDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.StaffName, item.Period, item.ClassId, item.SectionId, item.SchoolId, item.ClassTeacher);
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
            if (Search.Text == "Enter Class Teacher Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Class Teacher Name";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text) || Search.Text == "Enter Class Teacher Name")
            {
                UpdateDataGridView();
            }
            else
            {
                var filteredData = allData.Where(x => x.StaffName.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                UpdateDataGridView(filteredData);
            }

            DetailPeriodDataGridView.Refresh();
        }
    }
}
