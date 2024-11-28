namespace SchoolManagement.Users
{
    partial class AccountsOfMonthWise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccountsMonthWiseRecord = new Krypton.Toolkit.KryptonDataGridView();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaidAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatestStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Search = new Krypton.Toolkit.KryptonTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsMonthWiseRecord)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.AccountsMonthWiseRecord);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 0;
            // 
            // AccountsMonthWiseRecord
            // 
            this.AccountsMonthWiseRecord.AllowUserToAddRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.White;
            this.AccountsMonthWiseRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.AccountsMonthWiseRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsMonthWiseRecord.ColumnHeadersHeight = 25;
            this.AccountsMonthWiseRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolIdColumn,
            this.StudentIdColumn,
            this.SectionIdColumn,
            this.ClassIdColumn,
            this.StudentColumn,
            this.ClassColumn,
            this.TotalAmountColumn,
            this.TotalPaidAmountColumn,
            this.LatestStatusColumn});
            this.AccountsMonthWiseRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.AccountsMonthWiseRecord.Location = new System.Drawing.Point(17, 202);
            this.AccountsMonthWiseRecord.Name = "AccountsMonthWiseRecord";
            this.AccountsMonthWiseRecord.ReadOnly = true;
            this.AccountsMonthWiseRecord.Size = new System.Drawing.Size(1115, 468);
            this.AccountsMonthWiseRecord.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.AccountsMonthWiseRecord.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.AccountsMonthWiseRecord.TabIndex = 58;
            // 
            // SchoolIdColumn
            // 
            this.SchoolIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SchoolIdColumn.DefaultCellStyle = dataGridViewCellStyle32;
            this.SchoolIdColumn.HeaderText = "SchoolId";
            this.SchoolIdColumn.MinimumWidth = 200;
            this.SchoolIdColumn.Name = "SchoolIdColumn";
            this.SchoolIdColumn.ReadOnly = true;
            this.SchoolIdColumn.Visible = false;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentIdColumn.DefaultCellStyle = dataGridViewCellStyle33;
            this.StudentIdColumn.HeaderText = "StudentId";
            this.StudentIdColumn.MinimumWidth = 200;
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.ReadOnly = true;
            this.StudentIdColumn.Visible = false;
            // 
            // SectionIdColumn
            // 
            this.SectionIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SectionIdColumn.DefaultCellStyle = dataGridViewCellStyle34;
            this.SectionIdColumn.HeaderText = "SectionId";
            this.SectionIdColumn.MinimumWidth = 200;
            this.SectionIdColumn.Name = "SectionIdColumn";
            this.SectionIdColumn.ReadOnly = true;
            this.SectionIdColumn.Visible = false;
            // 
            // ClassIdColumn
            // 
            this.ClassIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassIdColumn.DefaultCellStyle = dataGridViewCellStyle35;
            this.ClassIdColumn.HeaderText = "ClassId";
            this.ClassIdColumn.MinimumWidth = 200;
            this.ClassIdColumn.Name = "ClassIdColumn";
            this.ClassIdColumn.ReadOnly = true;
            this.ClassIdColumn.Visible = false;
            // 
            // StudentColumn
            // 
            this.StudentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentColumn.DefaultCellStyle = dataGridViewCellStyle36;
            this.StudentColumn.HeaderText = "Student";
            this.StudentColumn.MinimumWidth = 200;
            this.StudentColumn.Name = "StudentColumn";
            this.StudentColumn.ReadOnly = true;
            // 
            // ClassColumn
            // 
            this.ClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassColumn.DefaultCellStyle = dataGridViewCellStyle37;
            this.ClassColumn.HeaderText = "Class";
            this.ClassColumn.MinimumWidth = 200;
            this.ClassColumn.Name = "ClassColumn";
            this.ClassColumn.ReadOnly = true;
            // 
            // TotalAmountColumn
            // 
            this.TotalAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalAmountColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.TotalAmountColumn.HeaderText = "Total Amount";
            this.TotalAmountColumn.MinimumWidth = 200;
            this.TotalAmountColumn.Name = "TotalAmountColumn";
            this.TotalAmountColumn.ReadOnly = true;
            // 
            // TotalPaidAmountColumn
            // 
            this.TotalPaidAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalPaidAmountColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.TotalPaidAmountColumn.HeaderText = "Total Paid Amount";
            this.TotalPaidAmountColumn.MinimumWidth = 200;
            this.TotalPaidAmountColumn.Name = "TotalPaidAmountColumn";
            this.TotalPaidAmountColumn.ReadOnly = true;
            // 
            // LatestStatusColumn
            // 
            this.LatestStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LatestStatusColumn.DefaultCellStyle = dataGridViewCellStyle40;
            this.LatestStatusColumn.HeaderText = "Latest Status";
            this.LatestStatusColumn.MinimumWidth = 200;
            this.LatestStatusColumn.Name = "LatestStatusColumn";
            this.LatestStatusColumn.ReadOnly = true;
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
            this.panel7.TabIndex = 57;
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
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 21);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1115, 97);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 56;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(321, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Account\'s Month Wise Details";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 148);
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
            this.Search.Location = new System.Drawing.Point(96, 145);
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
            this.Search.Text = "Enter Student Name";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // AccountsOfMonthWise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsOfMonthWise";
            this.Text = "AccountsOfMonthWise";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountsOfMonthWise_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsMonthWiseRecord)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Krypton.Toolkit.KryptonDataGridView AccountsMonthWiseRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaidAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LatestStatusColumn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Search;
    }
}