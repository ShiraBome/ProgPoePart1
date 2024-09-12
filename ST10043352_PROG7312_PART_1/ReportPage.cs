using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class ReportPage : Form
    {


        private List<Issue> issues = new List<Issue>(); // This list stores the user-reported issues.
        private bool isImageAttached = false;

        public ReportPage()
        {
            InitializeComponent();
            UpdateButtonVisibility();
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
            // lblLocationPlaceholder.Visible = string.IsNullOrEmpty(txtLocation.Text);
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

        private List<string> attachedFilePaths = new List<string>();  // List to store attached file paths

        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            // Configure the open file dialog for file selection
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            openFileDialog.Title = "Select Media Files";
            openFileDialog.Multiselect = true;  // Allow multiple file selection

            // Handle file selection and save the files
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var selectedFile in openFileDialog.FileNames)
                {
                    attachedFilePaths.Add(selectedFile);  // Add the selected file path to the list
                }

                // Update UI elements (buttons) based on attachments
                UpdateButtonVisibility();  // Show "View Image" and "Remove Image" buttons
            }
        }



        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {

            if (attachedFilePaths.Count == 0)
            {
                MessageBox.Show("No files to remove.", "Remove Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new form dynamically for selecting and removing an image
            Form removeFileForm = new Form
            {
                Text = "Select a File to Remove",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            // Create a ListBox to display the file names of attached images
            ListBox fileListBox = new ListBox
            {
                Dock = DockStyle.Top,
                Height = 200
            };

            // Populate the ListBox with the file names of the attached files
            fileListBox.Items.AddRange(attachedFilePaths.Select(Path.GetFileName).ToArray());

            // Create a button to remove the selected image
            Button removeButton = new Button
            {
                Text = "Remove",
                Dock = DockStyle.Left
            };

          

            // When the Remove button is clicked
            removeButton.Click += (s, ea) =>
            {
                if (fileListBox.SelectedIndex != -1)
                {
                    // Remove the selected file from the list
                    attachedFilePaths.RemoveAt(fileListBox.SelectedIndex);
                    fileListBox.Items.RemoveAt(fileListBox.SelectedIndex);

                    // Update the visibility of buttons if there are no more files
                    UpdateButtonVisibility();
                }
                else
                {
                    MessageBox.Show("Please select a file to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Create a panel to hold the buttons
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            // Add buttons to the panel
            buttonPanel.Controls.Add(removeButton);

            // Add controls to the form
            removeFileForm.Controls.Add(fileListBox);
            removeFileForm.Controls.Add(buttonPanel);

            // Show the form as a modal dialog box
            removeFileForm.ShowDialog();
        }

        private void UpdateButtonVisibility()
        {
            // Only show the buttons if there are attachments
            if (attachedFilePaths.Count > 0)
            {
                btnViewImage.Visible = true;
                btnRemoveImage.Visible = true;
            }
            else
            {
                btnViewImage.Visible = false;
                btnRemoveImage.Visible = false;
            }
        }

        private void BtnViewImage_Click(object sender, EventArgs e)
        {
            if (attachedFilePaths.Count == 0)
            {
                MessageBox.Show("No files are attached.", "View Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a new form dynamically for selecting and viewing an image
            Form imageSelectorForm = new Form
            {
                Text = "Select an Image to View",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            // Create a ListBox to display the file names of attached images
            ListBox fileListBox = new ListBox
            {
                Dock = DockStyle.Top,
                Height = 200
            };

            // Populate the ListBox with the file names of the attached files
            fileListBox.Items.AddRange(attachedFilePaths.Select(Path.GetFileName).ToArray());

            // Create a button to view the selected image
            Button viewImageButton = new Button
            {
                Text = "View Image",
                Dock = DockStyle.Left
            };

           

            // When the View Image button is clicked
            viewImageButton.Click += (s, ea) =>
            {
                if (fileListBox.SelectedIndex != -1)
                {
                    // Get the selected file path
                    string selectedFile = attachedFilePaths[fileListBox.SelectedIndex];

                    // Create a new form for viewing the image
                    Form imageViewerForm = new Form
                    {
                        Text = "View Attached Image",
                        Size = new Size(600, 400),
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    // Create a PictureBox to display the image
                    PictureBox pictureBox = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = Image.FromFile(selectedFile),  // Load the image from the file
                        SizeMode = PictureBoxSizeMode.Zoom  // Adjust image to fit the PictureBox
                    };

                    // Add the PictureBox to the image viewer form
                    imageViewerForm.Controls.Add(pictureBox);
                    imageViewerForm.ShowDialog();  // Show the image viewer form
                }
                else
                {
                    MessageBox.Show("Please select a file to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Create a panel to hold the buttons
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            // Add buttons to the panel
            buttonPanel.Controls.Add(viewImageButton);

            // Add controls to the form
            imageSelectorForm.Controls.Add(fileListBox);
            imageSelectorForm.Controls.Add(buttonPanel);

            // Show the form as a modal dialog box
            imageSelectorForm.ShowDialog();
        }






        // Handles saving the issue
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Create a new issue object and add it to the issues list
                string location = txtLocation.Text;
                string category = cmbCategory.SelectedItem.ToString();
                string description = rtbDescription.Text;

                // Save all attached images
                List<string> mediaFilePaths = new List<string>(attachedFilePaths);

                // Create a new issue with the location, category, description, and all attached images
                Issue newIssue = new Issue(location, category, description, mediaFilePaths);

                // Add the issue to the list
                AddIssue(newIssue);

                // Provide feedback to the user
                MessageBox.Show("Your issue has been submitted!");

                // Clear the form fields and attached images
                ClearForm();
                attachedFilePaths.Clear();  // Clear the images from memory
                UpdateButtonVisibility();  // Hide buttons after clearing

                // Reset progress bar
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
            // lblLocationPlaceholder.Visible = true;
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