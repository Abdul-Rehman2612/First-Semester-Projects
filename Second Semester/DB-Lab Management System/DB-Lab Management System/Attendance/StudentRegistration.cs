using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Attendance
{
    public partial class StudentRegistration : Form
    {
        static int key=0;
        readonly static string Connection = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        public StudentRegistration()
        {
            InitializeComponent();
            LoadDataForStatus();
            LoadIntoDataGrid();
        }
        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataForStatus()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "Select name, lookupid from lookup where Category='STUDENT_STATUS';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    SInput.DataSource = dt;
                    SInput.DisplayMember = "name";
                    SInput.ValueMember = "lookupid";
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
        private void LoadIntoDataGrid()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM Student";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    ViewStudentData.DataSource = dt;
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
            string check = NameInputCheck(FNInput.Text);
            if (check=="True")
            {
                check=NameInputCheck(LNInput.Text);
                if (check=="True")
                {
                    check=RegistrationNumberCheck(RNInput.Text);
                    if (check=="True")
                    {
                        check=EmailCheck(EMInput.Text);
                        if (check=="True")
                        {
                            if(IsValidContactNumber(CInput.Text)==true)
                            {
                                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                                {
                                    string Query = $"Insert into Student(FirstName,LastName,Contact,Email,RegistrationNumber,Status) Values(@FNInput,@LNInput,@CInput,@EMInput,@RNInput,@SInput)";
                                    try
                                    {
                                        sqlConnection.Open();
                                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                                        cmd.Parameters.AddWithValue("@FNInput", FNInput.Text);
                                        cmd.Parameters.AddWithValue("@LNInput", LNInput.Text);
                                        cmd.Parameters.AddWithValue("@CInput", CInput.Text);
                                        cmd.Parameters.AddWithValue("@EMInput", EMInput.Text);
                                        cmd.Parameters.AddWithValue("@RNInput", RNInput.Text);
                                        cmd.Parameters.AddWithValue("@SInput", Convert.ToInt32(SInput.SelectedValue));
                                        int rowsEffected=cmd.ExecuteNonQuery();
                                        if(rowsEffected>0)
                                        {
                                            MessageBox.Show("Student added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                MessageBox.Show("Number must be in format 923000000000 || 03000000000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(check,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(check,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Last name"+check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First name"+check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void LNInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageStudents manageStudents = new ManageStudents();
            manageStudents.Show();
        }
        private bool IsValidContactNumber(string number)
        {
            if(number.Length>10)
            {
                if ((number[0]=='0' && number[1]=='3') || (number[0]=='9' && number[1]=='2' && number[2]=='3'))
                {
                    foreach (char c in number)
                    {
                        if (!char.IsDigit(c))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        private void FNInput_TextChanged(object sender, EventArgs e)
        {

        }
        private string RegistrationNumberCheck(string text)
        {
            if (text.Length > 8 && text.Length <50 )
            {
                for (int i = 0; i < 4; i++)
                {
                    if (!char.IsDigit(text[i]))
                    {
                        return "Registration number must be in format '2023-CS-73'";
                    }
                }
                if (text[4] == '-' && (text[5] == 'C' || text[5] == 'c') && (text[6] == 'S' || text[6] == 's') && text[7] == '-')
                {
                    for (int i = 8; i < text.Length; i++)
                    {
                        if (!char.IsDigit(text[i]))
                        {
                            return "Registration number must be in format '2023-CS-73'";
                        }
                    }
                }
                else
                {
                    return "Registration number must be in format '2023-CS-73'";
                }
            }
            else
            {
                return "Registration number must be in format '2023-CS-73'";
            }
            if (!CheckRNInDB())
            {
                return "True";
            }
            else
            {
                return "Registration Number already exists! Cannot add new student with same registration number!";
            }
        }
        private bool CheckRNInDB()
        {
            SqlConnection sqlConnection = new SqlConnection(Connection);
            string query = $"SELECT RegistrationNumber FROM Student WHERE RegistrationNumber = '{RNInput.Text}'";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
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
            return false;
        }
        private string EmailCheck(string text)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if(Regex.IsMatch(text, pattern))
            {
                if(!CheckEMInDB())
                {
                    return "True";
                }
                else
                {
                    return "Email already exists!";
                }
            }
            return "Email is not valid!";
            
        }
        private bool CheckEMInDB()
        {
            SqlConnection sqlConnection = new SqlConnection(Connection);
            string query = $"SELECT Email FROM Student WHERE Email = '{EMInput.Text}'";
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
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
            return false;
        }
        private string NameInputCheck(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (text.Length<50)
                {
                    if (text[0] >= 'A' && text[0] <= 'Z')
                    {
                        foreach (char c in text)
                        {
                            if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != ' ')
                            {
                                return " can only consist of alphabets!";
                            }
                        }
                    }
                    else
                    {
                        return " letter must be capital!";
                    }
                }
                else
                {
                    return " must be smaller than 50 characters!";
                }
            }
            else
            {
                return " cannot be null!";
            }
            return "True";
        }
        private void EMInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void CInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void RNInput_TextChanged(object sender, EventArgs e)
        {

        }
        static string RN = "";
        static string EM = "";
        private void ViewStudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ViewStudentData.Rows.Count)
            {
                DataGridViewRow selectedRow = ViewStudentData.Rows[e.RowIndex];
                key = int.Parse(selectedRow.Cells[0].Value.ToString());
                FNInput.Text = selectedRow.Cells[1].Value.ToString();
                LNInput.Text = selectedRow.Cells[2].Value.ToString();
                CInput.Text = selectedRow.Cells[3].Value.ToString();
                EMInput.Text = selectedRow.Cells[4].Value.ToString();
                RNInput.Text = selectedRow.Cells[5].Value.ToString();
                EM = selectedRow.Cells[4].Value.ToString();
                RN = selectedRow.Cells[5].Value.ToString();
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            string check = NameInputCheck(FNInput.Text);
            if (check=="True")
            {
                check=NameInputCheck(LNInput.Text);
                if (check=="True")
                {
                    check=RegistrationNumberCheck(RNInput.Text);
                    if (check=="True" || RNInput.Text==RN)
                    {
                        check=EmailCheck(EMInput.Text);
                        if (check=="True" || EMInput.Text==EM)
                        {
                            if (IsValidContactNumber(CInput.Text)==true)
                            {
                                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                                {
                                    string Query = $"UPDATE Student SET FirstName = @FNInput, LastName = @LNInput,Contact = @CInput,Email = @EMInput,RegistrationNumber = @RNInput, Status = @SInput WHERE Id = @key";
                                    try
                                    {
                                        sqlConnection.Open();
                                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                                        cmd.Parameters.AddWithValue("@key",key);
                                        cmd.Parameters.AddWithValue("@FNInput", FNInput.Text);
                                        cmd.Parameters.AddWithValue("@LNInput", LNInput.Text);
                                        cmd.Parameters.AddWithValue("@CInput", CInput.Text);
                                        cmd.Parameters.AddWithValue("@EMInput", EMInput.Text);
                                        cmd.Parameters.AddWithValue("@RNInput", RNInput.Text);
                                        cmd.Parameters.AddWithValue("@SInput", Convert.ToInt32(SInput.SelectedValue));
                                        int rowsEffected = cmd.ExecuteNonQuery();
                                        if (rowsEffected>0)
                                        {
                                            MessageBox.Show("Student updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                MessageBox.Show("Number must be in format 923000000000 || 03000000000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Last name"+check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First name"+check, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string Query = $"Update student Set status=6 where id=@key";
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@key", key);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Student deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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