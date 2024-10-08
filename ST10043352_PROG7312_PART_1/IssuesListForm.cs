using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class IssuesListForm : Form
    {
        private List<Issue> issues;

        public IssuesListForm(List<Issue> issues)
        {
            InitializeComponent();
            this.issues = issues;
            DisplayIssues();
        }

        private void DisplayIssues()
        {
            listViewIssues.Items.Clear();
            foreach (var issue in issues)
            {
                ListViewItem item = new ListViewItem(issue.Location);
                item.SubItems.Add(issue.Category);
                item.SubItems.Add(issue.Description);
                item.SubItems.Add(string.Join(", ", issue.MediaFilePaths.Select(Path.GetFileName)));
                item.Tag = issue; // Store the issue object in the item's Tag property
                listViewIssues.Items.Add(item);
            }
        }

        private void listViewIssues_DoubleClick(object sender, EventArgs e)
        {
            if (listViewIssues.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewIssues.SelectedItems[0];
                Issue selectedIssue = (Issue)selectedItem.Tag;

                // Create a new form to display the issue details and images
                IssueDetailsForm detailsForm = new IssueDetailsForm(selectedIssue);
                detailsForm.ShowDialog();
            }
        }
    }
}
