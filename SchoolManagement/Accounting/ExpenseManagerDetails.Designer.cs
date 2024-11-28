namespace SchoolManagement.Accounting
{
    partial class ExpenseManagerDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseManagerDetails));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ExpenseManager = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ExpensesRecord = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Search = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesRecord)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.ExpenseManager);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 19);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1115, 97);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 21;
            // 
            // ExpenseManager
            // 
            this.ExpenseManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExpenseManager.Location = new System.Drawing.Point(924, 32);
            this.ExpenseManager.Name = "ExpenseManager";
            this.ExpenseManager.Size = new System.Drawing.Size(147, 33);
            this.ExpenseManager.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.ExpenseManager.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseManager.TabIndex = 1;
            this.ExpenseManager.Values.Text = "Add New Expenses";
            this.ExpenseManager.Click += new System.EventHandler(this.ExpenseManager_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 33);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(179, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Expense Details";
            // 
            // ExpensesRecord
            // 
            this.ExpensesRecord.AllowUserToAddRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.White;
            this.ExpensesRecord.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.ExpensesRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesRecord.ColumnHeadersHeight = 25;
            this.ExpensesRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.SchoolIdColumn,
            this.DateColumn,
            this.ExpenseCategoryColumn,
            this.AmountColumn,
            this.ExpenseTypeColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.ExpensesRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ExpensesRecord.Location = new System.Drawing.Point(17, 200);
            this.ExpensesRecord.Name = "ExpensesRecord";
            this.ExpensesRecord.ReadOnly = true;
            this.ExpensesRecord.Size = new System.Drawing.Size(1115, 470);
            this.ExpensesRecord.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ExpensesRecord.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ExpensesRecord.TabIndex = 20;
            this.ExpensesRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpensesRecord_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdColumn.DataPropertyName = "Id";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdColumn.DefaultCellStyle = dataGridViewCellStyle37;
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
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SchoolIdColumn.DefaultCellStyle = dataGridViewCellStyle38;
            this.SchoolIdColumn.HeaderText = "SchoolId";
            this.SchoolIdColumn.MinimumWidth = 200;
            this.SchoolIdColumn.Name = "SchoolIdColumn";
            this.SchoolIdColumn.ReadOnly = true;
            this.SchoolIdColumn.Visible = false;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateColumn.DataPropertyName = "Date";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateColumn.DefaultCellStyle = dataGridViewCellStyle39;
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.MinimumWidth = 200;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            // 
            // ExpenseCategoryColumn
            // 
            this.ExpenseCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpenseCategoryColumn.DataPropertyName = "ExpenseCategory";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExpenseCategoryColumn.DefaultCellStyle = dataGridViewCellStyle40;
            this.ExpenseCategoryColumn.HeaderText = "Expense Category";
            this.ExpenseCategoryColumn.MinimumWidth = 200;
            this.ExpenseCategoryColumn.Name = "ExpenseCategoryColumn";
            this.ExpenseCategoryColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AmountColumn.DefaultCellStyle = dataGridViewCellStyle41;
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 200;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // ExpenseTypeColumn
            // 
            this.ExpenseTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExpenseTypeColumn.DataPropertyName = "ExpenseType";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExpenseTypeColumn.DefaultCellStyle = dataGridViewCellStyle42;
            this.ExpenseTypeColumn.HeaderText = "Expense Type";
            this.ExpenseTypeColumn.MinimumWidth = 200;
            this.ExpenseTypeColumn.Name = "ExpenseTypeColumn";
            this.ExpenseTypeColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditColumn.Image")));
            this.EditColumn.MinimumWidth = 150;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Width = 150;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteColumn.Image")));
            this.DeleteColumn.MinimumWidth = 150;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteColumn.Width = 150;
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
            this.panel7.TabIndex = 51;
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
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click_1);
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
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click_1);
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(609, 19);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 29;
            this.TotalCount.Values.Text = ".";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(21, 147);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(72, 21);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 86;
            this.kryptonLabel2.Values.Text = "Search :";
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Search.Location = new System.Drawing.Point(99, 144);
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
            this.Search.TabIndex = 85;
            this.Search.Text = "Enter Expense Category";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            this.Search.Enter += new System.EventHandler(this.Search_Enter);
            this.Search.Leave += new System.EventHandler(this.Search_Leave);
            // 
            // ExpenseManagerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.ExpensesRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseManagerDetails";
            this.Text = "ExpenseManagerDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpenseManagerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesRecord)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ExpenseManager;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Krypton.Toolkit.KryptonDataGridView ExpensesRecord;
        private System.Windows.Forms.Panel panel7;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseTypeColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteColumn;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Search;
    }
}