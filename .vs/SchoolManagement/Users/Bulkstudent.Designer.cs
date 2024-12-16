namespace SchoolManagement
{
    partial class Bulkstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulkstudent));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitRecord = new System.Windows.Forms.Button();
            this.Multistudent = new Krypton.Toolkit.KryptonDataGridView();
            this.AddMore = new System.Windows.Forms.Button();
            this.StudentGender = new Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new Krypton.Toolkit.KryptonTextBox();
            this.Phone = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentTypes = new Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Section = new Krypton.Toolkit.KryptonComboBox();
            this.Class = new Krypton.Toolkit.KryptonComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.StudentNames = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentPhone = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentEmails = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentType = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.StudentGenders = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.StudentParents = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Multistudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Class";
            // 
            // SubmitRecord
            // 
            this.SubmitRecord.BackColor = System.Drawing.Color.DodgerBlue;
            this.SubmitRecord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitRecord.Location = new System.Drawing.Point(17, 5);
            this.SubmitRecord.Name = "SubmitRecord";
            this.SubmitRecord.Size = new System.Drawing.Size(126, 36);
            this.SubmitRecord.TabIndex = 18;
            this.SubmitRecord.Text = "Submit All Record";
            this.SubmitRecord.UseVisualStyleBackColor = false;
            this.SubmitRecord.Click += new System.EventHandler(this.SubmitRecord_Click);
            // 
            // Multistudent
            // 
            this.Multistudent.AllowUserToAddRows = false;
            this.Multistudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Multistudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNames,
            this.StudentPhone,
            this.StudentEmails,
            this.StudentType,
            this.StudentGenders,
            this.StudentParents,
            this.Action});
            this.Multistudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.Multistudent.Location = new System.Drawing.Point(17, 315);
            this.Multistudent.Name = "Multistudent";
            this.Multistudent.Size = new System.Drawing.Size(1115, 354);
            this.Multistudent.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.Multistudent.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Multistudent.TabIndex = 17;
            this.Multistudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Multistudent_CellContentClick);
            // 
            // AddMore
            // 
            this.AddMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMore.Location = new System.Drawing.Point(20, 21);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(135, 33);
            this.AddMore.TabIndex = 16;
            this.AddMore.Text = "Add More";
            this.AddMore.UseVisualStyleBackColor = false;
            this.AddMore.Click += new System.EventHandler(this.Addmore_Click);
            // 
            // StudentGender
            // 
            this.StudentGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentGender.DropDownWidth = 109;
            this.StudentGender.IntegralHeight = false;
            this.StudentGender.Location = new System.Drawing.Point(8, 24);
            this.StudentGender.MinimumSize = new System.Drawing.Size(0, 30);
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.StudentGender.Size = new System.Drawing.Size(536, 30);
            this.StudentGender.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentGender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentGender.StateCommon.ComboBox.Border.Rounding = 2F;
            this.StudentGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.StudentGender.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.Location = new System.Drawing.Point(8, 23);
            this.Email.MinimumSize = new System.Drawing.Size(0, 30);
            this.Email.Name = "Email";
            this.Email.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Email.Size = new System.Drawing.Size(536, 30);
            this.Email.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Email.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateCommon.Border.Rounding = 2F;
            this.Email.TabIndex = 9;
            // 
            // Phone
            // 
            this.Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone.Location = new System.Drawing.Point(20, 23);
            this.Phone.MinimumSize = new System.Drawing.Size(0, 30);
            this.Phone.Name = "Phone";
            this.Phone.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Phone.Size = new System.Drawing.Size(535, 30);
            this.Phone.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Phone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Phone.StateCommon.Border.Rounding = 2F;
            this.Phone.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone No";
            // 
            // StudentTypes
            // 
            this.StudentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentTypes.DropDownWidth = 109;
            this.StudentTypes.IntegralHeight = false;
            this.StudentTypes.Location = new System.Drawing.Point(20, 23);
            this.StudentTypes.MinimumSize = new System.Drawing.Size(0, 30);
            this.StudentTypes.Name = "StudentTypes";
            this.StudentTypes.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.StudentTypes.Size = new System.Drawing.Size(535, 30);
            this.StudentTypes.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentTypes.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentTypes.StateCommon.ComboBox.Border.Rounding = 2F;
            this.StudentTypes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.StudentTypes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Type";
            // 
            // StudentName
            // 
            this.StudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentName.Location = new System.Drawing.Point(8, 23);
            this.StudentName.MinimumSize = new System.Drawing.Size(0, 30);
            this.StudentName.Name = "StudentName";
            this.StudentName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.StudentName.Size = new System.Drawing.Size(536, 30);
            this.StudentName.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentName.StateCommon.Border.Rounding = 2F;
            this.StudentName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // Section
            // 
            this.Section.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Section.DropDownWidth = 172;
            this.Section.IntegralHeight = false;
            this.Section.Location = new System.Drawing.Point(20, 23);
            this.Section.MinimumSize = new System.Drawing.Size(0, 30);
            this.Section.Name = "Section";
            this.Section.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Section.Size = new System.Drawing.Size(535, 30);
            this.Section.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Section.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Section.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Section.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Section.TabIndex = 1;
            // 
            // Class
            // 
            this.Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.DropDownWidth = 200;
            this.Class.IntegralHeight = false;
            this.Class.Location = new System.Drawing.Point(7, 23);
            this.Class.MinimumSize = new System.Drawing.Size(0, 30);
            this.Class.Name = "Class";
            this.Class.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Class.Size = new System.Drawing.Size(536, 30);
            this.Class.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Class.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Class.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Class.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Class.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Multistudent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 20;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 265);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.Class);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 60);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.Section);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(571, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 60);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.StudentName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(562, 60);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.Phone);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(571, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(562, 60);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.Email);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(562, 60);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.StudentTypes);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(571, 135);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(562, 60);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.StudentGender);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 201);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(562, 61);
            this.panel8.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.Controls.Add(this.AddMore);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(571, 201);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(562, 61);
            this.panel9.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel10.Controls.Add(this.SubmitRecord);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 681);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1149, 56);
            this.panel10.TabIndex = 21;
            // 
            // StudentNames
            // 
            this.StudentNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentNames.DataPropertyName = "Multistudent_RowsRemoved";
            this.StudentNames.HeaderText = "Name";
            this.StudentNames.MinimumWidth = 200;
            this.StudentNames.Name = "StudentNames";
            this.StudentNames.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentNames.Width = 200;
            // 
            // StudentPhone
            // 
            this.StudentPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentPhone.HeaderText = "Phone";
            this.StudentPhone.MinimumWidth = 200;
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentPhone.Width = 200;
            // 
            // StudentEmails
            // 
            this.StudentEmails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentEmails.HeaderText = "Email";
            this.StudentEmails.MinimumWidth = 200;
            this.StudentEmails.Name = "StudentEmails";
            this.StudentEmails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentEmails.Width = 200;
            // 
            // StudentType
            // 
            this.StudentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentType.DataSource = null;
            this.StudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentType.DropDownWidth = 121;
            this.StudentType.HeaderText = "Type";
            this.StudentType.MinimumWidth = 200;
            this.StudentType.Name = "StudentType";
            this.StudentType.Width = 200;
            // 
            // StudentGenders
            // 
            this.StudentGenders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentGenders.DataSource = null;
            this.StudentGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentGenders.DropDownWidth = 121;
            this.StudentGenders.HeaderText = "Gender";
            this.StudentGenders.MinimumWidth = 200;
            this.StudentGenders.Name = "StudentGenders";
            this.StudentGenders.Width = 200;
            // 
            // StudentParents
            // 
            this.StudentParents.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentParents.DataSource = null;
            this.StudentParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentParents.DropDownWidth = 121;
            this.StudentParents.HeaderText = "Parent";
            this.StudentParents.MinimumWidth = 200;
            this.StudentParents.Name = "StudentParents";
            this.StudentParents.Width = 200;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Action.HeaderText = "Delete";
            this.Action.Image = ((System.Drawing.Image)(resources.GetObject("Action.Image")));
            this.Action.MinimumWidth = 200;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.ToolTipText = "Delete";
            // 
            // Bulkstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bulkstudent";
            this.Text = "Bulkstudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BulkStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Multistudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            this.panel1.ResumeLayout(false);
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
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonComboBox Section;
        private Krypton.Toolkit.KryptonComboBox Class;
        private Krypton.Toolkit.KryptonComboBox StudentTypes;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox StudentName;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonTextBox Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonComboBox StudentGender;
        private System.Windows.Forms.Button AddMore;
        private Krypton.Toolkit.KryptonDataGridView Multistudent;
        private System.Windows.Forms.Button SubmitRecord;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentNames;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentPhone;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentEmails;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentType;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentGenders;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentParents;
        private System.Windows.Forms.DataGridViewImageColumn Action;
    }
}