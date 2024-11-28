using Dapper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class ClassAcademic : Form
    {
        private List<ClassViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private string SectionId;
        private int widthtag = 0;
        private int widthtagnew = 1;
        private int StreamId;
        private SchoolManagementEntities1 DbContext;
        validations validates = new validations();
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        public ClassAcademic()
        {
            InitializeComponent();
            DbContext = new SchoolManagementEntities1();
        }

        private void ClassAcademic_Load(object sender, EventArgs e)
        {

            GetdataFromDatabase();
            LoadDataIntoComboBox();
        }

        private void GetdataFromDatabase()
        {
            var schoolid = 2008;
            DataTable dt = new DataTable();

            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = new StringBuilder($@"select cls.Id,cls.SchoolId,cls.ClassId,cls.SectionId,cls.StreamId,cla.ClassName,scs.SectionName,streamed.StreamName from Class_Section cls
                left join class cla on cla.ClassId=cls.ClassId left join Section scs on scs.SectionId=cls.SectionId left join streams streamed on streamed.stramId=cls.StreamId 
                where cls.IsActive=1 and cls.SchoolId={schoolid}");
                allData = connection.Query<ClassViewModel>(sql.ToString()).ToList();

                ClassDataGridView.Rows.Clear();

                foreach (var item in allData)
                {
                    ClassDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassId, item.SectionId, item.StreamId, item.ClassName, item.SectionName, item.StreamName);
                }

                ClassDataGridView.AutoGenerateColumns = false;

                TotalCount.Text = "Total Count: " + ClassDataGridView.Rows.Count.ToString();

                UpdateDataGridView();
            }

        }

        private void LoadDataIntoComboBox()
        {
            var selectClass = DbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            ClassName.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                ClassName.Items.Add(item);
            }


        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                if (Submit.Text == "Submit")
                {
                    if (!string.IsNullOrEmpty(ClassName.Text))
                    {
                        Random random = new Random();
                        List<string> sectionIds = new List<string>();
                        List<Section> sections = new List<Section>();
                        List<Class_Section> classSections = new List<Class_Section>();
                        Stream streams = new Stream();
                        if (!string.IsNullOrEmpty(section_streamType.Text) && flowLayoutPanel.Controls.Count > 0)
                        {
                            streams.StreamName = section_streamType.Text;
                            streams.SchoolId = 2008;
                            streams.ClassId = selectedClass.Value;
                            streams.IsActive = true;
                            streams.Isdelete = false;
                            streams.DateAdded = DateTime.Now;
                            streams.DateModified = DateTime.Now;
                            DbContext.Streams.Add(streams);
                            DbContext.SaveChanges();
                        }
                        foreach (Control control in flowLayoutPanel.Controls)
                        {
                            if (control is FlowLayoutPanel tagPanel)
                            {
                                Section sectioned = new Section();
                                foreach (Control innerControl in tagPanel.Controls)
                                {

                                    if (innerControl is System.Windows.Forms.Label tagLabel)
                                    {
                                        SectionId = tagLabel.Text + random.Next(0, 1000000) + random.Next(0, 2000000);

                                        sectioned.SectionId = SectionId;
                                        sectioned.ClassId = selectedClass.Value;
                                        sectioned.SectionName = tagLabel.Text;
                                        sectioned.TypeStatus = true;
                                        sectioned.IsActive = true;
                                        sectioned.IsDelete = false;
                                        sectioned.DateAdded = DateTime.Now;
                                        sectioned.DateModified = DateTime.Now;
                                        sectioned.SchoolId = 2008;
                                        sections.Add(sectioned);
                                        sectionIds.Add(SectionId);

                                        Class_Section newClassSection = new Class_Section()
                                        {
                                            SchoolId = 2008,
                                            ClassId = selectedClass.Value,
                                            ClassName = ClassName.Text,
                                            SectionName = tagLabel.Text,
                                            SectionId = SectionId,
                                            StreamId = streams.StramId,
                                            IsActive = true,
                                            IsDelete = false,
                                            DateAdded = DateTime.Now,
                                            DateModified = DateTime.Now,
                                        };
                                        classSections.Add(newClassSection);

                                    }

                                }

                            }
                        }

                        if (sections.Count > 0 && sections != null)
                        {
                            DbContext.Sections.AddRange(sections);
                            DbContext.SaveChanges();
                            DbContext.Class_Section.AddRange(classSections);
                            DbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClassName.SelectedIndex = -1;
                            section_streamType.Text = "";
                            flowLayoutPanel.Controls.Clear();
                            flowLayoutPanel.Visible = false;

                            GetdataFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Please enter the section", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the class", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (Submit.Text == "Update")
                {
                    var sectionsed = new Class_Section();
                    if (!string.IsNullOrEmpty(section_streamType.Text))
                    {
                        int str_id = 0;
                        int schoolid = 2008;
                        var sections = section_streamType.Text.Trim();
                        var streamed = DbContext.Streams.FirstOrDefault(x => x.SchoolId == schoolid && x.ClassId == selectedClass.Value && x.StreamName.Trim() == sections);
                        if (streamed != null)
                        {
                            str_id = streamed.StramId;
                        }
                        sectionsed = DbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == schoolid && x.ClassId == selectedClass.Value && x.StreamId == str_id);
                    }
                    else
                    {
                        sectionsed = DbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == 2008 && x.ClassId == selectedClass.Value);

                    }
                    if (sectionsed == null)
                    {
                        UpdateSection();

                        GetdataFromDatabase();
                    }
                    else
                    {
                        MessageBox.Show("Already record added", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateSection()
        {
            try
            {
                if (ClassDataGridView.SelectedRows.Count == 0)
                {
                    var streamToUpdate = DbContext.Streams.FirstOrDefault(s => s.StramId == StreamId);
                    var sectionToUpdate = DbContext.Sections.FirstOrDefault(s => s.SectionId == SectionId);
                    var classSectionToUpdate = DbContext.Class_Section.FirstOrDefault(cs => cs.SectionId == SectionId);

                    SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                    if (selectedClass != null)
                    {
                        var classdatas = DbContext.Sections.FirstOrDefault(x => (x.ClassId == selectedClass.Value && x.SectionName == ClassSection.Text));

                        if (sectionToUpdate != null && classSectionToUpdate != null || sectionToUpdate != null && classSectionToUpdate != null && streamToUpdate != null)
                        {

                            classSectionToUpdate.SectionName = ClassSection.Text;
                            classSectionToUpdate.ClassId = selectedClass.Value;
                            classSectionToUpdate.ClassName = ClassName.Text;
                            classSectionToUpdate.DateModified = DateTime.Now;
                            sectionToUpdate.SectionName = ClassSection.Text;
                            sectionToUpdate.ClassId = selectedClass.Value;
                            sectionToUpdate.DateModified = DateTime.Now;

                            if (streamToUpdate != null)
                            {
                                streamToUpdate.StreamName = section_streamType.Text;
                                streamToUpdate.ClassId = selectedClass.Value;
                                streamToUpdate.DateModified = DateTime.Now;
                            }

                            DbContext.SaveChanges();
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClassName.SelectedIndex = -1;
                            ClassSection.Text = "";
                            section_streamType.Text = "";
                            Submit.Text = "Submit";
                        }
                        else
                        {
                            MessageBox.Show("Record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
     
        private void ClassDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassDataGridView.Columns.Count && ClassDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                SectionId = ClassDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value?.ToString();
                StreamId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["StreamIdColumn"].Value);
                if (!string.IsNullOrEmpty(SectionId) || StreamId != null)
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (SectionId != null || StreamId != null)
                        {
                            var stream = DbContext.Streams.FirstOrDefault(s => s.StramId == StreamId);
                            var section = DbContext.Sections.FirstOrDefault(s => s.SectionId == SectionId);
                            var classSection = DbContext.Class_Section.FirstOrDefault(cs => cs.SectionId == SectionId);

                            DbContext.Class_Section.Remove(classSection);
                            DbContext.Sections.Remove(section);
                            if (StreamId != null && StreamId != 0)
                            {
                                DbContext.Streams.Remove(stream);
                            }
                            DbContext.SaveChanges();

                            GetdataFromDatabase();

                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Record not found or failed to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Section Id is null or Stream Id is null", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassDataGridView.Columns.Count && ClassDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, ClassSectionEdit, ClassStreamNameEdit;
                SectionId = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value);
                StreamId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["StreamIdColumn"].Value);
                ClassNameEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["ClassNameColumn"].Value);
                ClassStreamNameEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["StreamNameColumn"].Value);
                ClassSectionEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["SectionNameColumn"].Value);

                ClassName.Text = ClassNameEdit;
                ClassSection.Text = ClassSectionEdit;
                section_streamType.Text = ClassStreamNameEdit;
                SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                if (selectedClass.Value == 11 || selectedClass.Value == 12)
                {
                    section_streamType.Visible = true;
                    kryptonLabel3.Visible = true;
                    this.Submit.Location = new System.Drawing.Point(6, 55);
                }
                else
                {
                    section_streamType.Visible = false;
                    kryptonLabel3.Visible = false;
                    this.Submit.Location = new System.Drawing.Point(6, 40);
                }

                this.Controls.Remove(flowLayoutPanel);
                Submit.Text = "Update";
            }
        }

        private void ClassName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
            //if (Submit.Text == "Update")
            //{
            //    this.Controls.Clear();
            //    this.InitializeComponent();
            //    this.Refresh(); 
            //    GetdataFromDatabase();
            //    Submit.Text = "Submit";
            //    return;
            //}
            if (selectedClass.Value == 11 || selectedClass.Value == 12)
            {
                StreamId = 1;
                section_streamType.Visible = true;
                kryptonLabel3.Visible = true;
                this.Submit.Location = new System.Drawing.Point(6, 55);
            }
            else
            {
                StreamId = 0;
                section_streamType.Text = "";
                section_streamType.Visible = false;
                kryptonLabel3.Visible = false;
                this.Submit.Location = new System.Drawing.Point(6, 40);
            }
        }



        private void AddTag(string tag)
        {
            if (!string.IsNullOrWhiteSpace(tag))
            {
                System.Windows.Forms.FlowLayoutPanel tagPanel = new System.Windows.Forms.FlowLayoutPanel();
                tagPanel.AutoSize = true;
                tagPanel.FlowDirection = FlowDirection.LeftToRight;

                System.Windows.Forms.Label tagLabel = new System.Windows.Forms.Label();
                tagLabel.Text = tag;
                tagLabel.AutoSize = true;
                tagLabel.Padding = new Padding(4);
                tagLabel.Margin = new Padding(0);
                tagLabel.BackColor = System.Drawing.Color.Aqua;
                tagPanel.Controls.Add(tagLabel);

                System.Windows.Forms.Button closeButton = new System.Windows.Forms.Button();
                closeButton.Text = "x";
                closeButton.Width = 20;
                closeButton.Height = 24;
                closeButton.Margin = new Padding(0);
                closeButton.FlatStyle = FlatStyle.Flat;
                closeButton.FlatAppearance.BorderSize = 0;
                closeButton.ForeColor = Color.Black;
                closeButton.BackColor = System.Drawing.Color.Aqua;
                closeButton.Click += (sender, e) =>
                {
                    widthtag = tagPanel.Width;
                    closepanelwidth(widthtag, tagPanel);

                };
                tagPanel.Controls.Add(closeButton);
                flowLayoutPanel.Controls.Add(tagPanel);
                widthtag = tagPanel.Width;

            }
        }

        public void closepanelwidth(int sizewidth, FlowLayoutPanel tagpanel)
        {
            flowLayoutPanel.Controls.Remove(tagpanel);
            widthtag = tagpanel.Width;
            if (widthtag >= flowLayoutPanel.Width)
            {
                flowLayoutPanel.Height -= 26;
            }
            if (flowLayoutPanel.Controls.Count == 0)
            {
                flowLayoutPanel.Visible = false;
            }
        }

        private void ClassSection_KeyUp(object sender, KeyEventArgs e)
        {
            SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
            int str_id = 0;
            var schoolid = 2008;

            if (selectedClass != null && !string.IsNullOrEmpty(ClassSection.Text))
            {
                if (Submit.Text != "Update")
                {
                    //char space = (char)32;
                    if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                    {

                        var section = new Class_Section();
                        if (!string.IsNullOrEmpty(section_streamType.Text))
                        {
                            var sections = section_streamType.Text.Trim();
                            var streamed = DbContext.Streams.FirstOrDefault(x => x.SchoolId == schoolid && x.ClassId == selectedClass.Value && x.StreamName.Trim() == sections);
                            section = DbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == schoolid && x.ClassId == selectedClass.Value && x.StreamId == str_id);

                            if (streamed != null)
                            {
                                str_id = streamed.StramId;
                            }
                        }
                        else
                        {
                            section = DbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == schoolid && x.ClassId == selectedClass.Value);
                        }


                        if (section == null)
                        {
                            AddTag(ClassSection.Text.Trim());

                            e.Handled = true;

                            if (flowLayoutPanel.Controls.Count > 0)
                            {
                                flowLayoutPanel.Visible = true;
                                if (widthtag >= flowLayoutPanel.Width)
                                {
                                    flowLayoutPanel.Height += 26;
                                }
                            }
                            else
                            {
                                flowLayoutPanel.Visible = false;
                            }

                            ClassSection.Clear();
                        }
                        else
                        {
                            ClassSection.Text = "";
                            MessageBox.Show("Already Section Exists!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter the class and section!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDataGridView()
        {
            ClassDataGridView.Rows.Clear();

            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in currentPageData)
            {
                ClassDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassId, item.SectionId, item.StreamId, item.ClassName, item.SectionName, item.StreamName);
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


        private void UpdateDataGridView(List<ClassViewModel> data = null)
        {
            ClassDataGridView.Rows.Clear();

            var sourceData = data ?? allData.Skip(currentPage * pageSize).Take(pageSize).ToList();

            foreach (var item in sourceData)
            {
                ClassDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassId, item.SectionId, item.StreamId, item.ClassName, item.SectionName, item.StreamName);
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
            if (Search.Text == "Enter Class Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Class Name";
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text) || Search.Text == "Enter Class Name")
            {
                UpdateDataGridView();
            }
            else
            {
                var filteredData = allData.Where(x => x.ClassName.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                UpdateDataGridView(filteredData);
            }

            ClassDataGridView.Refresh();
        }
    }
}
