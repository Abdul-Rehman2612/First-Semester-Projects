using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Lab_Management_System.CLOs
{
    public partial class Rubrics : Form
    {
        public Rubrics()
        {
            InitializeComponent();
            LoadDataForCLO();
            LoadDataIntoGrid();
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
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }
        private void LoadDataForCLO()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "SELECT ID,Name FROM CLO WHERE SUBSTRING(Name, 1, 7) <> 'DELETED';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CLOInput.DataSource = dt;
                    CLOInput.DisplayMember = "Name";
                    CLOInput.ValueMember = "ID";
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
        private void LoadDataIntoGrid()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM Rubric where SUBSTRING(Details, 1, 7) <> 'DELETED'";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    RubricDataView.DataSource = dt;
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
        private void CLOInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddCLO_Click(object sender, EventArgs e)
        {
            if (CLOInput.Text!="" && RubricDetails.Text!="")
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    string Query = $"Insert into Rubric(ID,Details,CLOId) Values(@ID,@Details,@CLOInput)";
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(Idtxt.Text));
                        cmd.Parameters.AddWithValue("@Details", RInput.Text);
                        cmd.Parameters.AddWithValue("@ClOInput", Convert.ToInt32(CLOInput.SelectedValue));
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected>0)
                        {
                            MessageBox.Show("Rubric added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LoadDataIntoGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rubric already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"Update Rubric Set Details=Concat('DELETED',@Details) where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.Parameters.AddWithValue("@Details", RInput.Text);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Rubric deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadDataIntoGrid();
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
        private void RubricDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < RubricDataView.Rows.Count)
            {
                DataGridViewRow selectedRow = RubricDataView.Rows[e.RowIndex];
                Idtxt.Text = selectedRow.Cells[0].Value.ToString();
                RInput.Text = selectedRow.Cells[1].Value.ToString();
                key = int.Parse(selectedRow.Cells[0].Value.ToString());
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"Update Rubric Set Details=@Details,CLOId=@CLOInput where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.Parameters.AddWithValue("@Details", RInput.Text);
                    cmd.Parameters.AddWithValue("@ClOInput", Convert.ToInt32(CLOInput.SelectedValue));
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Rubric updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadDataIntoGrid();
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
            RubricLevels rubricLevels = new RubricLevels();
            rubricLevels.Show();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
