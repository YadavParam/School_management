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
using System.Xml;
using SchoolManagement.HelperClasses;
using static SchoolManagement.Helper.Helper;
using SchoolManagement.Helper;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using MaterialSkin.Controls;
using System.IO;

namespace SchoolManagement
{
    public partial class SchoolSatff : Form
    {
        private string selectedImagePath;
        Form form;
        SchoolManagementEntities1 dbContext = new SchoolManagementEntities1();
        validations validates = new validations();
        private int staffIdToUpdate;
        public SchoolSatff()
        {
            InitializeComponent();
        }

        private void SchoolSatff_Load(object sender, EventArgs e)
        {
            SelectStaff.DisplayMember = "Key";
            SelectStaff.ValueMember = "Value";
            SelectStaff.DataSource = Enum.GetValues(typeof(SchoolStaffs));

            Gender.DisplayMember = "Key";
            Gender.ValueMember = "Value";
            Gender.DataSource = Enum.GetValues(typeof(SchoolStaffGender));

            int Id = EditStaffViewModel.Id;
            if (Id != null && Id != 0)
            {
                getstaffdata(Id);
            }

            SelectClassCustomCheckBox();
            SelectSubjectCustomCheckBox();
        }

        private void SelectClassCustomCheckBox()
        {
            var itemdata = dbContext.Classes.Where(x => x.Isdelete != true).AsNoTracking().ToList();

            MaterialCheckbox selectAllCheckbox = new MaterialCheckbox();
            selectAllCheckbox.Text = "Select All";
            selectAllCheckbox.AutoSize = true;
            selectAllCheckbox.Click += materialCheckedListBoxClass_Click;
            materialCheckedListBoxClass.Items.Add(selectAllCheckbox);

            foreach (var item in itemdata)
            {
                MaterialCheckbox csx = new MaterialCheckbox();
                csx.Text = item.ClassName;
                csx.Tag = Convert.ToString(item.ClassId);
                materialCheckedListBoxClass.Items.Add(csx);
            }
            materialCheckedListBoxClass.Visible = false;
        }

        private void TeacherSelectClass_Click(object sender, EventArgs e)
        {
            materialCheckedListBoxClass.Visible = !materialCheckedListBoxClass.Visible;
        }

        private void materialCheckedListBoxClass_Click(object sender, EventArgs e)
        {
            bool isChecked = ((MaterialCheckbox)sender).Checked;

            for (int i = 1; i < materialCheckedListBoxClass.Items.Count; i++)
            {
                if (materialCheckedListBoxClass.Items[i] is MaterialCheckbox checkbox)
                {
                    checkbox.Checked = isChecked;
                }
            }
        }

        private void SelectSubjectCustomCheckBox()
        {
            var itemdata = dbContext.Subjects.Where(x => x.IsDelete != true).AsNoTracking().ToList();

            MaterialCheckbox selectAllCheckbox = new MaterialCheckbox();
            selectAllCheckbox.Text = "Select All";
            selectAllCheckbox.AutoSize = true;
            selectAllCheckbox.Click += materialCheckedListBoxSubject_Click;
            materialCheckedListBoxSubject.Items.Add(selectAllCheckbox);

            foreach (var item in itemdata)
            {
                MaterialCheckbox csx = new MaterialCheckbox();
                csx.Text = item.SubjectName;
                csx.Tag = Convert.ToString(item.SubjectId);
                materialCheckedListBoxSubject.Items.Add(csx);
            }
            materialCheckedListBoxSubject.Visible = false;
        }

        private void TeacherSelectSubject_Click(object sender, EventArgs e)
        {
            materialCheckedListBoxSubject.Visible = !materialCheckedListBoxSubject.Visible;
        }

        private void materialCheckedListBoxSubject_Click(object sender, EventArgs e)
        {
            bool isChecked = ((MaterialCheckbox)sender).Checked;

            for (int i = 1; i < materialCheckedListBoxSubject.Items.Count; i++)
            {
                if (materialCheckedListBoxSubject.Items[i] is MaterialCheckbox checkbox)
                {
                    checkbox.Checked = isChecked;
                }
            }
        }

        private void SelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectStaff.SelectedIndex == 0)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 1)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 2)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 3)
            {
                SelectStaffTeacherPanel.Visible = false;
                SelectStaffTeacherPanel.Visible = true;
            }
            else if (SelectStaff.SelectedIndex == 4)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 5)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
        }

        private void TeacherSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TeacherSubmit.Text == "Submit")
                {
                    var schooluser = Convert.ToInt32(SelectStaff.SelectedValue);
                    var usertype = 0;

                    if (schooluser == (int)SchoolStaffs.Teacher)
                    {
                        usertype = 2;
                    }
                    else if (schooluser == (int)SchoolStaffs.Accountant_Manager || schooluser == (int)SchoolStaffs.Receptionist)
                    {
                        usertype = 1;
                    }
                    else if (schooluser == (int)SchoolStaffs.Librarian)
                    {
                        usertype = 5;
                    }
                   
                    Random randomno = new Random();
                    if (!dbContext.Users.Any(x => x.Email == Email.Text && x.PhoneNumber == PhoneNumber.Text && x.IsActive == true))
                    {
                        if (FullName.Text.Trim().Length > 2 && PhoneNumber.Text.Trim().Length == 10)
                        {
                            var unique = FullName.Text.Substring(0, 2) + "" + PhoneNumber.Text.Substring(0, 4) + "" + randomno.Next(0, 1000000000) + randomno.Next(0, 800000000);
                            string[] names = FullName.Text.Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                            string firstName = names.Length > 0 ? names[0] : "";
                            string lastName = names.Length > 1 ? names[1] : "";

                            var newUser = new User
                            {
                                UserName = firstName + " " + lastName,
                                Email = Email.Text,
                                PhoneNumber = PhoneNumber.Text,
                                SchoolUser = schooluser,//Admin user 
                                //MenuRights = Globals.DefaultMenuRights,
                                UserType = usertype,
                                IsActive = true,
                                IsDelete = false,
                                DateAdded = DateTime.Now,
                                DateModified = DateTime.Now,
                                Password = unique,
                            };

                            List<int> selectedClassIds = new List<int>();
                            List<int> selectedSubjectIds = new List<int>();

                            if (materialCheckedListBoxClass.Items.Count > 1)
                            {
                                for (int i = 1; i < materialCheckedListBoxClass.Items.Count; i++)
                                {
                                    if (materialCheckedListBoxClass.Items[i] is MaterialCheckbox checkbox && checkbox.Checked)
                                    {
                                        selectedClassIds.Add(Convert.ToInt32(checkbox.Tag));
                                    }
                                }
                            }

                            if (materialCheckedListBoxSubject.Items.Count > 1)
                            {
                                for (int i = 1; i < materialCheckedListBoxSubject.Items.Count; i++)
                                {
                                    if (materialCheckedListBoxSubject.Items[i] is MaterialCheckbox checkbox && checkbox.Checked)
                                    {
                                        selectedSubjectIds.Add(Convert.ToInt32(checkbox.Tag));
                                    }
                                }
                            }

                            if (selectedClassIds != null && !string.IsNullOrEmpty(selectedImagePath))
                            {
                                dbContext.Users.Add(newUser);
                                dbContext.SaveChanges();
                                foreach (var classId in selectedClassIds)
                                {
                                    foreach (var subjectId in selectedSubjectIds)
                                    {
                                        SchoolStaff schoolStaff = new SchoolStaff()
                                        {
                                            UserId = newUser.UserId,
                                            FirstName = firstName,
                                            LastName = lastName,
                                            Gender = Gender.Text,
                                            Salary = Salary.Text,
                                            Experience = Experience.Text,
                                            Address = Address.Text,
                                            BankName = BankName.Text,
                                            AccountNumber = AccountNumber.Text,
                                            IFSCCode = IFSCCode.Text,
                                            BranchName = BranchName.Text,
                                            ClassId = classId,
                                            SubjectId = subjectId,
                                            Designation = Designation.Text,
                                            JoiningDate = Convert.ToDateTime(JoiningDate.Text),
                                            Image = File.ReadAllBytes(selectedImagePath),
                                            IsActive = true,
                                            IsDelete = false,
                                            DateAdded = DateTime.Now,
                                            DateModified = DateTime.Now,
                                        };
                                        var messages_schoolStaff = validates.ValidateSchoolStaff(schoolStaff, newUser);
                                        if (messages_schoolStaff.Status == true)
                                        {
                                            MessageBox.Show(messages_schoolStaff.Message);
                                        }
                                        else
                                        {
                                            dbContext.SchoolStaffs.Add(schoolStaff);
                                        }
                                    }
                                }
                                //dbContext.Users.Add(newUser);
                                dbContext.SaveChanges();
                                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClearFormFields();
                            }
                            else
                            {
                                MessageBox.Show("Please select a class and subject and a staff picture.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Name should be more than two characters and Phone Number should be exact 10 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            FullName.Focus();
                            PhoneNumber.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User with the same Email, Phone Number, and active status already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (TeacherSubmit.Text == "Update")
                {
                    UpdateSection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getstaffdata(int Id)
        {
            try
            {
                var getstaffdetails = dbContext.SchoolStaffs.AsNoTracking().FirstOrDefault(x => x.Id == Id);
                if (getstaffdetails != null)
                {
                    var UserGetstaffdetails = dbContext.Users.FirstOrDefault(x => x.UserId == getstaffdetails.UserId);
                    if (UserGetstaffdetails != null)
                    {
                        staffIdToUpdate = getstaffdetails.Id;
                        IdHiddenCol.Text = getstaffdetails.Id.ToString();
                        FullName.Text = UserGetstaffdetails.UserName;
                        Email.Text = UserGetstaffdetails.Email;
                        PhoneNumber.Text = UserGetstaffdetails.PhoneNumber;
                        FullName.Text = $"{getstaffdetails.FirstName} {getstaffdetails.LastName}";
                        Gender.Text = getstaffdetails.Gender;
                        Salary.Text = getstaffdetails.Salary;
                        Experience.Text = getstaffdetails.Experience;
                        Address.Text = getstaffdetails.Address;
                        BankName.Text = getstaffdetails.BankName;
                        AccountNumber.Text = getstaffdetails.AccountNumber;
                        IFSCCode.Text = getstaffdetails.IFSCCode;
                        BranchName.Text = getstaffdetails.BranchName;
                        JoiningDate.Text = getstaffdetails.JoiningDate?.ToString("dd-MM-yyyy");
                        Designation.Text = getstaffdetails.Designation;
                        TeacherSubmit.Text = "Update";
                        SelectStaff.SelectedIndex = 3;

                        if (getstaffdetails.ClassId.HasValue)
                        {
                            int classIdToSelect = getstaffdetails.ClassId.Value;
                            SetCheckedState(materialCheckedListBoxClass, classIdToSelect);
                            materialCheckedListBoxClass.Refresh();
                        }

                        if (getstaffdetails.SubjectId.HasValue)
                        {
                            int subjectIdToSelect = getstaffdetails.SubjectId.Value;
                            SetCheckedState(materialCheckedListBoxSubject, subjectIdToSelect);
                        }


                        //using (var ms = new MemoryStream(getstaffdetails.Image))
                        //{
                        //    StaffPicture.Image = Image.FromStream(ms);
                        //}

                    }
                    else
                    {
                        MessageBox.Show("User details not found for the staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Staff record not found.");
                    return;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void SetCheckedState(MaterialCheckedListBox checkedListBox, int idToSelect)
        {
            foreach (var item in checkedListBox.Items)
            {
                if (item is MaterialCheckbox checkbox && checkbox.Tag != null && Convert.ToInt32(checkbox.Tag) == idToSelect)
                {
                    checkbox.Checked = true;
                    break;
                }
            }
        }

        private void UpdateSection()
        {
            try
            {
                var setstaffdetails = dbContext.SchoolStaffs.AsNoTracking().FirstOrDefault(x => x.Id == staffIdToUpdate);
                if (setstaffdetails != null)
                {
                    var UserSetstaffdetails = dbContext.Users.AsNoTracking().FirstOrDefault(x => x.UserId == setstaffdetails.UserId);
                    if (UserSetstaffdetails != null)
                    {
                        string[] names = FullName.Text.Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                        string firstName = names.Length > 0 ? names[0] : "";
                        string lastName = names.Length > 1 ? names[1] : "";
                        //SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)TeacherSelectClass.SelectedItem;
                        //SubjectClassDropdlist subjectClass = (SubjectClassDropdlist)TeacherSelectSubject.SelectedItem;


                        UserSetstaffdetails.UserName = FullName.Text;
                        UserSetstaffdetails.Email = Email.Text;
                        UserSetstaffdetails.PhoneNumber = PhoneNumber.Text;
                        setstaffdetails.FirstName = firstName;
                        setstaffdetails.LastName = lastName;
                        setstaffdetails.Gender = Gender.Text;
                        setstaffdetails.Salary = Salary.Text;
                        setstaffdetails.Experience = Experience.Text;
                        setstaffdetails.Address = Address.Text;
                        setstaffdetails.BankName = BankName.Text;
                        setstaffdetails.AccountNumber = AccountNumber.Text;
                        setstaffdetails.IFSCCode = IFSCCode.Text;
                        setstaffdetails.BranchName = BranchName.Text;
                        //setstaffdetails.ClassId = selectedClass.Value;
                        //setstaffdetails.SubjectId = subjectClass.Value;
                        setstaffdetails.Designation = Designation.Text;
                        var messages_schoolStaff = validates.ValidateSchoolStaff(setstaffdetails, UserSetstaffdetails);
                        if (messages_schoolStaff.Status == true)
                        {
                            MessageBox.Show(messages_schoolStaff.Message);
                        }
                        else
                        {
                            setstaffdetails.DateModified = DateTime.Now;
                            UserSetstaffdetails.DateModified = DateTime.Now;
                            dbContext.Entry(UserSetstaffdetails).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            dbContext.Entry(setstaffdetails).State = EntityState.Modified;
                            dbContext.SaveChanges();

                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClearFormFields();
                            TeacherSubmit.Text = "Submit";
                            this.Hide();
                            form = new StaffDetails();
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User details not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Staff record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            Gender.SelectedIndex = -1;
            FullName.Text = string.Empty;
            Email.Text = string.Empty;
            PhoneNumber.Text = string.Empty;
            Salary.Text = string.Empty;
            Experience.Text = string.Empty;
            Address.Text = string.Empty;
            BankName.Text = string.Empty;
            AccountNumber.Text = string.Empty;
            IFSCCode.Text = string.Empty;
            BranchName.Text = string.Empty;
            foreach (var item in materialCheckedListBoxClass.Items)
            {
                item.Checked = false;
            }
            foreach (var item in materialCheckedListBoxSubject.Items)
            {
                item.Checked = false;
            }
            if (StaffPicture.Image != null)
            {
                StaffPicture.Image.Dispose(); 
                StaffPicture.Image = null;    
            }
            Designation.Text = string.Empty;
            FullName.Focus();
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)| *.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                StaffPicture.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}