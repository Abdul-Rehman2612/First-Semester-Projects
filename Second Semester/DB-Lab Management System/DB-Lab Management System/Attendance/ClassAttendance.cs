using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Attendance
{
    public partial class ClassAttendance : Form
    {
        public ClassAttendance()
        {
            InitializeComponent();
            LoadIntoDataGrid();
        }
        readonly static string Connection = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudents manageStudents = new ManageStudents();
            manageStudents.Show();
        }
        private void LoadIntoDataGrid()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM ClassAttendance";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ViewClassAttendances.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (CheckAttendanceDate())
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    string Query = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@ClassAttendanceDate);";
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@ClassAttendanceDate", ClassAttendanceDate.Value);
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Class attendance added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LoadIntoDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Class attendance already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckAttendanceDate()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"SELECT * FROM ClassAttendance WHERE SUBSTRING(CONVERT(VARCHAR, AttendanceDate, 120), 1, 10) = '{ClassAttendanceDate.Value:yyyy-MM-dd}';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
                return true;
            }
        }
        private void ClassAttendanceDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void MarkAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAttendance studentAttendance = new StudentAttendance();
            studentAttendance.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard manageDashboard = new AdminDashboard();
            manageDashboard.Show();
        }
    }
}
