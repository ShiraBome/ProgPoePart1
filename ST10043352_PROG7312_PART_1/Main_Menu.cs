using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10043352_PROG7312_PART_1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }


        //test
        private void BtnReportIssues_Click(object sender, EventArgs e)
        {
            ReportPage report = new ReportPage();
            this.Hide();
            report.Show();
        }

        private void BtnLocalEvents_Click(object sender, EventArgs e)
        {
            // Code to handle the "Local Events and Announcements" functionality
            MessageBox.Show("This feature will be available soon.");
        }

        private void BtnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            // Code to handle the "Service Request Status" functionality
            MessageBox.Show("This feature will be available soon.");

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit(); 
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}