using SchoolManagement.Academic;
using SchoolManagement.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class MainLayoutForm : Form
    {
        Form form;
        private bool menuexpand = false, acedmicexpand = false, accountingexpand;
        public MainLayoutForm()
        {
            InitializeComponent();
        }

        private void MainLayoutForm_Load(object sender, EventArgs e)
        {

            form = (AdminDashboard)Application.OpenForms["AdminDashboard"];
            if (form == null)
            {
                form = new AdminDashboard();
            }
            form.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            form = (AdminDashboard)Application.OpenForms["AdminDashboard"];
            if (form == null)
            {
                form = new AdminDashboard();
            }
            form.TopLevel = false;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            AccountingTransition.Start();

            if (acedmicexpand == true)
            {
                flowLayoutPanel1.Height = 50;
                acedmicexpand = false;
                AcedmicTransition.Stop(); 
            }

            if (menuexpand == true)
            {
                UserPanel.Height = 50;  
                menuexpand = false;
                menutransition.Stop(); 
            }
        }

        private void AccountingTransition_Tick(object sender, EventArgs e)
        {
            if (accountingexpand == false)
            {
                flowLayoutPanel3.Height += 50;
                if (flowLayoutPanel3.Height >= 120)
                {
                    AccountingTransition.Stop();
                    accountingexpand = true;
                }

            }
            else
            {
                flowLayoutPanel3.Height -= 50;
                if (flowLayoutPanel3.Height <= 60)
                {
                    AccountingTransition.Stop();
                    accountingexpand = false;
                }
            }
        }

        private void Acedmic_Click(object sender, EventArgs e)
        {
            AcedmicTransition.Start();

            if (accountingexpand == true)
            {
                flowLayoutPanel3.Height = 50;
                accountingexpand = false;
                AccountingTransition.Stop(); 
            }

            if (menuexpand == true)
            {
                UserPanel.Height = 50;
                menuexpand = false;
                menutransition.Stop();
            }
        }

        private void AcedmicTransition_Tick(object sender, EventArgs e)
        {
            if (acedmicexpand == false)
            {
                flowLayoutPanel1.Height += 50;
                if (flowLayoutPanel1.Height >= 350)
                {
                    AcedmicTransition.Stop();
                    acedmicexpand = true;
                }

            }
            else
            {
                flowLayoutPanel1.Height -= 50;
                if (flowLayoutPanel1.Height <= 50)
                {
                    AcedmicTransition.Stop();
                    acedmicexpand = false;
                }
            }
        }

        private void userclick_Click(object sender, EventArgs e)
        {
            menutransition.Start();

            if (accountingexpand == true)
            {
                flowLayoutPanel3.Height = 50;
                accountingexpand = false;
                AccountingTransition.Stop();
            }

            if (acedmicexpand == true)
            {
                flowLayoutPanel1.Height = 50;
                acedmicexpand = false;
                AcedmicTransition.Stop();
            }
        }

        private void menutransition_Tick(object sender, EventArgs e)
        {
            if (menuexpand == false)
            {
                UserPanel.Height += 50;
                if (UserPanel.Height >= 120)
                {
                    menutransition.Stop();
                    menuexpand = true;
                }

            }
            else
            {
                UserPanel.Height -= 50;
                if (UserPanel.Height <= 50)
                {
                    menutransition.Stop();
                    menuexpand = false;
                }
            }
        }

        private void Student_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (StudentDetails)Application.OpenForms["StudentDetails"];
                if (form == null)
                {
                    form = new StudentDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void Teacher_Staff_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (StaffDetails)Application.OpenForms["StaffDetails"];
                if (form == null)
                {
                    form = new StaffDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Daily_attandance_Click(object sender, EventArgs e)
        {
            try
            {
                form = (StudentAttandence)Application.OpenForms["StudentAttandence"];
                if (form == null)
                {
                    form = new StudentAttandence();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Subject_Click(object sender, EventArgs e)
        {
            try
            {
                form = (SubjectAcademic)Application.OpenForms["SubjectAcademic"];
                if (form == null)
                {
                    form = new SubjectAcademic();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Class_Click(object sender, EventArgs e)
        {
            try
            {
                form = (ClassAcademic)Application.OpenForms["ClassAcademic"];
                if (form == null)
                {
                    form = new ClassAcademic();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Class_Routine_Click(object sender, EventArgs e)
        {
            try
            {
                form = (ClassRoutine)Application.OpenForms["ClassRoutine"];
                if (form == null)
                {
                    form = new ClassRoutine();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Class_Period_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (ClassPeriodDetails)Application.OpenForms["ClassPeriodDetails"];
                if (form == null)
                {
                    form = new ClassPeriodDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void StudentFeeManager_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (StudentFeeDetails)Application.OpenForms["StudentFeeDetails"];
                if (form == null)
                {
                    form = new StudentFeeDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ExpenseManager_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (ExpenseManagerDetails)Application.OpenForms["ExpenseManagerDetails"];
                if (form == null)
                {
                    form = new ExpenseManagerDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Event_Calender_Click(object sender, EventArgs e)
        {
            try
            {
                form.Close();
                form = (EventCalenderDetails)Application.OpenForms["EventCalenderDetails"];
                if (form == null)
                {
                    form = new EventCalenderDetails();
                }
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
