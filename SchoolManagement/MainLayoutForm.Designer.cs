namespace SchoolManagement
{
    partial class MainLayoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayoutForm));
            this.UserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Teacher_Staff = new System.Windows.Forms.Button();
            this.userclick = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Acedmic = new System.Windows.Forms.Button();
            this.Daily_attandance = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Button();
            this.Class_Routine = new System.Windows.Forms.Button();
            this.Class_Period = new System.Windows.Forms.Button();
            this.Event_Calender = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Accounting = new System.Windows.Forms.Button();
            this.StudentFeeManager = new System.Windows.Forms.Button();
            this.ExpenseManager = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.Button();
            this.HeaderPanel = new Krypton.Toolkit.KryptonPanel();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BiomatricAttendance = new System.Windows.Forms.Button();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.menutransition = new System.Windows.Forms.Timer(this.components);
            this.AcedmicTransition = new System.Windows.Forms.Timer(this.components);
            this.AccountingTransition = new System.Windows.Forms.Timer(this.components);
            this.UserPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.AllowDrop = true;
            this.UserPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserPanel.Controls.Add(this.userclick);
            this.UserPanel.Controls.Add(this.Student);
            this.UserPanel.Controls.Add(this.Teacher_Staff);
            this.UserPanel.Controls.Add(this.BiomatricAttendance);
            this.UserPanel.Location = new System.Drawing.Point(0, 106);
            this.UserPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(270, 50);
            this.UserPanel.TabIndex = 2;
            // 
            // Teacher_Staff
            // 
            this.Teacher_Staff.BackColor = System.Drawing.Color.White;
            this.Teacher_Staff.FlatAppearance.BorderSize = 0;
            this.Teacher_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher_Staff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.Teacher_Staff.Image = ((System.Drawing.Image)(resources.GetObject("Teacher_Staff.Image")));
            this.Teacher_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teacher_Staff.Location = new System.Drawing.Point(0, 100);
            this.Teacher_Staff.Margin = new System.Windows.Forms.Padding(0);
            this.Teacher_Staff.Name = "Teacher_Staff";
            this.Teacher_Staff.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Teacher_Staff.Size = new System.Drawing.Size(270, 50);
            this.Teacher_Staff.TabIndex = 5;
            this.Teacher_Staff.Text = "  Teacher/Staff";
            this.Teacher_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Teacher_Staff.UseVisualStyleBackColor = false;
            this.Teacher_Staff.Click += new System.EventHandler(this.Teacher_Staff_Click);
            // 
            // userclick
            // 
            this.userclick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userclick.BackColor = System.Drawing.Color.White;
            this.userclick.FlatAppearance.BorderSize = 0;
            this.userclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userclick.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userclick.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userclick.Image = ((System.Drawing.Image)(resources.GetObject("userclick.Image")));
            this.userclick.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.userclick.Location = new System.Drawing.Point(0, 0);
            this.userclick.Margin = new System.Windows.Forms.Padding(0);
            this.userclick.Name = "userclick";
            this.userclick.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.userclick.Size = new System.Drawing.Size(270, 50);
            this.userclick.TabIndex = 3;
            this.userclick.Text = "  User";
            this.userclick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userclick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userclick.UseVisualStyleBackColor = false;
            this.userclick.Click += new System.EventHandler(this.userclick_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.White;
            this.Student.FlatAppearance.BorderSize = 0;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.Student.Image = ((System.Drawing.Image)(resources.GetObject("Student.Image")));
            this.Student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student.Location = new System.Drawing.Point(0, 50);
            this.Student.Margin = new System.Windows.Forms.Padding(0);
            this.Student.Name = "Student";
            this.Student.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Student.Size = new System.Drawing.Size(270, 50);
            this.Student.TabIndex = 5;
            this.Student.Text = "  Student ";
            this.Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.Acedmic);
            this.flowLayoutPanel1.Controls.Add(this.Daily_attandance);
            this.flowLayoutPanel1.Controls.Add(this.Subject);
            this.flowLayoutPanel1.Controls.Add(this.Class);
            this.flowLayoutPanel1.Controls.Add(this.Class_Routine);
            this.flowLayoutPanel1.Controls.Add(this.Class_Period);
            this.flowLayoutPanel1.Controls.Add(this.Event_Calender);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 50);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // Acedmic
            // 
            this.Acedmic.AllowDrop = true;
            this.Acedmic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Acedmic.BackColor = System.Drawing.Color.White;
            this.Acedmic.FlatAppearance.BorderSize = 0;
            this.Acedmic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acedmic.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acedmic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Acedmic.Image = ((System.Drawing.Image)(resources.GetObject("Acedmic.Image")));
            this.Acedmic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acedmic.Location = new System.Drawing.Point(0, 0);
            this.Acedmic.Margin = new System.Windows.Forms.Padding(0);
            this.Acedmic.Name = "Acedmic";
            this.Acedmic.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Acedmic.Size = new System.Drawing.Size(270, 50);
            this.Acedmic.TabIndex = 9;
            this.Acedmic.Text = "  Academic";
            this.Acedmic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acedmic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Acedmic.UseVisualStyleBackColor = false;
            this.Acedmic.Click += new System.EventHandler(this.Acedmic_Click);
            // 
            // Daily_attandance
            // 
            this.Daily_attandance.AllowDrop = true;
            this.Daily_attandance.BackColor = System.Drawing.Color.White;
            this.Daily_attandance.FlatAppearance.BorderSize = 0;
            this.Daily_attandance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daily_attandance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily_attandance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Daily_attandance.Image = ((System.Drawing.Image)(resources.GetObject("Daily_attandance.Image")));
            this.Daily_attandance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daily_attandance.Location = new System.Drawing.Point(0, 50);
            this.Daily_attandance.Margin = new System.Windows.Forms.Padding(0);
            this.Daily_attandance.Name = "Daily_attandance";
            this.Daily_attandance.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Daily_attandance.Size = new System.Drawing.Size(270, 50);
            this.Daily_attandance.TabIndex = 6;
            this.Daily_attandance.Text = "  Daily Attandance";
            this.Daily_attandance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daily_attandance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Daily_attandance.UseVisualStyleBackColor = false;
            this.Daily_attandance.Click += new System.EventHandler(this.Daily_attandance_Click);
            // 
            // Subject
            // 
            this.Subject.AllowDrop = true;
            this.Subject.BackColor = System.Drawing.Color.White;
            this.Subject.FlatAppearance.BorderSize = 0;
            this.Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Subject.Image = ((System.Drawing.Image)(resources.GetObject("Subject.Image")));
            this.Subject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.Location = new System.Drawing.Point(0, 100);
            this.Subject.Margin = new System.Windows.Forms.Padding(0);
            this.Subject.Name = "Subject";
            this.Subject.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Subject.Size = new System.Drawing.Size(270, 50);
            this.Subject.TabIndex = 8;
            this.Subject.Text = "  Subject";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Subject.UseVisualStyleBackColor = false;
            this.Subject.Click += new System.EventHandler(this.Subject_Click);
            // 
            // Class
            // 
            this.Class.AllowDrop = true;
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.FlatAppearance.BorderSize = 0;
            this.Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Class.Image = ((System.Drawing.Image)(resources.GetObject("Class.Image")));
            this.Class.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class.Location = new System.Drawing.Point(0, 150);
            this.Class.Margin = new System.Windows.Forms.Padding(0);
            this.Class.Name = "Class";
            this.Class.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Class.Size = new System.Drawing.Size(270, 50);
            this.Class.TabIndex = 10;
            this.Class.Text = "  Class";
            this.Class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Class.UseVisualStyleBackColor = false;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // Class_Routine
            // 
            this.Class_Routine.AllowDrop = true;
            this.Class_Routine.BackColor = System.Drawing.Color.White;
            this.Class_Routine.FlatAppearance.BorderSize = 0;
            this.Class_Routine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_Routine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Routine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Class_Routine.Image = ((System.Drawing.Image)(resources.GetObject("Class_Routine.Image")));
            this.Class_Routine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Routine.Location = new System.Drawing.Point(0, 200);
            this.Class_Routine.Margin = new System.Windows.Forms.Padding(0);
            this.Class_Routine.Name = "Class_Routine";
            this.Class_Routine.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Class_Routine.Size = new System.Drawing.Size(270, 50);
            this.Class_Routine.TabIndex = 7;
            this.Class_Routine.Text = "  Class Routine";
            this.Class_Routine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Routine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Class_Routine.UseVisualStyleBackColor = false;
            this.Class_Routine.Click += new System.EventHandler(this.Class_Routine_Click);
            // 
            // Class_Period
            // 
            this.Class_Period.AllowDrop = true;
            this.Class_Period.BackColor = System.Drawing.Color.White;
            this.Class_Period.FlatAppearance.BorderSize = 0;
            this.Class_Period.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_Period.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Class_Period.Image = ((System.Drawing.Image)(resources.GetObject("Class_Period.Image")));
            this.Class_Period.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Period.Location = new System.Drawing.Point(0, 250);
            this.Class_Period.Margin = new System.Windows.Forms.Padding(0);
            this.Class_Period.Name = "Class_Period";
            this.Class_Period.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Class_Period.Size = new System.Drawing.Size(270, 50);
            this.Class_Period.TabIndex = 11;
            this.Class_Period.Text = "  Class Period";
            this.Class_Period.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Period.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Class_Period.UseVisualStyleBackColor = false;
            this.Class_Period.Click += new System.EventHandler(this.Class_Period_Click);
            // 
            // Event_Calender
            // 
            this.Event_Calender.AllowDrop = true;
            this.Event_Calender.BackColor = System.Drawing.Color.White;
            this.Event_Calender.FlatAppearance.BorderSize = 0;
            this.Event_Calender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event_Calender.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_Calender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Event_Calender.Image = ((System.Drawing.Image)(resources.GetObject("Event_Calender.Image")));
            this.Event_Calender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Event_Calender.Location = new System.Drawing.Point(0, 300);
            this.Event_Calender.Margin = new System.Windows.Forms.Padding(0);
            this.Event_Calender.Name = "Event_Calender";
            this.Event_Calender.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Event_Calender.Size = new System.Drawing.Size(270, 50);
            this.Event_Calender.TabIndex = 11;
            this.Event_Calender.Text = "  Event Calender";
            this.Event_Calender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Event_Calender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Event_Calender.UseVisualStyleBackColor = false;
            this.Event_Calender.Click += new System.EventHandler(this.Event_Calender_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.Accounting);
            this.flowLayoutPanel3.Controls.Add(this.StudentFeeManager);
            this.flowLayoutPanel3.Controls.Add(this.ExpenseManager);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 206);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(270, 50);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // Accounting
            // 
            this.Accounting.AllowDrop = true;
            this.Accounting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Accounting.BackColor = System.Drawing.Color.White;
            this.Accounting.FlatAppearance.BorderSize = 0;
            this.Accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accounting.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Accounting.Image = ((System.Drawing.Image)(resources.GetObject("Accounting.Image")));
            this.Accounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.Location = new System.Drawing.Point(2, 0);
            this.Accounting.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Accounting.Name = "Accounting";
            this.Accounting.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Accounting.Size = new System.Drawing.Size(270, 50);
            this.Accounting.TabIndex = 5;
            this.Accounting.Text = "  Accounting";
            this.Accounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Accounting.UseVisualStyleBackColor = false;
            this.Accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // StudentFeeManager
            // 
            this.StudentFeeManager.AllowDrop = true;
            this.StudentFeeManager.BackColor = System.Drawing.Color.White;
            this.StudentFeeManager.FlatAppearance.BorderSize = 0;
            this.StudentFeeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentFeeManager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFeeManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.StudentFeeManager.Image = ((System.Drawing.Image)(resources.GetObject("StudentFeeManager.Image")));
            this.StudentFeeManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentFeeManager.Location = new System.Drawing.Point(0, 50);
            this.StudentFeeManager.Margin = new System.Windows.Forms.Padding(0);
            this.StudentFeeManager.Name = "StudentFeeManager";
            this.StudentFeeManager.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.StudentFeeManager.Size = new System.Drawing.Size(270, 50);
            this.StudentFeeManager.TabIndex = 6;
            this.StudentFeeManager.Text = "  Student Fee Manager";
            this.StudentFeeManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentFeeManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StudentFeeManager.UseVisualStyleBackColor = false;
            this.StudentFeeManager.UseWaitCursor = true;
            this.StudentFeeManager.Click += new System.EventHandler(this.StudentFeeManager_Click);
            // 
            // ExpenseManager
            // 
            this.ExpenseManager.AllowDrop = true;
            this.ExpenseManager.BackColor = System.Drawing.Color.White;
            this.ExpenseManager.FlatAppearance.BorderSize = 0;
            this.ExpenseManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpenseManager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ExpenseManager.Image = ((System.Drawing.Image)(resources.GetObject("ExpenseManager.Image")));
            this.ExpenseManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpenseManager.Location = new System.Drawing.Point(0, 100);
            this.ExpenseManager.Margin = new System.Windows.Forms.Padding(0);
            this.ExpenseManager.Name = "ExpenseManager";
            this.ExpenseManager.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ExpenseManager.Size = new System.Drawing.Size(270, 50);
            this.ExpenseManager.TabIndex = 7;
            this.ExpenseManager.Text = "  Expense Manager";
            this.ExpenseManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpenseManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExpenseManager.UseVisualStyleBackColor = false;
            this.ExpenseManager.UseWaitCursor = true;
            this.ExpenseManager.Click += new System.EventHandler(this.ExpenseManager_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Controls.Add(this.pictureBox2);
            this.SidePanel.Controls.Add(this.Dashboard);
            this.SidePanel.Controls.Add(this.UserPanel);
            this.SidePanel.Controls.Add(this.flowLayoutPanel1);
            this.SidePanel.Controls.Add(this.flowLayoutPanel3);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(270, 647);
            this.SidePanel.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Dashboard.BackColor = System.Drawing.Color.White;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 56);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(270, 50);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "  Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(270, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(865, 56);
            this.HeaderPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.HeaderPanel.TabIndex = 11;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(270, 56);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(865, 591);
            this.MainPanel.TabIndex = 0;
            // 
            // BiomatricAttendance
            // 
            this.BiomatricAttendance.BackColor = System.Drawing.Color.White;
            this.BiomatricAttendance.FlatAppearance.BorderSize = 0;
            this.BiomatricAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiomatricAttendance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiomatricAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.BiomatricAttendance.Image = ((System.Drawing.Image)(resources.GetObject("BiomatricAttendance.Image")));
            this.BiomatricAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiomatricAttendance.Location = new System.Drawing.Point(0, 150);
            this.BiomatricAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.BiomatricAttendance.Name = "BiomatricAttendance";
            this.BiomatricAttendance.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BiomatricAttendance.Size = new System.Drawing.Size(270, 50);
            this.BiomatricAttendance.TabIndex = 5;
            this.BiomatricAttendance.Text = "  Staff Biomatric Attendance ";
            this.BiomatricAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiomatricAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BiomatricAttendance.UseVisualStyleBackColor = false;
            this.BiomatricAttendance.Click += new System.EventHandler(this.BiomatricAttendance_Click);
            // 
            // menutransition
            // 
            this.menutransition.Tick += new System.EventHandler(this.menutransition_Tick);
            // 
            // AcedmicTransition
            // 
            this.AcedmicTransition.Tick += new System.EventHandler(this.AcedmicTransition_Tick);
            // 
            // AccountingTransition
            // 
            this.AccountingTransition.Tick += new System.EventHandler(this.AccountingTransition_Tick);
            // 
            // MainLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 647);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "MainLayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLayoutForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainLayoutForm_Load);
            this.UserPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.FlowLayoutPanel UserPanel;
        private System.Windows.Forms.Button userclick;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Teacher_Staff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Acedmic;
        private System.Windows.Forms.Button Daily_attandance;
        private System.Windows.Forms.Button Subject;
        private System.Windows.Forms.Button Class;
        private System.Windows.Forms.Button Class_Routine;
        private System.Windows.Forms.Button Class_Period;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Accounting;
        private System.Windows.Forms.Button StudentFeeManager;
        private System.Windows.Forms.Button ExpenseManager;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private Krypton.Toolkit.KryptonPanel HeaderPanel;
        public System.Windows.Forms.FlowLayoutPanel MainPanel;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.Timer menutransition;
        private System.Windows.Forms.Timer AcedmicTransition;
        private System.Windows.Forms.Timer AccountingTransition;
        private System.Windows.Forms.Button Event_Calender;
        private System.Windows.Forms.Button BiomatricAttendance;
    }
}