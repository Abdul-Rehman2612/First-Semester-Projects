using System;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Assessments
{
    public partial class ManageAssessments : Form
    {
        public ManageAssessments()
        {
            InitializeComponent();
        }
        private void Assessment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assessment assessment = new Assessment();
            assessment.Show();
        }
        private void AssessmentComponents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void Results_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results results = new Results();
            results.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
    }
}
