namespace ST10043352_PROG7312_PART_1
{
    partial class ReportPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBarReport;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label lblReportIssue;
        private System.Windows.Forms.Label lblRateExperience;
        private System.Windows.Forms.Button btnUpvote;
        private System.Windows.Forms.Button btnDownvote;
        private System.Windows.Forms.Button btnViewIssues; // New Button: View All Issues

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBarReport = new System.Windows.Forms.ProgressBar();
            this.btnViewImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.lblReportIssue = new System.Windows.Forms.Label();
            this.lblRateExperience = new System.Windows.Forms.Label();
            this.btnUpvote = new System.Windows.Forms.Button();
            this.btnDownvote = new System.Windows.Forms.Button();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(275, 108);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(416, 26);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.TxtLocation_TextChanged);
            this.txtLocation.Enter += new System.EventHandler(this.TxtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.TxtLocation_Leave);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(275, 152);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(416, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.ForeColor = System.Drawing.Color.Black;
            this.rtbDescription.Location = new System.Drawing.Point(276, 194);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(416, 164);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttachMedia.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAttachMedia.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnAttachMedia.ForeColor = System.Drawing.Color.Black;
            this.btnAttachMedia.Location = new System.Drawing.Point(217, 16);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(131, 40);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.BtnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(384, 489);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.ForeColor = System.Drawing.Color.Black;
            this.lblEngagement.Location = new System.Drawing.Point(380, 453);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(189, 20);
            this.lblEngagement.TabIndex = 5;
            this.lblEngagement.Text = "Thank you for your report!";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.Salmon;
            this.btnBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnBackToMain.Location = new System.Drawing.Point(14, 15);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(162, 41);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // progressBarReport
            // 
            this.progressBarReport.Location = new System.Drawing.Point(274, 389);
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(417, 23);
            this.progressBarReport.Step = 1;
            this.progressBarReport.TabIndex = 8;
            // 
            // btnViewImage
            // 
            this.btnViewImage.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnViewImage.ForeColor = System.Drawing.Color.Black;
            this.btnViewImage.Location = new System.Drawing.Point(386, 18);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(131, 36);
            this.btnViewImage.TabIndex = 11;
            this.btnViewImage.Text = "View Image";
            this.btnViewImage.UseVisualStyleBackColor = false;
            this.btnViewImage.Click += new System.EventHandler(this.BtnViewImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.Tomato;
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.Location = new System.Drawing.Point(542, 20);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(131, 36);
            this.btnRemoveImage.TabIndex = 13;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // lblReportIssue
            // 
            this.lblReportIssue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblReportIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportIssue.ForeColor = System.Drawing.Color.Black;
            this.lblReportIssue.Location = new System.Drawing.Point(1, -1);
            this.lblReportIssue.Name = "lblReportIssue";
            this.lblReportIssue.Size = new System.Drawing.Size(983, 62);
            this.lblReportIssue.TabIndex = 12;
            this.lblReportIssue.Text = "Report an Issue";
            this.lblReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRateExperience
            // 
            this.lblRateExperience.ForeColor = System.Drawing.Color.Black;
            this.lblRateExperience.Location = new System.Drawing.Point(37, 242);
            this.lblRateExperience.Name = "lblRateExperience";
            this.lblRateExperience.Size = new System.Drawing.Size(177, 30);
            this.lblRateExperience.TabIndex = 0;
            this.lblRateExperience.Text = "Rate this experience:";
            // 
            // btnUpvote
            // 
            this.btnUpvote.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpvote.ForeColor = System.Drawing.Color.White;
            this.btnUpvote.Location = new System.Drawing.Point(8, 275);
            this.btnUpvote.Name = "btnUpvote";
            this.btnUpvote.Size = new System.Drawing.Size(110, 30);
            this.btnUpvote.TabIndex = 1;
            this.btnUpvote.Text = "Upvote";
            this.btnUpvote.UseVisualStyleBackColor = false;
            this.btnUpvote.Click += new System.EventHandler(this.BtnUpvote_Click);
            // 
            // btnDownvote
            // 
            this.btnDownvote.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDownvote.ForeColor = System.Drawing.Color.White;
            this.btnDownvote.Location = new System.Drawing.Point(124, 275);
            this.btnDownvote.Name = "btnDownvote";
            this.btnDownvote.Size = new System.Drawing.Size(107, 30);
            this.btnDownvote.TabIndex = 2;
            this.btnDownvote.Text = "Downvote";
            this.btnDownvote.UseVisualStyleBackColor = false;
            this.btnDownvote.Click += new System.EventHandler(this.BtnDownvote_Click);
            // 
            // btnViewIssues
            // 
            this.btnViewIssues.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnViewIssues.ForeColor = System.Drawing.Color.Black;
            this.btnViewIssues.Location = new System.Drawing.Point(798, 16);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(148, 41);
            this.btnViewIssues.TabIndex = 14;
            this.btnViewIssues.Text = "View All Issues";
            this.btnViewIssues.UseVisualStyleBackColor = false;
            this.btnViewIssues.Click += new System.EventHandler(this.BtnViewIssues_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btnAttachMedia);
            this.panel1.Controls.Add(this.btnViewIssues);
            this.panel1.Controls.Add(this.btnViewImage);
            this.panel1.Controls.Add(this.btnRemoveImage);
            this.panel1.Controls.Add(this.btnBackToMain);
            this.panel1.Location = new System.Drawing.Point(-2, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 73);
            this.panel1.TabIndex = 15;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBarReport);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.lblReportIssue);
            this.Controls.Add(this.lblRateExperience);
            this.Controls.Add(this.btnUpvote);
            this.Controls.Add(this.btnDownvote);
            this.Name = "ReportPage";
            this.Text = "Report Issue";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
    }
}
