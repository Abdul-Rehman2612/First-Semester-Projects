using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Attendance
{
    public partial class StudentAttendance : Form
    {
        public StudentAttendance()
        {
            InitializeComponent();
            LoadStudents();
            LoadDataForStatus();
        }
        readonly static string Connection = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        private void LoadStudents()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "Select RegistrationNumber,ID from student where status=5;";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    StudentID.DataSource = dt;
                    StudentID.DisplayMember = "RegistrationNumber";
                    StudentID.ValueMember = "ID";
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
        private void LoadDataForStatus()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "Select name, lookupid from lookup where Category='ATTENDANCE_STATUS';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Status.DataSource = dt;
                    Status.DisplayMember = "name";
                    Status.ValueMember = "lookupid";
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
        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStudents manageStudents = new ManageStudents();
            manageStudents.Show();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Status.Text!="" && StudentID.Text!="")
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    string Query = $"Insert into StudentAttendance(AttendanceID,StudentID,AttendanceStatus) Values(@AttendanceID,@StudentID,@Status)";
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@AttendanceID", ClassDatePicker());
                        cmd.Parameters.AddWithValue("@StudentID", Convert.ToInt32(StudentID.SelectedValue));
                        cmd.Parameters.AddWithValue("@Status", Convert.ToInt32(Status.SelectedValue));
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected>0)
                        {
                            MessageBox.Show("Student attendance marked successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Attendance already marked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Missing information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int ClassDatePicker()
        {
            if (CheckAttendanceDate()>0)
            {
                return CheckAttendanceDate();
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    string Query = "INSERT INTO ClassAttendance (AttendanceDate) VALUES (@ClassAttendanceDate);";
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@ClassAttendanceDate", AttendanceDatePick.Value);
                        int rowsEffected = cmd.ExecuteNonQuery();
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
                return CheckAttendanceDate();
            }
        }
        private int CheckAttendanceDate()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                int id = -1;
                string Query = $"SELECT ID FROM ClassAttendance WHERE SUBSTRING(CONVERT(VARCHAR, AttendanceDate, 120), 1, 10) = '{AttendanceDatePick.Value.ToString("yyyy-MM-dd")}';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ID"]);
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
                return id;
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard manageDashboard = new AdminDashboard();
            manageDashboard.Show();
        }
    }
}