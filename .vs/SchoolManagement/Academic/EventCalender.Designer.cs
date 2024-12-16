namespace SchoolManagement.Academic
{
    partial class EventCalender
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
            this.EventSubmit = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.EventTitle = new Krypton.Toolkit.KryptonTextBox();
            this.EventStartingDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.EventEndingDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.Summary = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.kryptonLabel3);
            this.panel1.Controls.Add(this.Summary);
            this.panel1.Controls.Add(this.EventSubmit);
            this.panel1.Controls.Add(this.kryptonLabel5);
            this.panel1.Controls.Add(this.kryptonLabel6);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.EventTitle);
            this.panel1.Controls.Add(this.EventEndingDate);
            this.panel1.Controls.Add(this.EventStartingDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 737);
            this.panel1.TabIndex = 0;
            // 
            // EventSubmit
            // 
            this.EventSubmit.Location = new System.Drawing.Point(89, 529);
            this.EventSubmit.Name = "EventSubmit";
            this.EventSubmit.Size = new System.Drawing.Size(119, 33);
            this.EventSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.EventSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EventSubmit.StateCommon.Border.Rounding = 2F;
            this.EventSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSubmit.TabIndex = 96;
            this.EventSubmit.Values.Text = "Save Event";
            this.EventSubmit.Click += new System.EventHandler(this.EventSubmit_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(84, 68);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(155, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 95;
            this.kryptonLabel5.Values.Text = "Add New Event";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(84, 215);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(124, 17);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 91;
            this.kryptonLabel2.Values.Text = "Event Starting Date";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(84, 128);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(73, 17);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 94;
            this.kryptonLabel1.Values.Text = "Event Title";
            // 
            // EventTitle
            // 
            this.EventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTitle.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.EventTitle.Location = new System.Drawing.Point(89, 151);
            this.EventTitle.MinimumSize = new System.Drawing.Size(0, 30);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(686, 30);
            this.EventTitle.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.EventTitle.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.EventTitle.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.EventTitle.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EventTitle.StateCommon.Border.Rounding = 2F;
            this.EventTitle.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.EventTitle.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitle.TabIndex = 89;
            // 
            // EventStartingDate
            // 
            this.EventStartingDate.AllowDrop = true;
            this.EventStartingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventStartingDate.AutoShift = true;
            this.EventStartingDate.Location = new System.Drawing.Point(89, 238);
            this.EventStartingDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.EventStartingDate.Name = "EventStartingDate";
            this.EventStartingDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.EventStartingDate.Size = new System.Drawing.Size(686, 30);
            this.EventStartingDate.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.EventStartingDate.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.EventStartingDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EventStartingDate.StateCommon.Border.Rounding = 2F;
            this.EventStartingDate.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.EventStartingDate.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventStartingDate.TabIndex = 87;
            // 
            // EventEndingDate
            // 
            this.EventEndingDate.AllowDrop = true;
            this.EventEndingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventEndingDate.AutoShift = true;
            this.EventEndingDate.Location = new System.Drawing.Point(89, 327);
            this.EventEndingDate.MinimumSize = new System.Drawing.Size(0, 30);
            this.EventEndingDate.Name = "EventEndingDate";
            this.EventEndingDate.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.EventEndingDate.Size = new System.Drawing.Size(686, 30);
            this.EventEndingDate.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.EventEndingDate.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.EventEndingDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EventEndingDate.StateCommon.Border.Rounding = 2F;
            this.EventEndingDate.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.EventEndingDate.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEndingDate.TabIndex = 87;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(84, 304);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(120, 17);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 91;
            this.kryptonLabel6.Values.Text = "Event Ending Date";
            // 
            // Summary
            // 
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.Location = new System.Drawing.Point(89, 417);
            this.Summary.Multiline = true;
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(686, 74);
            this.Summary.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Summary.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Summary.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Summary.StateCommon.Border.Rounding = 2F;
            this.Summary.StateCommon.Content.Color1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.Summary.TabIndex = 97;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(84, 394);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(104, 17);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 98;
            this.kryptonLabel3.Values.Text = "Event Summary";
            // 
            // EventCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1149, 737);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventCalender";
            this.Text = "EventCalender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EventCalender_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Krypton.Toolkit.KryptonButton EventSubmit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox EventTitle;
        private Krypton.Toolkit.KryptonDateTimePicker EventStartingDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonDateTimePicker EventEndingDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox Summary;
    }
}