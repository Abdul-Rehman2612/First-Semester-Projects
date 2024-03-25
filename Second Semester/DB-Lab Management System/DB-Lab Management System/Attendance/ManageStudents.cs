using System;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Attendance
{
    public partial class ManageStudents : Form
    {
        public ManageStudents()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void StudentsRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
        }

        private void ManageClassAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassAttendance studentAttendance = new ClassAttendance();
            studentAttendance.Show();
        }

        private void ManageStudentAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAttendance studentAttendance = new StudentAttendance();
            studentAttendance.Show();
        }
    }
}
