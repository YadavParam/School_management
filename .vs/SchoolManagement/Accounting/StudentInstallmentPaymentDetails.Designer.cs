namespace SchoolManagement.Accounting
{
    partial class StudentInstallmentPaymentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.StudentInstallmentRecord = new Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInstallmentRecord)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 35);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(387, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Student Installment Payment Details";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(17, 26);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1115, 97);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 20;
            // 
            // StudentInstallmentRecord
            // 
            this.StudentInstallmentRecord.AllowUserToAddRows = false;
            this.StudentInstallmentRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentInstallmentRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SchoolId,
            this.StudentId,
            this.ClassId,
            this.SectionId,
            this.DateOfInstallment,
            this.DateOfPay,
            this.PaidPayment,
            this.RemainingAmountColumn,
            this.Status,
            this.Submit});
            this.StudentInstallmentRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.StudentInstallmentRecord.Location = new System.Drawing.Point(17, 160);
            this.StudentInstallmentRecord.Name = "StudentInstallmentRecord";
            this.StudentInstallmentRecord.Size = new System.Drawing.Size(1115, 558);
            this.StudentInstallmentRecord.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StudentInstallmentRecord.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StudentInstallmentRecord.TabIndex = 21;
            this.StudentInstallmentRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentInstallmentRecord_CellClick);
            this.StudentInstallmentRecord.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentInstallmentRecord_CellEndEdit);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 161;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // SchoolId
            // 
            this.SchoolId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SchoolId.DefaultCellStyle = dataGridViewCellStyle10;
            this.SchoolId.HeaderText = "SchoolId";
            this.SchoolId.MinimumWidth = 161;
            this.SchoolId.Name = "SchoolId";
            this.SchoolId.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentId.DefaultCellStyle = dataGridViewCellStyle11;
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.MinimumWidth = 161;
            this.StudentId.Name = "StudentId";
            this.StudentId.Visible = false;
            // 
            // ClassId
            // 
            this.ClassId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassId.DefaultCellStyle = dataGridViewCellStyle12;
            this.ClassId.HeaderText = "ClassId";
            this.ClassId.MinimumWidth = 161;
            this.ClassId.Name = "ClassId";
            this.ClassId.Visible = false;
            // 
            // SectionId
            // 
            this.SectionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SectionId.DefaultCellStyle = dataGridViewCellStyle13;
            this.SectionId.HeaderText = "SectionId";
            this.SectionId.MinimumWidth = 161;
            this.SectionId.Name = "SectionId";
            this.SectionId.Visible = false;
            // 
            // DateOfInstallment
            // 
            this.DateOfInstallment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateOfInstallment.DefaultCellStyle = dataGridViewCellStyle14;
            this.DateOfInstallment.HeaderText = "Date Of Installment";
            this.DateOfInstallment.MinimumWidth = 161;
            this.DateOfInstallment.Name = "DateOfInstallment";
            // 
            // DateOfPay
            // 
            this.DateOfPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DateOfPay.DefaultCellStyle = dataGridViewCellStyle15;
            this.DateOfPay.HeaderText = "Date Of Pay";
            this.DateOfPay.MinimumWidth = 161;
            this.DateOfPay.Name = "DateOfPay";
            // 
            // PaidPayment
            // 
            this.PaidPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PaidPayment.DefaultCellStyle = dataGridViewCellStyle16;
            this.PaidPayment.HeaderText = "Paid Payment";
            this.PaidPayment.MinimumWidth = 161;
            this.PaidPayment.Name = "PaidPayment";
            // 
            // RemainingAmountColumn
            // 
            this.RemainingAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RemainingAmountColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.RemainingAmountColumn.HeaderText = "Remaining Amount";
            this.RemainingAmountColumn.MinimumWidth = 161;
            this.RemainingAmountColumn.Name = "RemainingAmountColumn";
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Status.DefaultCellStyle = dataGridViewCellStyle18;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 161;
            this.Status.Name = "Status";
            // 
            // Submit
            // 
            this.Submit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Submit.HeaderText = "Submit";
            this.Submit.MinimumWidth = 161;
            this.Submit.Name = "Submit";
            this.Submit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Submit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.StudentInstallmentRecord);
            this.panel1.Controls.Add(this.kryptonPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 22;
            // 
            // StudentInstallmentPaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentInstallmentPaymentDetails";
            this.Text = "InstallmentDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentInstallmentPaymentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentInstallmentRecord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public Krypton.Toolkit.KryptonDataGridView StudentInstallmentRecord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfInstallment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Submit;
    }
}