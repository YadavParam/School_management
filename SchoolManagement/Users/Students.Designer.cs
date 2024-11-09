using SchoolManagement.Properties;
using System;
using System.Drawing;
using System.Linq;

namespace SchoolManagement
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.Name = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Email = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.Phone = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.StudentType = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.Class = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.Gender = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.Birthday = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.Section = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.Address = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.BloodGroup = new Krypton.Toolkit.KryptonComboBox();
            this.Student_Register = new Krypton.Toolkit.KryptonButton();
            this.ChooseImage = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodGroup)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(41, 17);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Name\r\n";
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Name.Location = new System.Drawing.Point(8, 23);
            this.Name.MinimumSize = new System.Drawing.Size(0, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(534, 30);
            this.Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Name.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Name.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Name.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Name.StateCommon.Border.Rounding = 2F;
            this.Name.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Name.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.TabIndex = 27;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(40, 17);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 28;
            this.kryptonLabel2.Values.Text = "Email\r\n";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Email.Location = new System.Drawing.Point(19, 23);
            this.Email.MinimumSize = new System.Drawing.Size(0, 30);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(533, 30);
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Email.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Email.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Email.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateCommon.Border.Rounding = 2F;
            this.Email.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Email.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(956, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(11, 105);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(136, 22);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 52;
            this.kryptonLabel4.Values.Text = "Student\'s Detail";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(66, 16);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 69;
            this.kryptonLabel9.Values.Text = "Phone No.";
            // 
            // Phone
            // 
            this.Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone.Location = new System.Drawing.Point(8, 23);
            this.Phone.MinimumSize = new System.Drawing.Size(0, 30);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(534, 30);
            this.Phone.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Phone.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Phone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Phone.StateCommon.Border.Rounding = 2F;
            this.Phone.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Phone.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.TabIndex = 70;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(14, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(82, 16);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 71;
            this.kryptonLabel3.Values.Text = "Student Type";
            // 
            // StudentType
            // 
            this.StudentType.AllowButtonSpecToolTips = true;
            this.StudentType.AllowDrop = true;
            this.StudentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentType.DropDownHeight = 150;
            this.StudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentType.DropDownWidth = 273;
            this.StudentType.IntegralHeight = false;
            this.StudentType.Location = new System.Drawing.Point(19, 23);
            this.StudentType.MinimumSize = new System.Drawing.Size(0, 30);
            this.StudentType.Name = "StudentType";
            this.StudentType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.StudentType.Size = new System.Drawing.Size(533, 30);
            this.StudentType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentType.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentType.StateCommon.ComboBox.Border.Rounding = 2F;
            this.StudentType.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentType.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.StudentType.TabIndex = 72;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 73;
            this.kryptonLabel5.Values.Text = "Class";
            // 
            // Class
            // 
            this.Class.AllowButtonSpecToolTips = true;
            this.Class.AllowDrop = true;
            this.Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Class.DropDownHeight = 150;
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.DropDownWidth = 273;
            this.Class.IntegralHeight = false;
            this.Class.Location = new System.Drawing.Point(8, 23);
            this.Class.MinimumSize = new System.Drawing.Size(0, 30);
            this.Class.Name = "Class";
            this.Class.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Class.Size = new System.Drawing.Size(534, 30);
            this.Class.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Class.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Class.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Class.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Class.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.Class.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.Class.TabIndex = 74;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(14, 3);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 75;
            this.kryptonLabel7.Values.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.AllowButtonSpecToolTips = true;
            this.Gender.AllowDrop = true;
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Gender.DropDownHeight = 150;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.DropDownWidth = 273;
            this.Gender.IntegralHeight = false;
            this.Gender.Location = new System.Drawing.Point(19, 23);
            this.Gender.MinimumSize = new System.Drawing.Size(0, 30);
            this.Gender.Name = "Gender";
            this.Gender.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Gender.Size = new System.Drawing.Size(533, 30);
            this.Gender.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Gender.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Gender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Gender.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Gender.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gender.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.Gender.TabIndex = 76;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(56, 16);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 77;
            this.kryptonLabel6.Values.Text = "Birthday";
            // 
            // Birthday
            // 
            this.Birthday.AllowDrop = true;
            this.Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Birthday.AutoShift = true;
            this.Birthday.Location = new System.Drawing.Point(8, 23);
            this.Birthday.MinimumSize = new System.Drawing.Size(0, 30);
            this.Birthday.Name = "Birthday";
            this.Birthday.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Birthday.Size = new System.Drawing.Size(534, 30);
            this.Birthday.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Birthday.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Birthday.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Birthday.StateCommon.Border.Rounding = 2F;
            this.Birthday.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Birthday.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.TabIndex = 80;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(14, 3);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 81;
            this.kryptonLabel8.Values.Text = "Section";
            // 
            // Section
            // 
            this.Section.AllowButtonSpecToolTips = true;
            this.Section.AllowDrop = true;
            this.Section.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Section.DropDownHeight = 150;
            this.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Section.DropDownWidth = 273;
            this.Section.IntegralHeight = false;
            this.Section.Location = new System.Drawing.Point(19, 23);
            this.Section.MinimumSize = new System.Drawing.Size(0, 30);
            this.Section.Name = "Section";
            this.Section.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Section.Size = new System.Drawing.Size(533, 30);
            this.Section.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Section.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Section.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Section.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Section.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.Section.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.Section.TabIndex = 82;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(3, 2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(56, 16);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 83;
            this.kryptonLabel10.Values.Text = "Address";
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(8, 22);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(534, 53);
            this.Address.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Address.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Address.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Address.StateCommon.Border.Rounding = 2F;
            this.Address.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Address.TabIndex = 84;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(14, 2);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(79, 16);
            this.kryptonLabel11.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel11.TabIndex = 85;
            this.kryptonLabel11.Values.Text = "Blood Group";
            // 
            // BloodGroup
            // 
            this.BloodGroup.AllowButtonSpecToolTips = true;
            this.BloodGroup.AllowDrop = true;
            this.BloodGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BloodGroup.DropDownHeight = 90;
            this.BloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BloodGroup.DropDownWidth = 273;
            this.BloodGroup.IntegralHeight = false;
            this.BloodGroup.Location = new System.Drawing.Point(19, 22);
            this.BloodGroup.MinimumSize = new System.Drawing.Size(0, 30);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.BloodGroup.Size = new System.Drawing.Size(533, 30);
            this.BloodGroup.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.BloodGroup.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.BloodGroup.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BloodGroup.StateCommon.ComboBox.Border.Rounding = 2F;
            this.BloodGroup.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.BloodGroup.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.BloodGroup.TabIndex = 86;
            // 
            // Student_Register
            // 
            this.Student_Register.Location = new System.Drawing.Point(7, 3);
            this.Student_Register.Name = "Student_Register";
            this.Student_Register.Size = new System.Drawing.Size(107, 32);
            this.Student_Register.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Student_Register.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Student_Register.StateCommon.Border.Rounding = 2F;
            this.Student_Register.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Register.TabIndex = 87;
            this.Student_Register.Values.Text = "Submit";
            this.Student_Register.Click += new System.EventHandler(this.Student_Register_Click);
            // 
            // ChooseImage
            // 
            this.ChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChooseImage.Location = new System.Drawing.Point(956, 134);
            this.ChooseImage.Name = "ChooseImage";
            this.ChooseImage.Size = new System.Drawing.Size(161, 21);
            this.ChooseImage.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.ChooseImage.StateCommon.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.ChooseImage.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ChooseImage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseImage.TabIndex = 88;
            this.ChooseImage.Values.Text = "Choose Image";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 89;
            // 
            // panel13
            // 
            this.panel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel13.Controls.Add(this.pictureBox1);
            this.panel13.Controls.Add(this.ChooseImage);
            this.panel13.Controls.Add(this.kryptonLabel4);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1149, 157);
            this.panel13.TabIndex = 91;
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel12.Controls.Add(this.Student_Register);
            this.panel12.Location = new System.Drawing.Point(12, 587);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(117, 38);
            this.panel12.TabIndex = 90;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1132, 415);
            this.tableLayoutPanel1.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.Name);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 77);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.Email);
            this.panel3.Controls.Add(this.kryptonLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(569, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 77);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.Phone);
            this.panel4.Controls.Add(this.kryptonLabel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 77);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.StudentType);
            this.panel5.Controls.Add(this.kryptonLabel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(569, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(560, 77);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.Birthday);
            this.panel6.Controls.Add(this.kryptonLabel6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 77);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.Gender);
            this.panel7.Controls.Add(this.kryptonLabel7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(569, 169);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(560, 77);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.Class);
            this.panel8.Controls.Add(this.kryptonLabel5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(560, 77);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.Controls.Add(this.Section);
            this.panel9.Controls.Add(this.kryptonLabel8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(569, 252);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 77);
            this.panel9.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel10.Controls.Add(this.Address);
            this.panel10.Controls.Add(this.kryptonLabel10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 335);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(560, 77);
            this.panel10.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel11.Controls.Add(this.BloodGroup);
            this.panel11.Controls.Add(this.kryptonLabel11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(569, 335);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(560, 77);
            this.panel11.TabIndex = 9;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "x";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodGroup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox Name;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonTextBox Phone;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox StudentType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonComboBox Class;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonComboBox Gender;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonDateTimePicker Birthday;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonComboBox Section;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox Address;
        private Krypton.Toolkit.KryptonComboBox BloodGroup;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonButton Student_Register;
        private Krypton.Toolkit.KryptonButton ChooseImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
    }
}