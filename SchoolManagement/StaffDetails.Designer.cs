namespace SchoolManagement
{
    partial class StaffDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Search = new Krypton.Toolkit.KryptonTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.SchoolStaffDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.UserIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffDetailsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolStaffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.SchoolStaffDataGridView);
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 21;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(19, 149);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 21);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 90;
            this.kryptonLabel2.Values.Text = "Search :";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Search.Location = new System.Drawing.Point(97, 146);
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
            this.Search.TabIndex = 89;
            this.Search.Text = "Enter Staff Name";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.previousBtn);
            this.panel7.Controls.Add(this.btnBetweenPg);
            this.panel7.Controls.Add(this.nextBtn);
            this.panel7.Controls.Add(this.TotalCount);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 676);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1149, 61);
            this.panel7.TabIndex = 49;
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
            // btnBetweenPg
            // 
            this.btnBetweenPg.Location = new System.Drawing.Point(463, 19);
            this.btnBetweenPg.Name = "btnBetweenPg";
            this.btnBetweenPg.Size = new System.Drawing.Size(55, 20);
            this.btnBetweenPg.TabIndex = 29;
            this.btnBetweenPg.Values.Text = "Pages: 0";
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
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(609, 19);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 29;
            this.TotalCount.Values.Text = ".";
            // 
            // SchoolStaffDataGridView
            // 
            this.SchoolStaffDataGridView.AllowUserToAddRows = false;
            this.SchoolStaffDataGridView.AllowUserToResizeColumns = false;
            this.SchoolStaffDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SchoolStaffDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SchoolStaffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolStaffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdColumn,
            this.IdColumn,
            this.SchoolIdColumn,
            this.NameColumn,
            this.GenderColumn,
            this.AddressColumn,
            this.ClassNameColumn,
            this.SubjectNameColumn,
            this.DesignationColumn,
            this.StaffDetailsColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.SchoolStaffDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SchoolStaffDataGridView.Location = new System.Drawing.Point(17, 203);
            this.SchoolStaffDataGridView.Name = "SchoolStaffDataGridView";
            this.SchoolStaffDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.SchoolStaffDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.SchoolStaffDataGridView.Size = new System.Drawing.Size(1115, 467);
            this.SchoolStaffDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.SchoolStaffDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.TabIndex = 7;
            this.SchoolStaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolStaffDataGridView_CellClick);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 21);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1115, 97);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton1.Location = new System.Drawing.Point(943, 32);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(109, 33);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Add Record";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Staff Details";
            // 
            // UserIdColumn
            // 
            this.UserIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserIdColumn.HeaderText = "UserId";
            this.UserIdColumn.MinimumWidth = 200;
            this.UserIdColumn.Name = "UserIdColumn";
            this.UserIdColumn.ReadOnly = true;
            this.UserIdColumn.Visible = false;
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 200;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
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
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.DataPropertyName = "FullName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 200;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GenderColumn.DataPropertyName = "Gender";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GenderColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.MinimumWidth = 200;
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AddressColumn.DataPropertyName = "Address";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AddressColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.MinimumWidth = 200;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassNameColumn.DataPropertyName = "ClassId";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClassNameColumn.HeaderText = "Class";
            this.ClassNameColumn.MinimumWidth = 200;
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectNameColumn.DataPropertyName = "SubjectId";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectNameColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.SubjectNameColumn.HeaderText = "Subject";
            this.SubjectNameColumn.MinimumWidth = 200;
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            // 
            // DesignationColumn
            // 
            this.DesignationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DesignationColumn.DataPropertyName = "Designation";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DesignationColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.DesignationColumn.HeaderText = "Designation";
            this.DesignationColumn.MinimumWidth = 200;
            this.DesignationColumn.Name = "DesignationColumn";
            this.DesignationColumn.ReadOnly = true;
            // 
            // StaffDetailsColumn
            // 
            this.StaffDetailsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffDetailsColumn.HeaderText = "Staff Details";
            this.StaffDetailsColumn.MinimumWidth = 200;
            this.StaffDetailsColumn.Name = "StaffDetailsColumn";
            this.StaffDetailsColumn.ReadOnly = true;
            this.StaffDetailsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDetailsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.StaffDetailsColumn.Text = "Staff Details";
            this.StaffDetailsColumn.UseColumnTextForButtonValue = true;
            // 
            // EditColumn
            // 
            this.EditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditColumn.Image")));
            this.EditColumn.MinimumWidth = 200;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteColumn.Image")));
            this.DeleteColumn.MinimumWidth = 200;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolStaffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonDataGridView SchoolStaffDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel7;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationColumn;
        private System.Windows.Forms.DataGridViewButtonColumn StaffDetailsColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
    }
}