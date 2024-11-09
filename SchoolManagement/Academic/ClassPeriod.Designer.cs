using System.Windows.Forms;

namespace SchoolManagement.Academic
{
    partial class ClassPeriod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.PeriodSubmit = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.sectionSelect = new Krypton.Toolkit.KryptonComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teacherSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.classSelect = new Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.period = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 0;
            // 
            // DurationColumn
            // 
            this.DurationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DurationColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.MinimumWidth = 120;
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimingToColumn
            // 
            this.TimingToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TimingToColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.TimingToColumn.HeaderText = "Timing To";
            this.TimingToColumn.MinimumWidth = 130;
            this.TimingToColumn.Name = "TimingToColumn";
            this.TimingToColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimingFromColumn
            // 
            this.TimingFromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TimingFromColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.TimingFromColumn.HeaderText = "Timing From";
            this.TimingFromColumn.MinimumWidth = 130;
            this.TimingFromColumn.Name = "TimingFromColumn";
            this.TimingFromColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TeacherNameColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.TeacherNameColumn.HeaderText = "Teacher Name";
            this.TeacherNameColumn.MinimumWidth = 161;
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.SubjectColumn.HeaderText = "Subject";
            this.SubjectColumn.MinimumWidth = 140;
            this.SubjectColumn.Name = "SubjectColumn";
            this.SubjectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PeriodColumn
            // 
            this.PeriodColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PeriodColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.PeriodColumn.HeaderText = "Period";
            this.PeriodColumn.MinimumWidth = 120;
            this.PeriodColumn.Name = "PeriodColumn";
            this.PeriodColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 161;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // PeriodDataGridView
            // 
            this.PeriodDataGridView.AllowUserToAddRows = false;
            this.PeriodDataGridView.AllowUserToResizeColumns = false;
            this.PeriodDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            this.PeriodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.PeriodDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodDataGridView.ColumnHeadersHeight = 25;
            this.PeriodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.PeriodColumn,
            this.SubjectColumn,
            this.TeacherNameColumn,
            this.TimingFromColumn,
            this.TimingToColumn,
            this.DurationColumn});
            this.PeriodDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PeriodDataGridView.Location = new System.Drawing.Point(17, 200);
            this.PeriodDataGridView.Name = "PeriodDataGridView";
            this.PeriodDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.PeriodDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.PeriodDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PeriodDataGridView.Size = new System.Drawing.Size(1115, 449);
            this.PeriodDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.PeriodDataGridView.TabIndex = 6;
            this.PeriodDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodDataGridView_CellClick);
            this.PeriodDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodDataGridView_CellValueChanged);
            // 
            // PeriodSubmit
            // 
            this.PeriodSubmit.Location = new System.Drawing.Point(17, 9);
            this.PeriodSubmit.Name = "PeriodSubmit";
            this.PeriodSubmit.Size = new System.Drawing.Size(107, 33);
            this.PeriodSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.PeriodSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PeriodSubmit.StateCommon.Border.Rounding = 2F;
            this.PeriodSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeriodSubmit.TabIndex = 42;
            this.PeriodSubmit.Values.Text = "Submit ";
            this.PeriodSubmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.PeriodSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 70);
            this.panel1.TabIndex = 44;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.kryptonLabel5);
            this.panel5.Controls.Add(this.period);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(567, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 85);
            this.panel5.TabIndex = 49;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(49, 3);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(76, 16);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 41;
            this.kryptonLabel5.Values.Text = "Total Period";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.sectionSelect);
            this.panel4.Controls.Add(this.kryptonLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(567, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 85);
            this.panel4.TabIndex = 48;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(49, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 37;
            this.kryptonLabel2.Values.Text = "Section";
            // 
            // sectionSelect
            // 
            this.sectionSelect.AllowDrop = true;
            this.sectionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sectionSelect.DropDownHeight = 130;
            this.sectionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionSelect.DropDownWidth = 273;
            this.sectionSelect.IntegralHeight = false;
            this.sectionSelect.Location = new System.Drawing.Point(53, 30);
            this.sectionSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.sectionSelect.Name = "sectionSelect";
            this.sectionSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.sectionSelect.Size = new System.Drawing.Size(500, 30);
            this.sectionSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.sectionSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sectionSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.sectionSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.sectionSelect.TabIndex = 33;
            this.sectionSelect.Tag = "";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.kryptonLabel4);
            this.panel3.Controls.Add(this.teacherSelect);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 85);
            this.panel3.TabIndex = 47;
            // 
            // teacherSelect
            // 
            this.teacherSelect.AllowDrop = true;
            this.teacherSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.teacherSelect.DropDownHeight = 130;
            this.teacherSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherSelect.DropDownWidth = 273;
            this.teacherSelect.IntegralHeight = false;
            this.teacherSelect.Location = new System.Drawing.Point(3, 25);
            this.teacherSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.teacherSelect.Name = "teacherSelect";
            this.teacherSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.teacherSelect.Size = new System.Drawing.Size(500, 30);
            this.teacherSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.teacherSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.teacherSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.teacherSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.teacherSelect.TabIndex = 34;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(-1, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 16);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 38;
            this.kryptonLabel4.Values.Text = "Class Teacher";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.classSelect);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 85);
            this.panel2.TabIndex = 46;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(-1, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 40;
            this.kryptonLabel1.Values.Text = "Class";
            // 
            // classSelect
            // 
            this.classSelect.AllowDrop = true;
            this.classSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.classSelect.DropDownHeight = 130;
            this.classSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelect.DropDownWidth = 273;
            this.classSelect.IntegralHeight = false;
            this.classSelect.Location = new System.Drawing.Point(3, 30);
            this.classSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.classSelect.Name = "classSelect";
            this.classSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.classSelect.Size = new System.Drawing.Size(500, 30);
            this.classSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.classSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.classSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.classSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.classSelect.TabIndex = 36;
            this.classSelect.SelectedIndexChanged += new System.EventHandler(this.classSelect_SelectedIndexChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1128, 182);
            this.tableLayoutPanel1.TabIndex = 45;
            // 
            // period
            // 
            this.period.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.period.Location = new System.Drawing.Point(53, 23);
            this.period.MinimumSize = new System.Drawing.Size(0, 30);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(500, 30);
            this.period.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.period.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.period.StateCommon.Border.Rounding = 2F;
            this.period.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.TabIndex = 43;
            this.period.KeyUp += new System.Windows.Forms.KeyEventHandler(this.period_KeyUp);
            // 
            // ClassPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PeriodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassPeriod";
            this.Text = "ClassPeriod";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClassPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker dtp;
        private DataGridViewTextBoxColumn DurationColumn;
        private DataGridViewTextBoxColumn TimingToColumn;
        private DataGridViewTextBoxColumn TimingFromColumn;
        private DataGridViewComboBoxColumn TeacherNameColumn;
        private DataGridViewComboBoxColumn SubjectColumn;
        private DataGridViewTextBoxColumn PeriodColumn;
        private DataGridViewTextBoxColumn IdColumn;
        public Krypton.Toolkit.KryptonDataGridView PeriodDataGridView;
        public Krypton.Toolkit.KryptonButton PeriodSubmit;
        private Panel panel1;
        private Panel panel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public Krypton.Toolkit.KryptonTextBox period;
        private Panel panel4;
        public Krypton.Toolkit.KryptonComboBox sectionSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Panel panel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public Krypton.Toolkit.KryptonComboBox teacherSelect;
        private Panel panel2;
        public Krypton.Toolkit.KryptonComboBox classSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}