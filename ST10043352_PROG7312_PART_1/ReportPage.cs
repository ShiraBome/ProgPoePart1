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
        internal List<Issue> issues = new List<Issue>();
        private bool isImageAttached = false;
        private bool hasVoted = false;
        private int voteResult = 0;
        private List<string> attachedFilePaths = new List<string>();

        public ReportPage()
        {
            InitializeComponent();
            UpdateButtonVisibility();
        }

        private void BtnUpvote_Click(object sender, EventArgs e)
        {
            if (!hasVoted)
            {
                voteResult = 1;
                hasVoted = true;
                btnUpvote.Enabled = false;
                btnDownvote.Enabled = false;
                MessageBox.Show("Thank you for upvoting!");
            }
        }

        private void BtnDownvote_Click(object sender, EventArgs e)
        {
            if (!hasVoted)
            {
                voteResult = -1;
                hasVoted = true;
                btnUpvote.Enabled = false;
                btnDownvote.Enabled = false;
                MessageBox.Show("We are sorry to hear that, we will try to improve!");
            }
        }

        private void TxtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation.Text == "Enter location")
            {
                txtLocation.Text = "";
                txtLocation.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                txtLocation.Text = "Enter location";
                txtLocation.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void BtnAttachMedia_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|All Files|*.*";
            openFileDialog.Title = "Select Media Files";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var selectedFile in openFileDialog.FileNames)
                {
                    attachedFilePaths.Add(selectedFile);
                }

                UpdateButtonVisibility();
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            if (attachedFilePaths.Count == 0)
            {
                MessageBox.Show("No files to remove.", "Remove Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form removeFileForm = new Form
            {
                Text = "Select a File to Remove",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            ListBox fileListBox = new ListBox
            {
                Dock = DockStyle.Top,
                Height = 200
            };

            fileListBox.Items.AddRange(attachedFilePaths.Select(Path.GetFileName).ToArray());

            Button removeButton = new Button
            {
                Text = "Remove",
                Dock = DockStyle.Left
            };

            removeButton.Click += (s, ea) =>
            {
                if (fileListBox.SelectedIndex != -1)
                {
                    attachedFilePaths.RemoveAt(fileListBox.SelectedIndex);
                    fileListBox.Items.RemoveAt(fileListBox.SelectedIndex);

                    UpdateButtonVisibility();
                }
                else
                {
                    MessageBox.Show("Please select a file to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            buttonPanel.Controls.Add(removeButton);

            removeFileForm.Controls.Add(fileListBox);
            removeFileForm.Controls.Add(buttonPanel);

            removeFileForm.ShowDialog();
        }

        private void UpdateButtonVisibility()
        {
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

            Form imageSelectorForm = new Form
            {
                Text = "Select an Image to View",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen
            };

            ListBox fileListBox = new ListBox
            {
                Dock = DockStyle.Top,
                Height = 200
            };

            fileListBox.Items.AddRange(attachedFilePaths.Select(Path.GetFileName).ToArray());

            Button viewImageButton = new Button
            {
                Text = "View Image",
                Dock = DockStyle.Left
            };

            viewImageButton.Click += (s, ea) =>
            {
                if (fileListBox.SelectedIndex != -1)
                {
                    string selectedFile = attachedFilePaths[fileListBox.SelectedIndex];

                    Form imageViewerForm = new Form
                    {
                        Text = "View Attached Image",
                        Size = new Size(600, 400),
                        StartPosition = FormStartPosition.CenterScreen
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        Image = Image.FromFile(selectedFile),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    imageViewerForm.Controls.Add(pictureBox);
                    imageViewerForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a file to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            buttonPanel.Controls.Add(viewImageButton);

            imageSelectorForm.Controls.Add(fileListBox);
            imageSelectorForm.Controls.Add(buttonPanel);

            imageSelectorForm.ShowDialog();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string location = txtLocation.Text;
                string category = cmbCategory.SelectedItem.ToString();
                string description = rtbDescription.Text;

                List<string> mediaFilePaths = new List<string>(attachedFilePaths);

                Issue newIssue = new Issue(location, category, description, mediaFilePaths);

                AddIssue(newIssue);

                MessageBox.Show("Your issue has been submitted!");

                ClearForm();
                attachedFilePaths.Clear();
                UpdateButtonVisibility();

                progressBarReport.Value = 0;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

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

        private void AddIssue(Issue newIssue)
        {
            issues.Add(newIssue);
            LogIssue(newIssue);
        }

        private void LogIssue(Issue issue)
        {
            Console.WriteLine(issue.ToString());
        }

        private void ClearForm()
        {
            txtLocation.Text = "Enter location";
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Text = "Enter detailed description";
        }

        public void ViewIssues()
        {
            foreach (var issue in issues)
            {
                Console.WriteLine(issue.ToString());
            }
        }

        private void BtnBackToMain_Click(object sender, EventArgs e)
        {
            Main_Menu menu = new Main_Menu();
            this.Hide();
            menu.Show();
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text != "Enter location")
            {
                progress += 33;
            }

            if (cmbCategory.SelectedIndex != -1)
            {
                progress += 33;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text != "Enter detailed description")
            {
                progress += 34;
            }

            progressBarReport.Value = progress;
        }

        // New Method: Event handler for btnViewIssues
        private void BtnViewIssues_Click(object sender, EventArgs e)
        {
            IssuesListForm issuesListForm = new IssuesListForm(issues);
            issuesListForm.ShowDialog();
        }
    }
}
