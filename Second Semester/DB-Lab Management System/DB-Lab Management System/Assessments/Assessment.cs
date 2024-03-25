using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Lab_Management_System.Assessments
{
    public partial class Assessment : Form
    {
        public Assessment()
        {
            InitializeComponent();
            LoadIntoDataGrid();
        }
        int key = 0;
        readonly static string Connection = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (Markstxt.Text!="" && Weightagetxt.Text!="" && Titletxt.Text!="")
            {
                string Query = "INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Name, GETDATE(), @marks, @weight)";
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@Name", Titletxt.Text);
                        cmd.Parameters.AddWithValue("@marks", int.Parse(Markstxt.Text));
                        cmd.Parameters.AddWithValue("@weight", int.Parse(Weightagetxt.Text));
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected>0)
                        {
                            MessageBox.Show("Assessment added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LoadIntoDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insert number only in marks and weightage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadIntoDataGrid()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM Assessment where SUBSTRING(Title, 1, 7) <> 'DELETED'";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    AssessmentView.DataSource = dt;
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
        private void Titletxt_TextChanged(object sender, EventArgs e)
        {
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "Update Assessment Set title=Concat('DELETED',@titletxt) where id=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.Parameters.AddWithValue("@titletxt", Titletxt.Text);
                    cmd.Parameters.AddWithValue("@key", key);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    LoadIntoDataGrid();
                    MessageBox.Show("Assessment deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void AssessmentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < AssessmentView.Rows.Count)
            {
                DataGridViewRow selectedRow = AssessmentView.Rows[e.RowIndex];
                key = int.Parse(selectedRow.Cells[0].Value.ToString());
                Titletxt.Text = selectedRow.Cells[1].Value.ToString();
                Markstxt.Text = selectedRow.Cells[3].Value.ToString();
                Weightagetxt.Text = selectedRow.Cells[4].Value.ToString();
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (Markstxt.Text!="" && Weightagetxt.Text!="" && Titletxt.Text!="")
            {
                string Query = "update Assessment set Title=@Name,TotalMarks=@marks,TotalWeightage=@weight where id=@key";
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@Name", Titletxt.Text);
                        cmd.Parameters.AddWithValue("@marks", int.Parse(Markstxt.Text));
                        cmd.Parameters.AddWithValue("@weight", int.Parse(Weightagetxt.Text));
                        cmd.Parameters.AddWithValue("@key", key);
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected>0)
                        {
                            MessageBox.Show("Assessment added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Missing information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AssessmentComponent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }

        private void Assessment_Load(object sender, EventArgs e)
        {

        }
    }
}
