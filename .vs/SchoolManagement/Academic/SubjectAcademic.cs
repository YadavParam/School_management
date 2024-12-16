using DocumentFormat.OpenXml.Wordprocessing;
using IronXL.Printing;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{
    public partial class SubjectAcademic : Form
    {
        private List<SubjectViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        private int SubjectId;
        SchoolManagementEntities1 dbContext = new SchoolManagementEntities1();
        validations validates = new validations();
        public SubjectAcademic()
        {
            InitializeComponent();
        }

        private void SubjectAcademic_Load(object sender, EventArgs e)
        {
            GetdataFromDatabase(1, pageSize);
            LoadDataIntoComboBox();
            UpdateDataGridView();
        }

        private void GetdataFromDatabase(int pageNumber, int pageSize)
        {
            var data = dbContext.Subjects.Where(m => m.IsDelete != true).OrderBy(m => m.SubjectId)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize)
            .Select(m => new SubjectViewModel
            {
               SubjectId = m.SubjectId,
               ClassName = m.ClassName,
               SubjectName = m.SubjectName

            }).ToList();

            allData = data;
            SubjectDataGridView.AutoGenerateColumns = false;

            totalRecords = dbContext.Subjects.Where(m => m.IsDelete != true).Count();

            TotalCount.Text = $"Total Count: {totalRecords}";

            UpdateDataGridView();
        }

        private void LoadDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            SelectClasses.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                SelectClasses.Items.Add(item);
            }
        }

        private void SubjectSubmit_Click(object sender, EventArgs e)
        {
            if (SubjectSubmit.Text == "Submit")
            {
                try
                {
                    if (!string.IsNullOrEmpty(SelectClasses.Text))
                    {
                        if (string.IsNullOrEmpty(SubjectName.Text))
                        {
                            MessageBox.Show("Please enter the subject name");
                            return;
                        }
                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)SelectClasses.SelectedItem;

                        Subject newSubject = new Subject()
                        {
                            ClassId = selectedClass.Value,
                            SchoolId = GlobalAccount.SchoolId,
                            ClassName = SelectClasses.Text,
                            SubjectName = SubjectName.Text,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };

                        dbContext.Subjects.Add(newSubject);
                        dbContext.SaveChanges();
                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetdataFromDatabase(1, pageSize);
                        SelectClasses.SelectedIndex = -1;
                        SubjectName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Please select the class");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (SubjectSubmit.Text == "Update")
            {
                UpdateSection();
            }
        }

        private void UpdateSection()
        {
            try
            {
                if (SubjectDataGridView.SelectedRows.Count == 0)
                {
                    var subjectToUpdate = dbContext.Subjects.Find(SubjectId);

                    if (subjectToUpdate != null)
                    {
                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)SelectClasses.SelectedItem;

                        subjectToUpdate.ClassId = selectedClass.Value;
                        subjectToUpdate.ClassName = SelectClasses.Text;
                        subjectToUpdate.SubjectName = SubjectName.Text;
                        var messages_subject = validates.ValidateSubject(subjectToUpdate);
                        if (messages_subject.Status == true)
                        {
                            MessageBox.Show(messages_subject.Message);
                        }
                        else
                        {
                            subjectToUpdate.DateModified = DateTime.Now;
                            dbContext.SaveChanges();
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SelectClasses.SelectedIndex = -1;
                            SubjectName.Text = "";
                            SubjectSubmit.Text = "Submit";
                            GetdataFromDatabase(1, pageSize);
                        }
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
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SubjectDataGridView.Columns.Count && SubjectDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, SubjectNameEdit;
                SubjectId = Convert.ToInt32(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectIdColumn"].Value);
                ClassNameEdit = Convert.ToString(SubjectDataGridView.Rows[e.RowIndex].Cells["SelectClassColumn"].Value);
                SubjectNameEdit = Convert.ToString(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectNameColumn"].Value);
                SelectClasses.Text = ClassNameEdit;
                SubjectName.Text = SubjectNameEdit;

                SubjectSubmit.Text = "Update";
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SubjectDataGridView.Columns.Count && SubjectDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                SubjectId = Convert.ToInt32(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = dbContext.Subjects.Find(SubjectId);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        dbContext.SaveChanges();

                        GetdataFromDatabase(1, pageSize);

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
            SubjectDataGridView.DataSource = currentPageData;

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
            if (Search.Text == "Enter Subject Name")
            {
                Search.Text = string.Empty;
            }
        }

        private void Search_Leave(object sender, EventArgs e)
        {
            if (Search.Text == "")
            {
                Search.Text = "Enter Subject Name";

            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (Search.Text == "" || Search.Text == "Enter Subject Name")
            {
                SubjectDataGridView.DataSource = allData;
            }
            else
            {
                var filteredData = allData.Where(x => x.SubjectName.IndexOf(Search.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                SubjectDataGridView.DataSource = filteredData;
            }

            SubjectDataGridView.Refresh();
        }
    }
}
