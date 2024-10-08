namespace ST10043352_PROG7312_PART_1
{
    partial class IssuesListForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewIssues;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnMedia;

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
            this.listViewIssues = new System.Windows.Forms.ListView();
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMedia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewIssues
            // 
            this.listViewIssues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLocation,
            this.columnCategory,
            this.columnDescription,
            this.columnMedia});
            this.listViewIssues.FullRowSelect = true;
            this.listViewIssues.GridLines = true;
            this.listViewIssues.HideSelection = false;
            this.listViewIssues.Location = new System.Drawing.Point(12, 12);
            this.listViewIssues.Name = "listViewIssues";
            this.listViewIssues.Size = new System.Drawing.Size(760, 437);
            this.listViewIssues.TabIndex = 0;
            this.listViewIssues.UseCompatibleStateImageBehavior = false;
            this.listViewIssues.View = System.Windows.Forms.View.Details;
            this.listViewIssues.DoubleClick += new System.EventHandler(this.listViewIssues_DoubleClick);
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.Width = 150;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 100;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 300;
            // 
            // columnMedia
            // 
            this.columnMedia.Text = "Media Files";
            this.columnMedia.Width = 200;
            // 
            // IssuesListForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listViewIssues);
            this.Name = "IssuesListForm";
            this.Text = "Submitted Issues";
            this.ResumeLayout(false);

        }
    }
}
