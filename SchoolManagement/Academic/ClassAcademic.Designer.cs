namespace SchoolManagement
{
    partial class ClassAcademic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassAcademic));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ClassSection = new Krypton.Toolkit.KryptonTextBox();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.ClassName = new Krypton.Toolkit.KryptonComboBox();
            this.section_streamType = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClassDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumnButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumnButton = new System.Windows.Forms.DataGridViewImageColumn();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.Search = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClassName)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(2, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Class";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(50, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Section";
            // 
            // ClassSection
            // 
            this.ClassSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassSection.Location = new System.Drawing.Point(57, 29);
            this.ClassSection.MinimumSize = new System.Drawing.Size(0, 30);
            this.ClassSection.Name = "ClassSection";
            this.ClassSection.Size = new System.Drawing.Size(500, 30);
            this.ClassSection.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.ClassSection.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClassSection.StateCommon.Border.Rounding = 2F;
            this.ClassSection.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSection.TabIndex = 5;
            this.ClassSection.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClassSection_KeyUp);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(6, 30);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(107, 32);
            this.Submit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Submit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateCommon.Border.Rounding = 2F;
            this.Submit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.TabIndex = 26;
            this.Submit.Values.Text = "Submit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(57, 2);
            this.flowLayoutPanel.MaximumSize = new System.Drawing.Size(600, 500);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel.TabIndex = 27;
            this.flowLayoutPanel.Visible = false;
            // 
            // btnBetweenPg
            // 
            this.btnBetweenPg.Location = new System.Drawing.Point(463, 19);
            this.btnBetweenPg.Name = "btnBetweenPg";
            this.btnBetweenPg.Size = new System.Drawing.Size(55, 20);
            this.btnBetweenPg.TabIndex = 29;
            this.btnBetweenPg.Values.Text = "Pages: 0";
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(609, 19);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 29;
            this.TotalCount.Values.Text = ".";
            // 
            // ClassName
            // 
            this.ClassName.AllowDrop = true;
            this.ClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassName.DropDownHeight = 180;
            this.ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassName.DropDownWidth = 273;
            this.ClassName.IntegralHeight = false;
            this.ClassName.Location = new System.Drawing.Point(6, 29);
            this.ClassName.MinimumSize = new System.Drawing.Size(0, 30);
            this.ClassName.Name = "ClassName";
            this.ClassName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.ClassName.Size = new System.Drawing.Size(500, 30);
            this.ClassName.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.ClassName.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClassName.StateCommon.ComboBox.Border.Rounding = 2F;
            this.ClassName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.ClassName.TabIndex = 30;
            this.ClassName.SelectionChangeCommitted += new System.EventHandler(this.ClassName_SelectionChangeCommitted);
            // 
            // section_streamType
            // 
            this.section_streamType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.section_streamType.Location = new System.Drawing.Point(6, 16);
            this.section_streamType.MinimumSize = new System.Drawing.Size(0, 30);
            this.section_streamType.Name = "section_streamType";
            this.section_streamType.Size = new System.Drawing.Size(500, 30);
            this.section_streamType.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.section_streamType.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.section_streamType.StateCommon.Border.Rounding = 2F;
            this.section_streamType.TabIndex = 31;
            this.section_streamType.Visible = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(0, -4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(83, 16);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "Stream Name";
            this.kryptonLabel3.Visible = false;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(317, 18);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(80, 25);
            this.previousBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousBtn.StateCommon.Border.Rounding = 1F;
            this.previousBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.TabIndex = 33;
            this.previousBtn.Values.Text = "< Prev";
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(754, 18);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 25);
            this.nextBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StateCommon.Border.Rounding = 1F;
            this.nextBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.TabIndex = 33;
            this.nextBtn.Values.Text = "Next >";
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.kryptonLabel4);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ClassDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 186);
            this.tableLayoutPanel1.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.flowLayoutPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(567, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(559, 87);
            this.panel6.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.ClassName);
            this.panel3.Controls.Add(this.kryptonLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 87);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.kryptonLabel2);
            this.panel4.Controls.Add(this.ClassSection);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(567, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 87);
            this.panel4.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.section_streamType);
            this.panel5.Controls.Add(this.Submit);
            this.panel5.Controls.Add(this.kryptonLabel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 87);
            this.panel5.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.previousBtn);
            this.panel2.Controls.Add(this.btnBetweenPg);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.TotalCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 61);
            this.panel2.TabIndex = 34;
            // 
            // ClassDataGridView
            // 
            this.ClassDataGridView.AllowUserToAddRows = false;
            this.ClassDataGridView.AllowUserToResizeColumns = false;
            this.ClassDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClassDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.ClassDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SchoolIdColumn,
            this.ClassIdColumn,
            this.SectionIdColumn,
            this.StreamIdColumn,
            this.ClassNameColumn,
            this.SectionNameColumn,
            this.StreamNameColumn,
            this.EditColumnButton,
            this.DeleteColumnButton});
            this.ClassDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClassDataGridView.Location = new System.Drawing.Point(17, 264);
            this.ClassDataGridView.Name = "ClassDataGridView";
            this.ClassDataGridView.ReadOnly = true;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ClassDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.ClassDataGridView.Size = new System.Drawing.Size(1115, 406);
            this.ClassDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.ClassDataGridView.TabIndex = 6;
            this.ClassDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassDataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 200;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SchoolIdColumn
            // 
            this.SchoolIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SchoolIdColumn.DataPropertyName = "SchoolId";
            this.SchoolIdColumn.HeaderText = "SchoolId";
            this.SchoolIdColumn.MinimumWidth = 200;
            this.SchoolIdColumn.Name = "SchoolIdColumn";
            this.SchoolIdColumn.ReadOnly = true;
            this.SchoolIdColumn.Visible = false;
            // 
            // ClassIdColumn
            // 
            this.ClassIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassIdColumn.DataPropertyName = "ClassId";
            this.ClassIdColumn.HeaderText = "ClassId";
            this.ClassIdColumn.MinimumWidth = 200;
            this.ClassIdColumn.Name = "ClassIdColumn";
            this.ClassIdColumn.ReadOnly = true;
            this.ClassIdColumn.Visible = false;
            // 
            // SectionIdColumn
            // 
            this.SectionIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionIdColumn.DataPropertyName = "SectionId";
            this.SectionIdColumn.HeaderText = "SectionId";
            this.SectionIdColumn.MinimumWidth = 200;
            this.SectionIdColumn.Name = "SectionIdColumn";
            this.SectionIdColumn.ReadOnly = true;
            this.SectionIdColumn.Visible = false;
            // 
            // StreamIdColumn
            // 
            this.StreamIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamIdColumn.DataPropertyName = "StreamId";
            this.StreamIdColumn.HeaderText = "StreamId";
            this.StreamIdColumn.MinimumWidth = 200;
            this.StreamIdColumn.Name = "StreamIdColumn";
            this.StreamIdColumn.ReadOnly = true;
            this.StreamIdColumn.Visible = false;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassNameColumn.DataPropertyName = "ClassName";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassNameColumn.DefaultCellStyle = dataGridViewCellStyle27;
            this.ClassNameColumn.HeaderText = "ClassName";
            this.ClassNameColumn.MinimumWidth = 200;
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            // 
            // SectionNameColumn
            // 
            this.SectionNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectionNameColumn.DataPropertyName = "SectionName";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SectionNameColumn.DefaultCellStyle = dataGridViewCellStyle28;
            this.SectionNameColumn.HeaderText = "SectionName";
            this.SectionNameColumn.MinimumWidth = 200;
            this.SectionNameColumn.Name = "SectionNameColumn";
            this.SectionNameColumn.ReadOnly = true;
            // 
            // StreamNameColumn
            // 
            this.StreamNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StreamNameColumn.DataPropertyName = "StreamName";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StreamNameColumn.DefaultCellStyle = dataGridViewCellStyle29;
            this.StreamNameColumn.HeaderText = "StreamName";
            this.StreamNameColumn.MinimumWidth = 200;
            this.StreamNameColumn.Name = "StreamNameColumn";
            this.StreamNameColumn.ReadOnly = true;
            // 
            // EditColumnButton
            // 
            this.EditColumnButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditColumnButton.HeaderText = "Edit";
            this.EditColumnButton.Image = ((System.Drawing.Image)(resources.GetObject("EditColumnButton.Image")));
            this.EditColumnButton.MinimumWidth = 200;
            this.EditColumnButton.Name = "EditColumnButton";
            this.EditColumnButton.ReadOnly = true;
            this.EditColumnButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteColumnButton.HeaderText = "Delete";
            this.DeleteColumnButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteColumnButton.Image")));
            this.DeleteColumnButton.MinimumWidth = 200;
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.ReadOnly = true;
            this.DeleteColumnButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(18, 214);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(72, 21);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 92;
            this.kryptonLabel4.Values.Text = "Search :";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Search.Location = new System.Drawing.Point(96, 211);
            this.Search.MinimumSize = new System.Drawing.Size(0, 31);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(391, 31);
            this.Search.StateActive.Content.Color1 = System.Drawing.SystemColors.ControlDark;
            this.Search.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Search.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Search.StateCommon.Border.Rounding = 2F;
            this.Search.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Search.StateCommon.Content.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.TabIndex = 91;
            this.Search.Text = "Enter Class Name";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // ClassAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassAcademic";
            this.Text = "ClassAcademic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClassAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassName)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox ClassSection;
        private Krypton.Toolkit.KryptonButton Submit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Krypton.Toolkit.KryptonButton btnPrevious;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private Krypton.Toolkit.KryptonComboBox ClassName;
        private Krypton.Toolkit.KryptonTextBox section_streamType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Krypton.Toolkit.KryptonDataGridView ClassDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamNameColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumnButton;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumnButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox Search;
    }
}