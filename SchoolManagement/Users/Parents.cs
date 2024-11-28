using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Krypton.Toolkit;
using MaterialSkin.Controls;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using SchoolManagement.Users;
using SchoolManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{

    public partial class Parents : Form
    {
        private int hiddenIdColumn;
        validations validates = new validations();
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        //Student_MainForm stmainform = new Student_MainForm();
        Form form;
        //private Student_MainForm mainForm = null;
        //private Students stform = null;
        public static int SetValueForText1 = 1;
        private Student_MainForm _callingForm;
        private Student_MainForm CallingForm;
        public Parents()
        {
            InitializeComponent();
        }

        private void Parents_Load(object sender, EventArgs e)
        {

            //stmainform.Student_Admission.Text = "set by form2";
            //Blood group bind
            FatherBloodGroup.DisplayMember = "Key";
            FatherBloodGroup.ValueMember = "Value";
            FatherBloodGroup.DataSource = Enum.GetValues(typeof(BloodGroups));
            MotherBloodGroup.DisplayMember = "Key";
            MotherBloodGroup.ValueMember = "Value";
            MotherBloodGroup.DataSource = Enum.GetValues(typeof(BloodGroups));

            //Student type bind
            Studentadmission.DisplayMember = "value";
            Studentadmission.ValueMember = "key";
            Studentadmission.DataSource = Enum.GetValues(typeof(StudentAdmission))
                                   .Cast<int>()
                                   .Select(x => new KeyValuePair<int, string>(key: x, value: Enum.GetName(typeof(StudentAdmission), x)))
                                   .ToList();

            int Id = EditStaffViewModel.Id;
            int schoolId = EditStaffViewModel.SchoolId;
            string parentId = EditStaffViewModel.ParentId;
            if (Id != null && Id != 0 && schoolId != 0 && parentId != null)
            {
                getparentdata(Id, schoolId, parentId);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            try
            {
                if (Next.Text == "Next")
                {
                    if (FatherEmail.Text.Length > 2 && MotherEmail.Text.Length > 2)
                    {
                        var parentid = FatherEmail.Text.Substring(0, 2) + r.Next(0, 1000000000) + MotherEmail.Text.Substring(0, 2) + r.Next(0, 100000000);
                        var password = FatherEmail.Text.Substring(0, 2) + r.Next(0, 1000000000) + r.Next(0, 100000000);
                        var accountuser = GlobalAccount.UserId;
                        var accountschool = Convert.ToInt32(GlobalAccount.SchoolId);

                        var parentdetails = new Parent
                        {
                            ParentId = parentid,
                            SchoolId = Convert.ToInt32(GlobalAccount.SchoolId),
                            FathersName = FatherName.Text,
                            MothersName = MotherName.Text,
                            FathersMailId = FatherEmail.Text,
                            MothersMailId = MotherEmail.Text,
                            FathersMobileNumber = FatherMobile.Text,
                            MothersMobileNumber = MotherMobile.Text,
                            FathersOccupation = FatherOccupation.Text,
                            MothersOccupation = MotherOccupation.Text,
                            FathersBloodGroup = FatherBloodGroup.Text,
                            MothersBloodGroup = MotherBloodGroup.Text,
                            Address = Address.Text,
                            Password = password,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };
                        var studentadmission = Studentadmission.SelectedValue.ToString();

                        if (!string.IsNullOrEmpty(studentadmission))
                        {
                            var messages_parents = validates.ValidateParents(parentdetails, studentadmission);
                            if (messages_parents.Status != false)
                            {
                                MessageBox.Show(messages_parents.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                ParentAccount.ParentId = parentid;
                                ParentAccount.SchoolId = Convert.ToInt32(GlobalAccount.SchoolId);
                                ParentAccount.FathersName = FatherName.Text;
                                ParentAccount.MothersName = MotherName.Text;
                                ParentAccount.FathersMailId = FatherEmail.Text;
                                ParentAccount.MothersMailId = MotherEmail.Text;
                                ParentAccount.FathersMobileNumber = FatherMobile.Text;
                                ParentAccount.MothersMobileNumber = MotherMobile.Text;
                                ParentAccount.FathersOccupation = FatherOccupation.Text;
                                ParentAccount.MothersOccupation = MotherOccupation.Text;
                                ParentAccount.FathersBloodGroup = FatherBloodGroup.Text;
                                ParentAccount.MothersBloodGroup = MotherBloodGroup.Text;
                                ParentAccount.Address = Address.Text;
                                ParentAccount.Password = password;


                                Application.OpenForms.OfType<Student_MainForm>().First().Student_Admission.StateCommon.Back.Color1 = System.Drawing.Color.RosyBrown;
                                Application.OpenForms.OfType<Student_MainForm>().First().kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.White;
                                GlobalAccount.ParentId = parentid;
                                this.Hide();
                                var studentTypes = Convert.ToInt32(Studentadmission.SelectedValue);
                                if (studentTypes == 1)
                                {
                                    form = (Students)Application.OpenForms["Students"];
                                    if (form == null)
                                    {
                                        form = new Students();
                                    }
                                    form.TopLevel = false;
                                    Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Dock = DockStyle.Fill;
                                    Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Controls.Add(form);
                                    form.BringToFront();
                                    form.Show();

                                }
                                else
                                {
                                    form = (Bulkstudent)Application.OpenForms["Bulkstudent"];
                                    if (form == null)
                                    {
                                        form = new Bulkstudent();
                                    }
                                    form.TopLevel = false;
                                    Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Dock = DockStyle.Fill;
                                    Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Controls.Add(form);
                                    form.BringToFront();
                                    form.Show();
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("Please Select No. of Student admission", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Studentadmission.Focus();
                            Studentadmission.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please Enter The Father and Mother Name and make sure it should be more than length of 2.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (Next.Text == "Update")
                {
                    UpdateParent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Studentadmission_SelectionChangeCommitted(object sender, EventArgs e)
        {
            form = new Student_MainForm();

            var studentTypes = Convert.ToInt32(Studentadmission.SelectedValue);
            SetValueForText1 = studentTypes;
            if (studentTypes == 1)
            {
                form = new Students();
                Application.OpenForms.OfType<Student_MainForm>().First().Student_Admission.Text = "Single Student Admission";

            }
            else
            {
                form = new Bulkstudent();
                Application.OpenForms.OfType<Student_MainForm>().First().Student_Admission.Text = "Multiple Student Admission";

            }
        }

        private void ClearDataForm()
        {
            FatherName.Text = "";
            MotherName.Text = "";
            FatherEmail.Text = "";
            MotherEmail.Text = "";
            FatherMobile.Text = "";
            MotherMobile.Text = "";
            FatherOccupation.Text = "";
            MotherOccupation.Text = "";
            FatherBloodGroup.Text = "";
            MotherBloodGroup.Text = "";
            Address.Text = "";
        }

        public Parent ParentDetails()
        {
            var parentdetails = new Parent
            {

                FathersName = FatherName.Text,
                MothersName = MotherName.Text,
                FathersMailId = FatherEmail.Text,
                MothersMailId = MotherEmail.Text,
                FathersMobileNumber = FatherMobile.Text,
                MothersMobileNumber = MotherMobile.Text,
                FathersOccupation = FatherOccupation.Text,
                MothersOccupation = MotherOccupation.Text,
                FathersBloodGroup = FatherBloodGroup.Text,
                MothersBloodGroup = MotherBloodGroup.Text,
                Address = Address.Text,
                IsActive = true,
                IsDelete = false,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
            };
            return parentdetails;
        }

        public void getparentdata(int Id, int schoolId, string parentId)
        {
            try
            {
                var getparentdetails = Db.Parents.AsNoTracking().FirstOrDefault(x => x.Id == Id && x.SchoolId == schoolId && x.ParentId == parentId);
                if (getparentdetails != null)
                {
                    hiddenIdColumn = getparentdetails.Id;
                    FatherName.Text = getparentdetails.FathersName;
                    MotherName.Text = getparentdetails.MothersName;
                    FatherEmail.Text = getparentdetails.FathersMailId;
                    MotherEmail.Text = getparentdetails.MothersMailId;
                    FatherMobile.Text = getparentdetails.FathersMobileNumber;
                    MotherMobile.Text = getparentdetails.MothersMobileNumber;
                    FatherOccupation.Text = getparentdetails.FathersOccupation;
                    MotherOccupation.Text = getparentdetails.FathersOccupation;
                    FatherBloodGroup.Text = getparentdetails.FathersBloodGroup;
                    MotherBloodGroup.Text = getparentdetails.MothersBloodGroup;
                    Address.Text = getparentdetails.Address;
                    Studentadmission.Visible = false;
                    kryptonLabel4.Visible = false;
                    Next.Text = "Update";
                }
                else
                {
                    MessageBox.Show("Parent record not found.");
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateParent()
        {
            try
            {
                var getparentdetails = Db.Parents.AsNoTracking().FirstOrDefault(x => x.Id == hiddenIdColumn);
                if (getparentdetails != null)
                {
                    getparentdetails.FathersName = FatherName.Text;
                    getparentdetails.MothersName = MotherName.Text;
                    getparentdetails.FathersMailId = FatherEmail.Text;
                    getparentdetails.MothersMailId = MotherEmail.Text;
                    getparentdetails.FathersMobileNumber = FatherMobile.Text;
                    getparentdetails.MothersMobileNumber = MotherMobile.Text;
                    getparentdetails.FathersOccupation = FatherOccupation.Text;
                    getparentdetails.MothersOccupation = MotherOccupation.Text;
                    getparentdetails.FathersBloodGroup = FatherBloodGroup.Text;
                    getparentdetails.MothersBloodGroup = MotherBloodGroup.Text;
                    getparentdetails.Address = Address.Text;

                    var messages_parent = validates.ValidateParents(getparentdetails, "ValidationContext");
                    if (messages_parent.Status == true)
                    {
                        MessageBox.Show(messages_parent.Message);
                    }
                    else
                    {
                        getparentdetails.DateModified = DateTime.Now;
                        Db.Entry(getparentdetails).State = EntityState.Modified;
                        Db.SaveChanges();
                        Studentadmission.Visible = true;
                        kryptonLabel4.Visible = true;
                        Next.Text = "Submit";
                        ClearDataForm();
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Hide();
                        form = new ParentDetails();
                        form.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                        form.BringToFront();
                        form.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Parent record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, if problem continue occurs, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
