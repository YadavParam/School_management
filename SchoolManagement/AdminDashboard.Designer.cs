using System.Windows.Forms;

namespace SchoolManagement
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.menutransition = new System.Windows.Forms.Timer(this.components);
            this.AcedmicTransition = new System.Windows.Forms.Timer(this.components);
            this.AccountingTransition = new System.Windows.Forms.Timer(this.components);
            this.MainDockpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountsOfMonths = new System.Windows.Forms.PictureBox();
            this.AccountsMonthDynamic = new System.Windows.Forms.Label();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ExpensesOfMonthsDataGridView = new System.Windows.Forms.DataGridView();
            this.Expenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExpensesOfMonths = new System.Windows.Forms.PictureBox();
            this.ExpenseMonthDynamic = new System.Windows.Forms.Label();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.AccountsOfMonthDataGridView = new System.Windows.Forms.DataGridView();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LatestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.Students = new System.Windows.Forms.Label();
            this.NoOfStudentsClick = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NoOfStudentsShow = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel7 = new Krypton.Toolkit.KryptonPanel();
            this.EventTitle = new System.Windows.Forms.Label();
            this.NextEventDate = new System.Windows.Forms.Label();
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.RecentEventClick = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            this.Staff = new System.Windows.Forms.Label();
            this.NoOfStaffClick = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NoOfStaffShow = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            this.Parents = new System.Windows.Forms.Label();
            this.NoOfParentsClick = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NoOfParentsShow = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.GoToAttendence = new Krypton.Toolkit.KryptonButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.Teachers = new System.Windows.Forms.Label();
            this.NoOfTeachersClick = new System.Windows.Forms.PictureBox();
            this.NoOfTeachersShow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.MainDockpanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsOfMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesOfMonthsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesOfMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsOfMonthDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStudentsClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).BeginInit();
            this.kryptonPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentEventClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).BeginInit();
            this.kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStaffClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfParentsClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfTeachersClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 0F;
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(248, 123);
            this.kryptonPage1.Text = "kryptonPage1";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "2d9d6ee7887946498f3fa9dc2d2e2c28";
            // 
            // MainDockpanel
            // 
            this.MainDockpanel.AutoSize = true;
            this.MainDockpanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainDockpanel.Controls.Add(this.tableLayoutPanel2);
            this.MainDockpanel.Controls.Add(this.tableLayoutPanel1);
            this.MainDockpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDockpanel.Location = new System.Drawing.Point(0, 0);
            this.MainDockpanel.Name = "MainDockpanel";
            this.MainDockpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainDockpanel.Size = new System.Drawing.Size(1149, 737);
            this.MainDockpanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.25F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ExpensesOfMonthsDataGridView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AccountsOfMonthDataGridView, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 385);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1149, 340);
            this.tableLayoutPanel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AccountsOfMonths);
            this.panel3.Controls.Add(this.AccountsMonthDynamic);
            this.panel3.Controls.Add(this.kryptonLabel2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(586, 26);
            this.panel3.TabIndex = 39;
            // 
            // AccountsOfMonths
            // 
            this.AccountsOfMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountsOfMonths.Image = ((System.Drawing.Image)(resources.GetObject("AccountsOfMonths.Image")));
            this.AccountsOfMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountsOfMonths.Location = new System.Drawing.Point(245, 5);
            this.AccountsOfMonths.Name = "AccountsOfMonths";
            this.AccountsOfMonths.Size = new System.Drawing.Size(30, 30);
            this.AccountsOfMonths.TabIndex = 2;
            this.AccountsOfMonths.TabStop = false;
            this.AccountsOfMonths.Click += new System.EventHandler(this.AccountsOfMonths_Click);
            // 
            // AccountsMonthDynamic
            // 
            this.AccountsMonthDynamic.AutoSize = true;
            this.AccountsMonthDynamic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AccountsMonthDynamic.ForeColor = System.Drawing.Color.Gray;
            this.AccountsMonthDynamic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountsMonthDynamic.Location = new System.Drawing.Point(136, 11);
            this.AccountsMonthDynamic.Name = "AccountsMonthDynamic";
            this.AccountsMonthDynamic.Size = new System.Drawing.Size(68, 19);
            this.AccountsMonthDynamic.TabIndex = 1;
            this.AccountsMonthDynamic.Text = "MONTH";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 10);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(129, 22);
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "ACCOUNTS OF";
            // 
            // ExpensesOfMonthsDataGridView
            // 
            this.ExpensesOfMonthsDataGridView.AllowUserToAddRows = false;
            this.ExpensesOfMonthsDataGridView.AllowUserToDeleteRows = false;
            this.ExpensesOfMonthsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.ExpensesOfMonthsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpensesOfMonthsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesOfMonthsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ExpensesOfMonthsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpensesOfMonthsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpensesOfMonthsDataGridView.ColumnHeadersHeight = 25;
            this.ExpensesOfMonthsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expenses,
            this.Amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesOfMonthsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExpensesOfMonthsDataGridView.EnableHeadersVisualStyles = false;
            this.ExpensesOfMonthsDataGridView.Location = new System.Drawing.Point(769, 37);
            this.ExpensesOfMonthsDataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 18, 3);
            this.ExpensesOfMonthsDataGridView.Name = "ExpensesOfMonthsDataGridView";
            this.ExpensesOfMonthsDataGridView.Size = new System.Drawing.Size(362, 300);
            this.ExpensesOfMonthsDataGridView.TabIndex = 38;
            // 
            // Expenses
            // 
            this.Expenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Expenses.DataPropertyName = "ExpenseCategory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.Expenses.HeaderText = "Expenses";
            this.Expenses.MinimumWidth = 200;
            this.Expenses.Name = "Expenses";
            this.Expenses.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 200;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.ExpensesOfMonths);
            this.panel2.Controls.Add(this.ExpenseMonthDynamic);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Location = new System.Drawing.Point(766, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 26);
            this.panel2.TabIndex = 40;
            // 
            // ExpensesOfMonths
            // 
            this.ExpensesOfMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpensesOfMonths.Image = ((System.Drawing.Image)(resources.GetObject("ExpensesOfMonths.Image")));
            this.ExpensesOfMonths.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesOfMonths.Location = new System.Drawing.Point(227, 5);
            this.ExpensesOfMonths.Name = "ExpensesOfMonths";
            this.ExpensesOfMonths.Size = new System.Drawing.Size(30, 30);
            this.ExpensesOfMonths.TabIndex = 2;
            this.ExpensesOfMonths.TabStop = false;
            this.ExpensesOfMonths.Click += new System.EventHandler(this.ExpensesOfMonths_Click);
            // 
            // ExpenseMonthDynamic
            // 
            this.ExpenseMonthDynamic.AutoSize = true;
            this.ExpenseMonthDynamic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ExpenseMonthDynamic.ForeColor = System.Drawing.Color.Gray;
            this.ExpenseMonthDynamic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpenseMonthDynamic.Location = new System.Drawing.Point(117, 11);
            this.ExpenseMonthDynamic.Name = "ExpenseMonthDynamic";
            this.ExpenseMonthDynamic.Size = new System.Drawing.Size(68, 19);
            this.ExpenseMonthDynamic.TabIndex = 1;
            this.ExpenseMonthDynamic.Text = "MONTH";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(0, 10);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(124, 22);
            this.kryptonLabel3.StateCommon.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "EXPENSES OF";
            // 
            // AccountsOfMonthDataGridView
            // 
            this.AccountsOfMonthDataGridView.AllowUserToAddRows = false;
            this.AccountsOfMonthDataGridView.AllowUserToDeleteRows = false;
            this.AccountsOfMonthDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.AccountsOfMonthDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AccountsOfMonthDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsOfMonthDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AccountsOfMonthDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountsOfMonthDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.AccountsOfMonthDataGridView.ColumnHeadersHeight = 25;
            this.AccountsOfMonthDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolIdColumn,
            this.StudentIdColumn,
            this.SectionIdColumn,
            this.ClassIdColumn,
            this.Student,
            this.Class,
            this.TotalAmount,
            this.TotalPaidAmount,
            this.LatestStatus});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsOfMonthDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.AccountsOfMonthDataGridView.EnableHeadersVisualStyles = false;
            this.AccountsOfMonthDataGridView.Location = new System.Drawing.Point(17, 37);
            this.AccountsOfMonthDataGridView.Margin = new System.Windows.Forms.Padding(17, 3, 13, 3);
            this.AccountsOfMonthDataGridView.Name = "AccountsOfMonthDataGridView";
            this.AccountsOfMonthDataGridView.Size = new System.Drawing.Size(736, 300);
            this.AccountsOfMonthDataGridView.TabIndex = 37;
            // 
            // SchoolIdColumn
            // 
            this.SchoolIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SchoolIdColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.SchoolIdColumn.HeaderText = "SchoolId";
            this.SchoolIdColumn.MinimumWidth = 200;
            this.SchoolIdColumn.Name = "SchoolIdColumn";
            this.SchoolIdColumn.Visible = false;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StudentIdColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.StudentIdColumn.HeaderText = "StudentId";
            this.StudentIdColumn.MinimumWidth = 200;
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.Visible = false;
            // 
            // SectionIdColumn
            // 
            this.SectionIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SectionIdColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.SectionIdColumn.HeaderText = "SectionId";
            this.SectionIdColumn.MinimumWidth = 200;
            this.SectionIdColumn.Name = "SectionIdColumn";
            this.SectionIdColumn.Visible = false;
            // 
            // ClassIdColumn
            // 
            this.ClassIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassIdColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.ClassIdColumn.HeaderText = "ClassId";
            this.ClassIdColumn.MinimumWidth = 200;
            this.ClassIdColumn.Name = "ClassIdColumn";
            this.ClassIdColumn.Visible = false;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Student.DefaultCellStyle = dataGridViewCellStyle12;
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 200;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Class.DefaultCellStyle = dataGridViewCellStyle13;
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 200;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.TotalAmount.HeaderText = "Total amount";
            this.TotalAmount.MinimumWidth = 200;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // TotalPaidAmount
            // 
            this.TotalPaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalPaidAmount.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalPaidAmount.HeaderText = "Total Paid amount";
            this.TotalPaidAmount.MinimumWidth = 200;
            this.TotalPaidAmount.Name = "TotalPaidAmount";
            this.TotalPaidAmount.ReadOnly = true;
            // 
            // LatestStatus
            // 
            this.LatestStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LatestStatus.DefaultCellStyle = dataGridViewCellStyle16;
            this.LatestStatus.HeaderText = "Latest Status";
            this.LatestStatus.MinimumWidth = 200;
            this.LatestStatus.Name = "LatestStatus";
            this.LatestStatus.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 14, 4, 13);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 366);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel1.Controls.Add(this.Students);
            this.kryptonPanel1.Controls.Add(this.NoOfStudentsClick);
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.NoOfStudentsShow);
            this.kryptonPanel1.Controls.Add(this.pictureBox3);
            this.kryptonPanel1.Location = new System.Drawing.Point(16, 17);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kryptonPanel1.Size = new System.Drawing.Size(361, 150);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 33;
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.BackColor = System.Drawing.Color.Transparent;
            this.Students.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Students.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Students.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Students.Location = new System.Drawing.Point(8, 45);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(78, 19);
            this.Students.TabIndex = 5;
            this.Students.Text = "Students";
            // 
            // NoOfStudentsClick
            // 
            this.NoOfStudentsClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoOfStudentsClick.BackColor = System.Drawing.Color.White;
            this.NoOfStudentsClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoOfStudentsClick.Image = ((System.Drawing.Image)(resources.GetObject("NoOfStudentsClick.Image")));
            this.NoOfStudentsClick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfStudentsClick.Location = new System.Drawing.Point(320, 11);
            this.NoOfStudentsClick.Name = "NoOfStudentsClick";
            this.NoOfStudentsClick.Size = new System.Drawing.Size(20, 20);
            this.NoOfStudentsClick.TabIndex = 4;
            this.NoOfStudentsClick.TabStop = false;
            this.NoOfStudentsClick.Click += new System.EventHandler(this.NoOfStudentsClick_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total No.Of Students";
            // 
            // NoOfStudentsShow
            // 
            this.NoOfStudentsShow.AutoSize = true;
            this.NoOfStudentsShow.BackColor = System.Drawing.Color.Transparent;
            this.NoOfStudentsShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.NoOfStudentsShow.ForeColor = System.Drawing.Color.Gray;
            this.NoOfStudentsShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfStudentsShow.Location = new System.Drawing.Point(9, 84);
            this.NoOfStudentsShow.Margin = new System.Windows.Forms.Padding(0);
            this.NoOfStudentsShow.Name = "NoOfStudentsShow";
            this.NoOfStudentsShow.Size = new System.Drawing.Size(18, 19);
            this.NoOfStudentsShow.TabIndex = 2;
            this.NoOfStudentsShow.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(13, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // kryptonPanel7
            // 
            this.kryptonPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel7.Controls.Add(this.EventTitle);
            this.kryptonPanel7.Controls.Add(this.NextEventDate);
            this.kryptonPanel7.Controls.Add(this.uploadPictureBox);
            this.kryptonPanel7.Controls.Add(this.RecentEventClick);
            this.kryptonPanel7.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel7.Location = new System.Drawing.Point(770, 186);
            this.kryptonPanel7.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel7.Name = "kryptonPanel7";
            this.kryptonPanel7.Size = new System.Drawing.Size(362, 150);
            this.kryptonPanel7.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel7.TabIndex = 38;
            // 
            // EventTitle
            // 
            this.EventTitle.AutoSize = true;
            this.EventTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EventTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitle.ForeColor = System.Drawing.Color.DimGray;
            this.EventTitle.Location = new System.Drawing.Point(127, 80);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(0, 15);
            this.EventTitle.TabIndex = 24;
            // 
            // NextEventDate
            // 
            this.NextEventDate.AutoSize = true;
            this.NextEventDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NextEventDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextEventDate.ForeColor = System.Drawing.Color.DimGray;
            this.NextEventDate.Location = new System.Drawing.Point(127, 108);
            this.NextEventDate.Name = "NextEventDate";
            this.NextEventDate.Size = new System.Drawing.Size(0, 15);
            this.NextEventDate.TabIndex = 24;
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.uploadPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureBox.Image")));
            this.uploadPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uploadPictureBox.Location = new System.Drawing.Point(77, 66);
            this.uploadPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(45, 47);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.uploadPictureBox.TabIndex = 23;
            this.uploadPictureBox.TabStop = false;
            // 
            // RecentEventClick
            // 
            this.RecentEventClick.BackColor = System.Drawing.Color.Transparent;
            this.RecentEventClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecentEventClick.Image = ((System.Drawing.Image)(resources.GetObject("RecentEventClick.Image")));
            this.RecentEventClick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RecentEventClick.Location = new System.Drawing.Point(59, 36);
            this.RecentEventClick.Name = "RecentEventClick";
            this.RecentEventClick.Size = new System.Drawing.Size(20, 20);
            this.RecentEventClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RecentEventClick.TabIndex = 23;
            this.RecentEventClick.TabStop = false;
            this.RecentEventClick.Click += new System.EventHandler(this.RecentEventClick_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(133, 24);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Recent Events";
            // 
            // kryptonPanel6
            // 
            this.kryptonPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel6.Controls.Add(this.Staff);
            this.kryptonPanel6.Controls.Add(this.NoOfStaffClick);
            this.kryptonPanel6.Controls.Add(this.label10);
            this.kryptonPanel6.Controls.Add(this.NoOfStaffShow);
            this.kryptonPanel6.Controls.Add(this.pictureBox10);
            this.kryptonPanel6.Location = new System.Drawing.Point(393, 186);
            this.kryptonPanel6.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel6.Name = "kryptonPanel6";
            this.kryptonPanel6.Size = new System.Drawing.Size(361, 150);
            this.kryptonPanel6.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel6.TabIndex = 37;
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.BackColor = System.Drawing.Color.Transparent;
            this.Staff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Staff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Staff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Staff.Location = new System.Drawing.Point(10, 46);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(44, 19);
            this.Staff.TabIndex = 8;
            this.Staff.Text = "Staff";
            // 
            // NoOfStaffClick
            // 
            this.NoOfStaffClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoOfStaffClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoOfStaffClick.Image = ((System.Drawing.Image)(resources.GetObject("NoOfStaffClick.Image")));
            this.NoOfStaffClick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfStaffClick.Location = new System.Drawing.Point(322, 11);
            this.NoOfStaffClick.Name = "NoOfStaffClick";
            this.NoOfStaffClick.Size = new System.Drawing.Size(20, 20);
            this.NoOfStaffClick.TabIndex = 4;
            this.NoOfStaffClick.TabStop = false;
            this.NoOfStaffClick.Click += new System.EventHandler(this.NoOfStaffClick_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total No. Of Staff";
            // 
            // NoOfStaffShow
            // 
            this.NoOfStaffShow.AutoSize = true;
            this.NoOfStaffShow.BackColor = System.Drawing.Color.Transparent;
            this.NoOfStaffShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.NoOfStaffShow.ForeColor = System.Drawing.Color.Gray;
            this.NoOfStaffShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfStaffShow.Location = new System.Drawing.Point(11, 87);
            this.NoOfStaffShow.Margin = new System.Windows.Forms.Padding(0);
            this.NoOfStaffShow.Name = "NoOfStaffShow";
            this.NoOfStaffShow.Size = new System.Drawing.Size(18, 19);
            this.NoOfStaffShow.TabIndex = 2;
            this.NoOfStaffShow.Text = "0";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox10.Location = new System.Drawing.Point(15, 10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel5.Controls.Add(this.Parents);
            this.kryptonPanel5.Controls.Add(this.NoOfParentsClick);
            this.kryptonPanel5.Controls.Add(this.label8);
            this.kryptonPanel5.Controls.Add(this.NoOfParentsShow);
            this.kryptonPanel5.Controls.Add(this.pictureBox8);
            this.kryptonPanel5.Location = new System.Drawing.Point(16, 186);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.kryptonPanel5.Size = new System.Drawing.Size(361, 150);
            this.kryptonPanel5.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel5.TabIndex = 36;
            // 
            // Parents
            // 
            this.Parents.AutoSize = true;
            this.Parents.BackColor = System.Drawing.Color.Transparent;
            this.Parents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Parents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Parents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Parents.Location = new System.Drawing.Point(9, 46);
            this.Parents.Name = "Parents";
            this.Parents.Size = new System.Drawing.Size(68, 19);
            this.Parents.TabIndex = 6;
            this.Parents.Text = "Parents";
            // 
            // NoOfParentsClick
            // 
            this.NoOfParentsClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoOfParentsClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoOfParentsClick.Image = ((System.Drawing.Image)(resources.GetObject("NoOfParentsClick.Image")));
            this.NoOfParentsClick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfParentsClick.Location = new System.Drawing.Point(320, 11);
            this.NoOfParentsClick.Name = "NoOfParentsClick";
            this.NoOfParentsClick.Size = new System.Drawing.Size(20, 20);
            this.NoOfParentsClick.TabIndex = 4;
            this.NoOfParentsClick.TabStop = false;
            this.NoOfParentsClick.Click += new System.EventHandler(this.NoOfParentsClick_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(9, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total No. Of Parents";
            // 
            // NoOfParentsShow
            // 
            this.NoOfParentsShow.AutoSize = true;
            this.NoOfParentsShow.BackColor = System.Drawing.Color.Transparent;
            this.NoOfParentsShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.NoOfParentsShow.ForeColor = System.Drawing.Color.Gray;
            this.NoOfParentsShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfParentsShow.Location = new System.Drawing.Point(9, 87);
            this.NoOfParentsShow.Margin = new System.Windows.Forms.Padding(0);
            this.NoOfParentsShow.Name = "NoOfParentsShow";
            this.NoOfParentsShow.Size = new System.Drawing.Size(18, 19);
            this.NoOfParentsShow.TabIndex = 2;
            this.NoOfParentsShow.Text = "0";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox8.Location = new System.Drawing.Point(13, 10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(30, 30);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel4.Controls.Add(this.GoToAttendence);
            this.kryptonPanel4.Controls.Add(this.label7);
            this.kryptonPanel4.Controls.Add(this.label6);
            this.kryptonPanel4.Controls.Add(this.label5);
            this.kryptonPanel4.Location = new System.Drawing.Point(770, 17);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(362, 150);
            this.kryptonPanel4.StateNormal.Color1 = System.Drawing.Color.CornflowerBlue;
            this.kryptonPanel4.TabIndex = 35;
            // 
            // GoToAttendence
            // 
            this.GoToAttendence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoToAttendence.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoToAttendence.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            this.GoToAttendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToAttendence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoToAttendence.Location = new System.Drawing.Point(20, 98);
            this.GoToAttendence.Name = "GoToAttendence";
            this.GoToAttendence.OverrideDefault.Back.Color1 = System.Drawing.Color.CornflowerBlue;
            this.GoToAttendence.Size = new System.Drawing.Size(318, 32);
            this.GoToAttendence.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.GoToAttendence.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.GoToAttendence.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GoToAttendence.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.GoToAttendence.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToAttendence.TabIndex = 23;
            this.GoToAttendence.Values.Text = "Go to attendance";
            this.GoToAttendence.Click += new System.EventHandler(this.GoToAttendence_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(56, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "STUDENTS ARE ATTENDING TODAY";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(244, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "TODAYS ATTENDANCE";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonPanel3.Controls.Add(this.Teachers);
            this.kryptonPanel3.Controls.Add(this.NoOfTeachersClick);
            this.kryptonPanel3.Controls.Add(this.NoOfTeachersShow);
            this.kryptonPanel3.Controls.Add(this.label1);
            this.kryptonPanel3.Controls.Add(this.pictureBox5);
            this.kryptonPanel3.Location = new System.Drawing.Point(393, 17);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 13, 3);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(361, 150);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel3.TabIndex = 34;
            // 
            // Teachers
            // 
            this.Teachers.AutoSize = true;
            this.Teachers.BackColor = System.Drawing.Color.Transparent;
            this.Teachers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Teachers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Teachers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Teachers.Location = new System.Drawing.Point(8, 45);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(79, 19);
            this.Teachers.TabIndex = 7;
            this.Teachers.Text = "Teachers";
            // 
            // NoOfTeachersClick
            // 
            this.NoOfTeachersClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoOfTeachersClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoOfTeachersClick.Image = ((System.Drawing.Image)(resources.GetObject("NoOfTeachersClick.Image")));
            this.NoOfTeachersClick.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfTeachersClick.Location = new System.Drawing.Point(322, 11);
            this.NoOfTeachersClick.Name = "NoOfTeachersClick";
            this.NoOfTeachersClick.Size = new System.Drawing.Size(20, 20);
            this.NoOfTeachersClick.TabIndex = 6;
            this.NoOfTeachersClick.TabStop = false;
            this.NoOfTeachersClick.Click += new System.EventHandler(this.NoOfTeachersClick_Click);
            // 
            // NoOfTeachersShow
            // 
            this.NoOfTeachersShow.AutoSize = true;
            this.NoOfTeachersShow.BackColor = System.Drawing.Color.Transparent;
            this.NoOfTeachersShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.NoOfTeachersShow.ForeColor = System.Drawing.Color.Gray;
            this.NoOfTeachersShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoOfTeachersShow.Location = new System.Drawing.Point(11, 84);
            this.NoOfTeachersShow.Margin = new System.Windows.Forms.Padding(0);
            this.NoOfTeachersShow.Name = "NoOfTeachersShow";
            this.NoOfTeachersShow.Size = new System.Drawing.Size(18, 19);
            this.NoOfTeachersShow.TabIndex = 5;
            this.NoOfTeachersShow.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total No.Of Teachers";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(15, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.ControlBox = false;
            this.Controls.Add(this.MainDockpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.MainDockpanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsOfMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesOfMonthsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesOfMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsOfMonthDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStudentsClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel7)).EndInit();
            this.kryptonPanel7.ResumeLayout(false);
            this.kryptonPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentEventClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel6)).EndInit();
            this.kryptonPanel6.ResumeLayout(false);
            this.kryptonPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfStaffClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfParentsClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfTeachersClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Timer menutransition;
        private Timer AcedmicTransition;
        private Timer AccountingTransition;
        private Panel MainDockpanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private PictureBox AccountsOfMonths;
        private Label AccountsMonthDynamic;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private DataGridView ExpensesOfMonthsDataGridView;
        private Panel panel2;
        private PictureBox ExpensesOfMonths;
        private Label ExpenseMonthDynamic;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private DataGridView AccountsOfMonthDataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label Students;
        private PictureBox NoOfStudentsClick;
        private Label label3;
        private Label NoOfStudentsShow;
        private PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private PictureBox RecentEventClick;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Label Staff;
        private PictureBox NoOfStaffClick;
        private Label label10;
        private Label NoOfStaffShow;
        private PictureBox pictureBox10;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Label Parents;
        private PictureBox NoOfParentsClick;
        private Label label8;
        private Label NoOfParentsShow;
        private PictureBox pictureBox8;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonButton GoToAttendence;
        private Label label7;
        private Label label6;
        private Label label5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Label Teachers;
        private PictureBox NoOfTeachersClick;
        private Label NoOfTeachersShow;
        private Label label1;
        private PictureBox pictureBox5;
        private Label NextEventDate;
        private Label EventTitle;
        private PictureBox uploadPictureBox;
        private DataGridViewTextBoxColumn Expenses;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn SchoolIdColumn;
        private DataGridViewTextBoxColumn StudentIdColumn;
        private DataGridViewTextBoxColumn SectionIdColumn;
        private DataGridViewTextBoxColumn ClassIdColumn;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn TotalPaidAmount;
        private DataGridViewTextBoxColumn LatestStatus;
    }
}