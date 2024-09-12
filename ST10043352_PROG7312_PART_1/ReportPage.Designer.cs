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
        private System.Windows.Forms.Label lblDescriptionPlaceholder;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Label lblReportIssue;

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
            this.lblDescriptionPlaceholder = new System.Windows.Forms.Label();
            this.btnViewImage = new System.Windows.Forms.Button();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.lblReportIssue = new System.Windows.Forms.Label();
            this.btnViewImage.Click += new System.EventHandler(this.BtnViewImage_Click);
            this.btnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);


            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(276, 92);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(416, 26);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.TxtLocation_TextChanged);
            this.txtLocation.Enter += new System.EventHandler(this.TxtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.TxtLocation_Leave);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(276, 141);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(416, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(276, 201);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(416, 164);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Location = new System.Drawing.Point(743, 193);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(180, 42);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.BtnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(543, 498);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 57);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new System.Drawing.Point(380, 466);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(189, 20);
            this.lblEngagement.TabIndex = 5;
            this.lblEngagement.Text = "Thank you for your report!";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(226, 498);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(178, 57);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // progressBarReport
            // 
            this.progressBarReport.Location = new System.Drawing.Point(275, 382);
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(417, 23);
            this.progressBarReport.Step = 1;
            this.progressBarReport.TabIndex = 8;
            // 
            // lblDescriptionPlaceholder
            // 
            this.lblDescriptionPlaceholder.AutoSize = true;
            this.lblDescriptionPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblDescriptionPlaceholder.Location = new System.Drawing.Point(287, 215);
            this.lblDescriptionPlaceholder.Name = "lblDescriptionPlaceholder";
            this.lblDescriptionPlaceholder.Size = new System.Drawing.Size(288, 20);
            this.lblDescriptionPlaceholder.TabIndex = 10;
            this.lblDescriptionPlaceholder.Text = "Enter a detailed description of the issue";
            this.lblDescriptionPlaceholder.Visible = false;
            // 
            // btnViewImage
            // 
            this.btnViewImage.Location = new System.Drawing.Point(743, 252);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(180, 40);
            this.btnViewImage.TabIndex = 11;
            this.btnViewImage.Text = "View Image";
            this.btnViewImage.UseVisualStyleBackColor = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(743, 311);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(180, 42);
            this.btnRemoveImage.TabIndex = 13;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            // 
            // lblReportIssue
            // 
            this.lblReportIssue.Location = new System.Drawing.Point(351, 31);
            this.lblReportIssue.Name = "lblReportIssue";
            this.lblReportIssue.Size = new System.Drawing.Size(229, 43);
            this.lblReportIssue.TabIndex = 12;
            this.lblReportIssue.Text = "Report an Issue";
            this.lblReportIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 658);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.lblReportIssue);
            this.Controls.Add(this.btnViewImage);
            this.Controls.Add(this.lblDescriptionPlaceholder);
            this.Controls.Add(this.progressBarReport);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.btnBackToMain);

            this.Name = "ReportPage";
            this.Text = "Report Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
