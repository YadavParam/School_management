namespace SchoolManagement.Academic
{
    partial class ViewPeriodsPopUp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ViewPeriodDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPeriodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPeriodDataGridView
            // 
            this.ViewPeriodDataGridView.AllowUserToAddRows = false;
            this.ViewPeriodDataGridView.AllowUserToResizeColumns = false;
            this.ViewPeriodDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ViewPeriodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ViewPeriodDataGridView.ColumnHeadersHeight = 25;
            this.ViewPeriodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.PeriodColumn,
            this.SubjectNameColumn,
            this.TeacherNameColumn,
            this.TimingFromColumn,
            this.TimingToColumn,
            this.DurationColumn});
            this.ViewPeriodDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ViewPeriodDataGridView.Location = new System.Drawing.Point(-1, 0);
            this.ViewPeriodDataGridView.Name = "ViewPeriodDataGridView";
            this.ViewPeriodDataGridView.ReadOnly = true;
            this.ViewPeriodDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ViewPeriodDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ViewPeriodDataGridView.Size = new System.Drawing.Size(603, 439);
            this.ViewPeriodDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ViewPeriodDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ViewPeriodDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.ViewPeriodDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.ViewPeriodDataGridView.TabIndex = 7;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // PeriodColumn
            // 
            this.PeriodColumn.HeaderText = "Period";
            this.PeriodColumn.Name = "PeriodColumn";
            this.PeriodColumn.ReadOnly = true;
            this.PeriodColumn.Width = 130;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.HeaderText = "SubjectName";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            this.SubjectNameColumn.Width = 150;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.HeaderText = "TeacherName";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.ReadOnly = true;
            this.TeacherNameColumn.Width = 150;
            // 
            // TimingFromColumn
            // 
            this.TimingFromColumn.HeaderText = "TimingFrom";
            this.TimingFromColumn.Name = "TimingFromColumn";
            this.TimingFromColumn.ReadOnly = true;
            this.TimingFromColumn.Width = 130;
            // 
            // TimingToColumn
            // 
            this.TimingToColumn.HeaderText = "TimingTo";
            this.TimingToColumn.Name = "TimingToColumn";
            this.TimingToColumn.ReadOnly = true;
            this.TimingToColumn.Width = 130;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.ReadOnly = true;
            this.DurationColumn.Width = 130;
            // 
            // ViewPeriodsPopUp
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(602, 439);
            this.Controls.Add(this.ViewPeriodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPeriodsPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Periods";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewPeriodsPopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPeriodDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonDataGridView ViewPeriodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimingFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimingToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
    }
}