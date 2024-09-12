namespace ST10043352_PROG7312_PART_1
{
    partial class ReportPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocationPlaceholder;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEngagement;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBarReport; // Add the ProgressBar

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
            this.lblLocationPlaceholder = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBarReport = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(184, 20);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(279, 20);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TextChanged += new System.EventHandler(this.TxtLocation_TextChanged);
            this.txtLocation.Enter += new System.EventHandler(this.TxtLocation_Enter);
            this.txtLocation.Leave += new System.EventHandler(this.TxtLocation_Leave);
            // 
            // lblLocationPlaceholder
            // 
            this.lblLocationPlaceholder.AutoSize = true;
            this.lblLocationPlaceholder.ForeColor = System.Drawing.Color.Gray;
            this.lblLocationPlaceholder.Location = new System.Drawing.Point(184, 22);
            this.lblLocationPlaceholder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationPlaceholder.Name = "lblLocationPlaceholder";
            this.lblLocationPlaceholder.Size = new System.Drawing.Size(72, 13);
            this.lblLocationPlaceholder.TabIndex = 7;
            this.lblLocationPlaceholder.Text = "Enter location";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(184, 49);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(279, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.Text = "Select category";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(184, 80);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(279, 108);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "Enter detailed description";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Location = new System.Drawing.Point(315, 217);
            this.btnAttachMedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(119, 37);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.BtnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(241, 316);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new System.Drawing.Point(238, 365);
            this.lblEngagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(129, 13);
            this.lblEngagement.TabIndex = 5;
            this.lblEngagement.Text = "Thank you for your report!";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Location = new System.Drawing.Point(182, 217);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(119, 37);
            this.btnBackToMain.TabIndex = 6;
            this.btnBackToMain.Text = "Back to Main Menu";
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.BtnBackToMain_Click);
            // 
            // progressBarReport
            // 
            this.progressBarReport.Location = new System.Drawing.Point(169, 287);
            this.progressBarReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarReport.Name = "progressBarReport";
            this.progressBarReport.Size = new System.Drawing.Size(278, 15);
            this.progressBarReport.Step = 33;
            this.progressBarReport.TabIndex = 8;
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 428);
            this.Controls.Add(this.lblLocationPlaceholder);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.progressBarReport);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportPage";
            this.Text = "Report Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
