namespace SchoolManagement.Accounting
{
    partial class ExpenseManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExpenseSubmit = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ExpenseType = new Krypton.Toolkit.KryptonComboBox();
            this.Amount = new Krypton.Toolkit.KryptonTextBox();
            this.ExpenseCategory = new Krypton.Toolkit.KryptonTextBox();
            this.Date = new Krypton.Toolkit.KryptonDateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ExpenseSubmit);
            this.panel1.Controls.Add(this.kryptonLabel5);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.kryptonLabel4);
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.ExpenseType);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.ExpenseCategory);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 0;
            // 
            // ExpenseSubmit
            // 
            this.ExpenseSubmit.Location = new System.Drawing.Point(89, 476);
            this.ExpenseSubmit.Name = "ExpenseSubmit";
            this.ExpenseSubmit.Size = new System.Drawing.Size(107, 33);
            this.ExpenseSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.ExpenseSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExpenseSubmit.StateCommon.Border.Rounding = 2F;
            this.ExpenseSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseSubmit.TabIndex = 86;
            this.ExpenseSubmit.Values.Text = "Submit ";
            this.ExpenseSubmit.Click += new System.EventHandler(this.ExpenseSubmit_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(84, 65);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(193, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 85;
            this.kryptonLabel5.Values.Text = "Add New Expenses";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(84, 126);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(37, 17);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 84;
            this.kryptonLabel2.Values.Text = "Date";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(84, 388);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(94, 17);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 84;
            this.kryptonLabel4.Values.Text = "Expense Type";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(84, 304);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(57, 17);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 84;
            this.kryptonLabel3.Values.Text = "Amount ";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(84, 213);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(118, 17);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 84;
            this.kryptonLabel1.Values.Text = "Expense Category  ";
            // 
            // ExpenseType
            // 
            this.ExpenseType.AllowButtonSpecToolTips = true;
            this.ExpenseType.AllowDrop = true;
            this.ExpenseType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ExpenseType.DropDownHeight = 150;
            this.ExpenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpenseType.DropDownWidth = 273;
            this.ExpenseType.IntegralHeight = false;
            this.ExpenseType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.ExpenseType.Location = new System.Drawing.Point(89, 410);
            this.ExpenseType.MinimumSize = new System.Drawing.Size(0, 30);
            this.ExpenseType.Name = "ExpenseType";
            this.ExpenseType.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.ExpenseType.Size = new System.Drawing.Size(686, 30);
            this.ExpenseType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.ExpenseType.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.ExpenseType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExpenseType.StateCommon.ComboBox.Border.Rounding = 2F;
            this.ExpenseType.StateCommon.ComboBox.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExpenseType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseType.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(0);
            this.ExpenseType.TabIndex = 83;
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Amount.Location = new System.Drawing.Point(89, 326);
            this.Amount.MinimumSize = new System.Drawing.Size(0, 30);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(686, 30);
            this.Amount.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Amount.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Amount.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Amount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Amount.StateCommon.Border.Rounding = 2F;
            this.Amount.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Amount.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.TabIndex = 82;
            // 
            // ExpenseCategory
            // 
            this.ExpenseCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpenseCategory.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.ExpenseCategory.Location = new System.Drawing.Point(89, 236);
            this.ExpenseCategory.MinimumSize = new System.Drawing.Size(0, 30);
            this.ExpenseCategory.Name = "ExpenseCategory";
            this.ExpenseCategory.Size = new System.Drawing.Size(686, 30);
            this.ExpenseCategory.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.ExpenseCategory.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.ExpenseCategory.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.ExpenseCategory.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ExpenseCategory.StateCommon.Border.Rounding = 2F;
            this.ExpenseCategory.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.ExpenseCategory.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseCategory.TabIndex = 82;
            // 
            // Date
            // 
            this.Date.AllowDrop = true;
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoShift = true;
            this.Date.Location = new System.Drawing.Point(89, 149);
            this.Date.MinimumSize = new System.Drawing.Size(0, 30);
            this.Date.Name = "Date";
            this.Date.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.Date.Size = new System.Drawing.Size(686, 30);
            this.Date.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Date.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Date.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Date.StateCommon.Border.Rounding = 2F;
            this.Date.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Date.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.TabIndex = 81;
            // 
            // ExpenseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseManager";
            this.Text = "ExpenseManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpenseManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonDateTimePicker Date;
        private Krypton.Toolkit.KryptonTextBox ExpenseCategory;
        private Krypton.Toolkit.KryptonComboBox ExpenseType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox Amount;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public Krypton.Toolkit.KryptonButton ExpenseSubmit;
    }
}