using System;
using System.Windows.Forms;
using DB_Lab_Management_System.Attendance;
using DB_Lab_Management_System.Assessments;
using DB_Lab_Management_System.CLOs;

namespace DB_Lab_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }
        private void ManageStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudents manageStudents = new ManageStudents();
            manageStudents.Show();
        }
        private void ManageCLOs_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCLOs manageCLOs = new ManageCLOs();
            manageCLOs.Show();
        }
        private void ManageAssessments_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAssessments manageAssessments=new ManageAssessments();
            manageAssessments.Show();
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
