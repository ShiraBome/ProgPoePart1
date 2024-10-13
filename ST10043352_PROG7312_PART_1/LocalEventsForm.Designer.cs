namespace ST10043352_PROG7312_PART_1
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewRecommendations;
        private System.Windows.Forms.ColumnHeader columnRecDate;
        private System.Windows.Forms.ColumnHeader columnRecCategory;
        private System.Windows.Forms.ColumnHeader columnRecTitle;
        private System.Windows.Forms.ColumnHeader columnRecDescription;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnViewAllEvents;
        private System.Windows.Forms.Button btnFavoriteEvent;


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

        private void InitializeComponent()
        {
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewRecommendations = new System.Windows.Forms.ListView();
            this.columnRecDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRecDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnViewAllEvents = new System.Windows.Forms.Button();
            this.btnFavoriteEvent = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // btnFavoriteEvent
            // 
            this.btnFavoriteEvent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFavoriteEvent.Location = new System.Drawing.Point(340, 12);
            this.btnFavoriteEvent.Name = "btnFavoriteEvent";
            this.btnFavoriteEvent.Size = new System.Drawing.Size(150, 35);
            this.btnFavoriteEvent.TabIndex = 9;
            this.btnFavoriteEvent.Text = "Mark as Favorite";
            this.btnFavoriteEvent.UseVisualStyleBackColor = false;
            this.btnFavoriteEvent.Click += new System.EventHandler(this.btnFavoriteEvent_Click);
            // 
            // listViewEvents
            // 
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDate,
            this.columnCategory,
            this.columnTitle,
            this.columnDescription});
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.GridLines = true;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(12, 150);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(760, 200);
            this.listViewEvents.TabIndex = 0;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 100;
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            this.columnCategory.Width = 120;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 200;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 340;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(12, 74);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 28);
            this.cmbCategory.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(218, 76);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(250, 26);
            this.dtpEventDate.TabIndex = 2;
            // 
            // txtKeyword
            // 
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(485, 74);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(150, 26);
            this.txtKeyword.TabIndex = 3;
            this.txtKeyword.Text = "Enter a keyword";  // Set default text
            this.txtKeyword.GotFocus += new System.EventHandler(this.txtKeyword_GotFocus);
            this.txtKeyword.LostFocus += new System.EventHandler(this.txtKeyword_LostFocus);

            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(670, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewRecommendations
            // 
            this.listViewRecommendations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnRecDate,
            this.columnRecCategory,
            this.columnRecTitle,
            this.columnRecDescription});
            this.listViewRecommendations.FullRowSelect = true;
            this.listViewRecommendations.GridLines = true;
            this.listViewRecommendations.HideSelection = false;
            this.listViewRecommendations.Location = new System.Drawing.Point(12, 400);
            this.listViewRecommendations.Name = "listViewRecommendations";
            this.listViewRecommendations.Size = new System.Drawing.Size(760, 200);
            this.listViewRecommendations.TabIndex = 5;
            this.listViewRecommendations.UseCompatibleStateImageBehavior = false;
            this.listViewRecommendations.View = System.Windows.Forms.View.Details;
            // 
            // columnRecDate
            // 
            this.columnRecDate.Text = "Date";
            this.columnRecDate.Width = 100;
            // 
            // columnRecCategory
            // 
            this.columnRecCategory.Text = "Category";
            this.columnRecCategory.Width = 120;
            // 
            // columnRecTitle
            // 
            this.columnRecTitle.Text = "Title";
            this.columnRecTitle.Width = 200;
            // 
            // columnRecDescription
            // 
            this.columnRecDescription.Text = "Description";
            this.columnRecDescription.Width = 340;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.Location = new System.Drawing.Point(12, 120);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(175, 29);
            this.lblEvents.TabIndex = 6;
            this.lblEvents.Text = "List of Events:";
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendations.Location = new System.Drawing.Point(12, 370);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(282, 29);
            this.lblRecommendations.TabIndex = 7;
            this.lblRecommendations.Text = "Recommended Events:";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.Salmon;
            this.btnBackToMain.Location = new System.Drawing.Point(12, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(150, 35);
            this.btnBackToMain.TabIndex = 8;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnViewAllEvents
            // 
            this.btnViewAllEvents.BackColor = System.Drawing.Color.LightGreen;
            this.btnViewAllEvents.Location = new System.Drawing.Point(177, 12);
            this.btnViewAllEvents.Name = "btnViewAllEvents";
            this.btnViewAllEvents.Size = new System.Drawing.Size(150, 35);
            this.btnViewAllEvents.TabIndex = 8;
            this.btnViewAllEvents.Text = "View All Events";
            this.btnViewAllEvents.UseVisualStyleBackColor = false;
            this.btnViewAllEvents.Click += new System.EventHandler(this.btnViewAllEvents_Click);
            // 
            // LocalEventsForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnViewAllEvents);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.listViewRecommendations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.btnFavoriteEvent);

            this.Name = "LocalEventsForm";
            this.Text = "Local Events and Announcements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
