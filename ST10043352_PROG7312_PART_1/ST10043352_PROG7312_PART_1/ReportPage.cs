using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class ReportPage : Form
    {
        private List<Issue> issues = new List<Issue>(); // This list stores the user-reported issues.

        public ReportPage()
        {
            InitializeComponent();

        }

        // When user enters the location text field
        private void TxtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Enter location")
            {
                txtLocation.Text = "";
                txtLocation.ForeColor = System.Drawing.Color.Black;
            }
        }

        // When user leaves the location text field
        private void TxtLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                txtLocation.Text = "Enter location";
                txtLocation.ForeColor = System.Drawing.Color.Gray;
            }
        }

        // Update progress when the location is changed
        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            lblLocationPlaceholder.Visible = string.IsNullOrEmpty(txtLocation.Text);
            UpdateProgress(); // Update progress bar when location is entered
        }

        // Update progress when the category is selected
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress(); // Update progress bar when category is selected
        }

        // Update progress when the description is changed
        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress(); // Update progress bar when description is entered
        }

        // Handle media attachment
        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Handle file attachment logic here
                MessageBox.Show("File attached: " + openFileDialog.FileName);
            }
        }

        // Submit the issue and add to the list
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Create a new issue object and add it to the issues list
                string location = txtLocation.Text;
                string category = cmbCategory.SelectedItem.ToString();
                string description = rtbDescription.Text;
                string mediaFilePath = openFileDialog.FileName;

                Issue newIssue = new Issue(location, category, description, mediaFilePath);
                AddIssue(newIssue); // Add the issue to the list

                MessageBox.Show("Your issue has been submitted!");

                // Clear the form fields
                ClearForm();

                // Reset the progress bar after submission
                progressBarReport.Value = 0;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        // Validate the input before submitting the issue
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || txtLocation.Text == "Enter location")
                return false;
            if (cmbCategory.SelectedIndex == -1)
                return false;
            if (string.IsNullOrWhiteSpace(rtbDescription.Text) || rtbDescription.Text == "Enter detailed description")
                return false;
            return true;
        }

        // Add issue to the list and log it (could be used to store to a file or database in the future)
        private void AddIssue(Issue newIssue)
        {
            issues.Add(newIssue);
            LogIssue(newIssue); // Optional: Log issue for debugging or persistence
        }

        // Log issue (for debugging purposes)
        private void LogIssue(Issue issue)
        {
            Console.WriteLine(issue.ToString());
        }

        // Clear the form after submission
        private void ClearForm()
        {
            txtLocation.Text = "Enter location";
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Text = "Enter detailed description";
            lblLocationPlaceholder.Visible = true;
        }

        // View the issues (could be a future feature where the user can view their reported issues)
        public void ViewIssues()
        {
            foreach (var issue in issues)
            {
                Console.WriteLine(issue.ToString());
            }
        }

        // Navigate back to the main menu
        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.Show();
        }

        // Update the progress bar based on filled fields
        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text != "Enter location")
            {
                progress += 33; // Increment for location
            }

            if (cmbCategory.SelectedIndex != -1)
            {
                progress += 33; // Increment for category
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text != "Enter detailed description")
            {
                progress += 34; // Increment for description (final step)
            }

            progressBarReport.Value = progress; // Set the progress bar value
        }
    }
}
