using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class IssueDetailsForm : Form
    {
        private Issue issue;

        public IssueDetailsForm(Issue issue)
        {
            InitializeComponent();
            this.issue = issue;
            DisplayIssueDetails();
        }

        private void DisplayIssueDetails()
        {
            lblLocation.Text = $"Location: {issue.Location}";
            lblCategory.Text = $"Category: {issue.Category}";
            txtDescription.Text = issue.Description;

            // Display images
            foreach (var imagePath in issue.MediaFilePaths)
            {
                if (File.Exists(imagePath))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imagePath),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Width = 200,
                        Height = 150,
                        Margin = new Padding(5)
                    };
                    flowLayoutPanelImages.Controls.Add(pictureBox);
                }
            }
        }
    }
}
