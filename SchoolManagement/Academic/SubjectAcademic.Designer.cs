namespace SchoolManagement
{
    partial class SubjectAcademic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectAcademic));
            this.SelectClasses = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SubjectName = new Krypton.Toolkit.KryptonTextBox();
            this.SubjectDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.SubjectSubmit = new Krypton.Toolkit.KryptonButton();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubjectIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButtonColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectClasses
            // 
            this.SelectClasses.AllowDrop = true;
            this.SelectClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectClasses.DropDownHeight = 180;
            this.SelectClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectClasses.DropDownWidth = 273;
            this.SelectClasses.IntegralHeight = false;
            this.SelectClasses.Location = new System.Drawing.Point(3, 25);
            this.SelectClasses.MinimumSize = new System.Drawing.Size(0, 30);
            this.SelectClasses.Name = "SelectClasses";
            this.SelectClasses.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.SelectClasses.Size = new System.Drawing.Size(516, 30);
            this.SelectClasses.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.SelectClasses.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SelectClasses.StateCommon.ComboBox.Border.Rounding = 2F;
            this.SelectClasses.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectClasses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.SelectClasses.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(-2, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(86, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Select a Class";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(28, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Subject Name";
            // 
            // SubjectName
            // 
            this.SubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectName.Location = new System.Drawing.Point(34, 25);
            this.SubjectName.MinimumSize = new System.Drawing.Size(0, 30);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(516, 30);
            this.SubjectName.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.SubjectName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubjectName.StateCommon.Border.Rounding = 2F;
            this.SubjectName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName.TabIndex = 6;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.AllowUserToAddRows = false;
            this.SubjectDataGridView.AllowUserToResizeColumns = false;
            this.SubjectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectIdColumn,
            this.SelectClassColumn,
            this.SubjectNameColumn,
            this.EditButtonColumn,
            this.DeleteButtonColumn});
            this.SubjectDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubjectDataGridView.Location = new System.Drawing.Point(17, 186);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.SubjectDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectDataGridView.Size = new System.Drawing.Size(1115, 484);
            this.SubjectDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.SubjectDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.SubjectDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.SubjectDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.SubjectDataGridView.TabIndex = 29;
            this.SubjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectDataGridView_CellClick);
            // 
            // SubjectSubmit
            // 
            this.SubjectSubmit.Location = new System.Drawing.Point(17, 105);
            this.SubjectSubmit.Name = "SubjectSubmit";
            this.SubjectSubmit.Size = new System.Drawing.Size(107, 32);
            this.SubjectSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.SubjectSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubjectSubmit.StateCommon.Border.Rounding = 2F;
            this.SubjectSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectSubmit.TabIndex = 30;
            this.SubjectSubmit.Values.Text = "Submit";
            this.SubjectSubmit.Click += new System.EventHandler(this.SubjectSubmit_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previousBtn.Location = new System.Drawing.Point(317, 18);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(80, 25);
            this.previousBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousBtn.StateCommon.Border.Rounding = 1F;
            this.previousBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.TabIndex = 34;
            this.previousBtn.Values.Text = "< Prev";
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextBtn.Location = new System.Drawing.Point(754, 18);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 25);
            this.nextBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StateCommon.Border.Rounding = 1F;
            this.nextBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.TabIndex = 37;
            this.nextBtn.Values.Text = "Next >";
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // TotalCount
            // 
            this.TotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalCount.Location = new System.Drawing.Point(609, 19);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 35;
            this.TotalCount.Values.Text = ".";
            // 
            // btnBetweenPg
            // 
            this.btnBetweenPg.Location = new System.Drawing.Point(463, 19);
            this.btnBetweenPg.Name = "btnBetweenPg";
            this.btnBetweenPg.Size = new System.Drawing.Size(55, 20);
            this.btnBetweenPg.TabIndex = 36;
            this.btnBetweenPg.Values.Text = "Pages: 0";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SubjectDataGridView);
            this.panel1.Controls.Add(this.SubjectSubmit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 38;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 73);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SubjectName);
            this.panel4.Controls.Add(this.kryptonLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(563, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 67);
            this.panel4.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SelectClasses);
            this.panel3.Controls.Add(this.kryptonLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 67);
            this.panel3.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.previousBtn);
            this.panel2.Controls.Add(this.btnBetweenPg);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.TotalCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 61);
            this.panel2.TabIndex = 38;
            // 
            // SubjectIdColumn
            // 
            this.SubjectIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectIdColumn.DataPropertyName = "SubjectId";
            this.SubjectIdColumn.HeaderText = "SubjectId";
            this.SubjectIdColumn.MinimumWidth = 170;
            this.SubjectIdColumn.Name = "SubjectIdColumn";
            this.SubjectIdColumn.ReadOnly = true;
            this.SubjectIdColumn.Visible = false;
            // 
            // SelectClassColumn
            // 
            this.SelectClassColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SelectClassColumn.DataPropertyName = "ClassName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SelectClassColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectClassColumn.HeaderText = "Class";
            this.SelectClassColumn.MinimumWidth = 170;
            this.SelectClassColumn.Name = "SelectClassColumn";
            this.SelectClassColumn.ReadOnly = true;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectNameColumn.DataPropertyName = "SubjectName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubjectNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectNameColumn.HeaderText = "Subject Name";
            this.SubjectNameColumn.MinimumWidth = 170;
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            // 
            // EditButtonColumn
            // 
            this.EditButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditButtonColumn.HeaderText = "Edit";
            this.EditButtonColumn.Image = ((System.Drawing.Image)(resources.GetObject("EditButtonColumn.Image")));
            this.EditButtonColumn.MinimumWidth = 170;
            this.EditButtonColumn.Name = "EditButtonColumn";
            this.EditButtonColumn.ReadOnly = true;
            this.EditButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteButtonColumn
            // 
            this.DeleteButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteButtonColumn.HeaderText = "Delete";
            this.DeleteButtonColumn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonColumn.Image")));
            this.DeleteButtonColumn.MinimumWidth = 170;
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.ReadOnly = true;
            this.DeleteButtonColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SubjectAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectAcademic";
            this.Text = "SubjectAcademic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubjectAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox SelectClasses;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox SubjectName;
        private Krypton.Toolkit.KryptonDataGridView SubjectDataGridView;
        private Krypton.Toolkit.KryptonButton SubjectSubmit;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditButtonColumn;
        private System.Windows.Forms.DataGridViewImageColumn DeleteButtonColumn;
    }
}