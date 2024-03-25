using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Lab_Management_System.CLOs
{
    public partial class CLO : Form
    {
        public CLO()
        {
            InitializeComponent();
            LoadIntoDataGrid();
        }
        int key = 0;
        readonly static string Connection = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCLOs manageCLOs = new ManageCLOs();
            manageCLOs.Show();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard manageDashboard = new AdminDashboard();
            manageDashboard.Show();
        }
        private void AddCLO_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CLOInput.Text))
            {
                if (!CheckCLO())
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Connection))
                    {
                        string Query = $"Insert into CLO(Name,DateCreated,DateUpdated) Values(@CLOInput,@DateCreated,@DateUpdated)";
                        try
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                            cmd.Parameters.AddWithValue("@CLOInput", CLOInput.Text);
                            cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                            cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                            int rowsEffected = cmd.ExecuteNonQuery();
                            if (rowsEffected>0)
                            {
                                MessageBox.Show("CLO added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("CLO already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CLO Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadIntoDataGrid()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM CLO WHERE SUBSTRING(Name, 1, 7) <> 'DELETED';";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    CLOsView.DataSource = dt;
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
        private bool CheckCLO()
        {
            SqlConnection sqlConnection = new SqlConnection(Connection);
            string query = $"SELECT Name FROM CLO WHERE Name = '{CLOInput.Text}'";
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
        private void CLOsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CLOsView.Rows.Count)
            {
                DataGridViewRow selectedRow = CLOsView.Rows[e.RowIndex];
                key = int.Parse(selectedRow.Cells[0].Value.ToString());
                CLOInput.Text = selectedRow.Cells[1].Value.ToString();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"update CLO set Name=Concat('DELETED',@CLOInput) where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@CLOInput", CLOInput.Text);
                    cmd.Parameters.AddWithValue("@key", key);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("CLO deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"update CLO set Name=@CLOInput,DateUpdated=@DateUpdated where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@CLOInput", CLOInput.Text);
                    cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@key", key);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("CLO updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ManageRubrics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rubrics rubrics = new Rubrics();
            rubrics.Show();
        }
    }
}
