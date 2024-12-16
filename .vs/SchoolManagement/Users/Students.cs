using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using SchoolManagement.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class Students : Form
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Helper.Helper helper = new Helper.Helper();
        validations validates = new validations();
        private int hiddenIdColumn;
        private int studentTypeValue;
        private string selectedImagePath;
        Form form;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

            ClassDataIntoComboBox();
            SectionDataIntoComboBox(GetSelectedClassId());

            form = new Students();
            // Student Type
            StudentType.DisplayMember = "Key";
            StudentType.ValueMember = "Value";
            StudentType.DataSource = Enum.GetValues(typeof(StudentType));
            // Student Blood Group
            BloodGroup.DisplayMember = "Key";
            BloodGroup.ValueMember = "Value";
            BloodGroup.DataSource = Enum.GetValues(typeof(BloodGroups));
            // Student Gender
            Gender.DisplayMember = "Key";
            Gender.ValueMember = "Value";
            Gender.DataSource = Enum.GetValues(typeof(Gender));

            int Id = EditStaffViewModel.Id;
            int schoolId = EditStaffViewModel.SchoolId;
            string studentId = EditStaffViewModel.StudentId;
            if (Id != null && Id != 0 && schoolId != 0 && studentId != null)
            {
                getstudentdata(Id, schoolId, studentId);
            }
        }

        private void ClassDataIntoComboBox()
        {
            var selectClass = Db.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            Class.Items.Clear();

            Class.Text = "Please select a value";
            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                Class.Items.Add(item);
            }

            int classes = classperiods.Classid;
            var selectedItem = Class.Items.Cast<SubjectClassDropdlist>().FirstOrDefault(i => i.Value == classes);
            if (selectedItem != null)
            {
                Class.SelectedItem = selectedItem;
            }
        }

        private void SectionDataIntoComboBox(int classId)
        {
            var selectClass_Section = Db.Class_Section.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            Section.Items.Clear();

            foreach (var select in selectClass_Section)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.SectionName,
                    Values = select.SectionId,
                };

                Section.Items.Add(item);
            }
            var sectionIds = classperiods.SectionId;
            var selectedItem = Section.Items.Cast<SubjectClassDropdlist>().FirstOrDefault(i => i.Values == sectionIds);

            if (selectedItem != null)
            {
                Section.SelectedItem = selectedItem;
            }
        }

        private int GetSelectedClassId()
        {
            var selectedItem = (SubjectClassDropdlist)Class.SelectedItem;
            return selectedItem != null ? selectedItem.Value : 0;
        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = GetSelectedClassId();

            SectionDataIntoComboBox(selectedClassId);
        }

        //single student register
        private void Student_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (Student_Register.Text == "Submit")
                {
                    SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)Class.SelectedItem;
                    SubjectClassDropdlist selectedSection = (SubjectClassDropdlist)Section.SelectedItem;

                    Random r = new Random();
                    var password = Name.Text.Substring(0, 2) + Phone.Text.Substring(0, 4) + r.Next(0, 1000000000);
                    var studentid = Name.Text.Substring(0, 2) + r.Next(0, 1000000000) + r.Next(0, 100000000);

                    int studentType = 0;
                    if (!string.IsNullOrEmpty(StudentType.Text))
                    {
                        if (StudentType.Text == "Deskcolor")
                        {
                            studentType = 1;
                        }
                        else if (StudentType.Text == "Hosteler")
                        {
                            studentType = 2;
                        }
                    }
                    if (StudentType == null)
                    {
                        MessageBox.Show("Please Select Student Type!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    var students = new Student
                    {
                        StudentId = studentid,
                        Name = Name.Text,
                        Email = Email.Text,
                        PhoneNumber = Phone.Text,
                        StudentType = studentType,
                        ParentId = GlobalAccount.ParentId,
                        SchoolId = Convert.ToInt32(GlobalAccount.SchoolId),
                        ClassId = selectedClass.Value,
                        SectionId = selectedSection.Values,
                        Birthday = Convert.ToDateTime(Birthday.Text),
                        Gender = Gender.Text,
                        BloodGroup = BloodGroup.Text,
                        Address = Address.Text,
                        Image = File.ReadAllBytes(selectedImagePath),
                        IsActive = true,
                        Isdelete = false,
                        DateAdded = DateTime.Now,
                        DateModified = DateTime.Now,
                        Password = password,
                    };
                    var messages_students = validates.ValidateStudents(students);
                    if (messages_students.Status != false)
                    {
                        MessageBox.Show(messages_students.Message);
                        return;
                    }
                    else
                    {
                        var schoolsemailcheck = Db.Students.AsNoTracking().FirstOrDefault(x => x.Email.Trim() == Email.Text.Trim() || x.PhoneNumber == Phone.Text)?.Email;
                        if ((string.IsNullOrEmpty(schoolsemailcheck)))
                        {
                            if (!Db.Parents.Any(x => (x.FathersMailId == ParentAccount.FathersMailId || x.FathersMobileNumber == ParentAccount.FathersMobileNumber || x.MothersMailId == ParentAccount.MothersMailId || x.MothersMobileNumber == ParentAccount.MothersMobileNumber) && x.IsActive == true))
                            {
                                var parents = new Parent
                                {
                                    ParentId = ParentAccount.ParentId,
                                    SchoolId = ParentAccount.SchoolId,
                                    FathersName = ParentAccount.FathersName,
                                    MothersName = ParentAccount.MothersName,
                                    FathersMailId = ParentAccount.FathersMailId,
                                    MothersMailId = ParentAccount.MothersMailId,
                                    FathersMobileNumber = ParentAccount.FathersMobileNumber,
                                    MothersMobileNumber = ParentAccount.MothersMobileNumber,
                                    FathersOccupation = ParentAccount.FathersOccupation,
                                    MothersOccupation = ParentAccount.MothersOccupation,
                                    FathersBloodGroup = ParentAccount.FathersBloodGroup,
                                    MothersBloodGroup = ParentAccount.MothersBloodGroup,
                                    Address = ParentAccount.Address,
                                    Password = ParentAccount.Password,
                                };
                    
                                Db.Parents.Add(parents);
                                Db.SaveChanges();
                            }
                    
                            Db.Students.Add(students);
                            Db.SaveChanges();
                            ClearDataForm();
                            MessageBox.Show("Student is register successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Already student is register", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else if (Student_Register.Text == "Update")
                {
                    UpdateStudent();
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void getstudentdata(int Id, int schoolId, string studentId)
        {
            try
            {
                var getstudentdetails = Db.Students.AsNoTracking().FirstOrDefault(x => x.Id == Id && x.SchoolId == schoolId && x.StudentId == studentId);
                if (getstudentdetails != null)
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        var sql = new StringBuilder($@"select stud.Id,stud.SchoolId,stud.StudentId,stud.Name,stud.Email,stud.PhoneNumber,stud.StudentType,class.ClassName,sec.SectionName,stud.Birthday,stud.Gender,stud.BloodGroup,stud.Address
                            from Student stud left join Class class on stud.ClassId=class.ClassId left join Section sec on stud.SectionId=sec.SectionId 
                            where stud.IsActive=1 and stud.Id={Id} and stud.SchoolId={schoolId} and stud.StudentId='{studentId}'");
                        var properties = connection.Query<StudentViewModel>(sql.ToString()).ToList();

                        foreach (var item in properties)
                        {
                            hiddenIdColumn = item.Id;
                            Name.Text = item.Name;
                            Email.Text = item.Email;
                            Phone.Text = item.PhoneNumber;
                            if (int.TryParse(item.StudentType, out studentTypeValue))
                            {
                                StudentType.Text = studentTypeValue == 1 ? "Deskcolor" :
                                                   studentTypeValue == 2 ? "Hosteler" :
                                                   "Unknown";
                            }
                            Class.Text = item.ClassName;
                            Section.Text = item.SectionName;
                            if (item.Birthday.HasValue)
                            {
                                Birthday.Value = item.Birthday.Value;
                            }
                            Gender.Text = item.Gender;
                            BloodGroup.Text = item.BloodGroup;
                            Address.Text = item.Address;
                            if (getstudentdetails.Image != null && getstudentdetails.Image.Length > 0)
                            {
                                using (var ms = new MemoryStream(getstudentdetails.Image))
                                {
                                    StudentImage.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        Student_Register.Text = "Update";
                    }
                }
                else
                {
                    MessageBox.Show("Student record not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStudent()
        {
            try
            {
                var getStudentDetails = Db.Students.AsNoTracking().FirstOrDefault(x => x.Id == hiddenIdColumn);
                if (getStudentDetails != null)
                {
                    SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)Class.SelectedItem;
                    SubjectClassDropdlist selectedSection = (SubjectClassDropdlist)Section.SelectedItem;

                    getStudentDetails.Name = Name.Text;
                    getStudentDetails.Email = Email.Text;
                    getStudentDetails.PhoneNumber = Phone.Text;
                    int studentType = 0;
                    if (!string.IsNullOrEmpty(StudentType.Text))
                    {
                        if (StudentType.Text == "Deskcolor")
                        {
                            studentType = 1;
                        }
                        else if (StudentType.Text == "Hosteler")
                        {
                            studentType = 2;
                        }
                    }
                    if (StudentType == null)
                    {
                        MessageBox.Show("Please Select Student Type!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    getStudentDetails.StudentType = studentType;
                    getStudentDetails.ClassId = selectedClass.Value;
                    getStudentDetails.SectionId = selectedSection.Values;
                    getStudentDetails.Birthday = Convert.ToDateTime(Birthday.Text);
                    getStudentDetails.Gender = Gender.Text;
                    getStudentDetails.BloodGroup = BloodGroup.Text;
                    getStudentDetails.Address = Address.Text; 
                    if (StudentImage.Image != null)
                    {
                        using (var ms = new MemoryStream())
                        {
                            StudentImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            getStudentDetails.Image = ms.ToArray();
                        }
                    }
                    else
                    {
                        getStudentDetails.Image = null;
                    }

                    var messages_students = validates.ValidateStudents(getStudentDetails);
                    if (messages_students.Status == true)
                    {
                        MessageBox.Show(messages_students.Message);
                    }
                    else
                    {
                        getStudentDetails.DateModified = DateTime.Now;
                        Db.Entry(getStudentDetails).State = EntityState.Modified;
                        Db.SaveChanges();
                        Student_Register.Text = "Submit";
                        ClearDataForm();
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        form = new StudentDetails();
                        form.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                        form.BringToFront();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Student record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDataForm()
        {
            Name.Text = "";
            Email.Text = "";
            Phone.Text = "";
            StudentType.Text = "";
            Class.Text = "";
            Section.Text = "";
            Birthday.Text = "";
            Gender.Text = "";
            BloodGroup.Text = "";
            Address.Text = "";
            if (StudentImage.Image != null)
            {
                StudentImage.Image.Dispose();
                StudentImage.Image = null;
            }
        }

        private void ChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)| *.jpg; *.jpeg; *.gif; *.bmp; *.png;|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                StudentImage.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
