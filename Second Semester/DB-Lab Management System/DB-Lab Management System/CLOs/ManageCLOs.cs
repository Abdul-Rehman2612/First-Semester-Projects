using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Management_System.CLOs
{
    public partial class ManageCLOs : Form
    {
        public ManageCLOs()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
        private void CLO_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLO cLO = new CLO();
            cLO.Show();
        }
        private void Rubrics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rubrics rubrics = new Rubrics();
            rubrics.Show();
        }
        private void RubricLevels_Click(object sender, EventArgs e)
        {
            this.Hide();
            RubricLevels rubrics = new RubricLevels();
            rubrics.Show();
        }
    }
}
