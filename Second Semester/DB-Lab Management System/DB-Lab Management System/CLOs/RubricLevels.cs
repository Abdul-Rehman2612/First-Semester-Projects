using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Lab_Management_System.CLOs
{
    public partial class RubricLevels : Form
    {
        public RubricLevels()
        {
            InitializeComponent();
            LoadDataIntoGrid();
            LoadDataForRID();
        }
        int key =0;
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
            ManageCLOs manageCLOs = new ManageCLOs();
            manageCLOs.Show();
        }
        private void AddCLO_Click(object sender, EventArgs e)
        {
            if (RInput.Text!="" && DInput.Text!="")
            {
                using (SqlConnection sqlConnection = new SqlConnection(Connection))
                {
                    string Query = $"Insert into RubricLevel(RubricID,Details,MeasurementLevel) Values(@RID,@Details,@MInput)";
                    try
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                        cmd.Parameters.AddWithValue("@RID", Convert.ToInt32(RInput.SelectedValue));
                        cmd.Parameters.AddWithValue("@Details", DInput.Text);
                        cmd.Parameters.AddWithValue("@MInput", Convert.ToInt32(MInput.Text));
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected>0)
                        {
                            MessageBox.Show("Rubric level added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        private void LoadDataForRID()
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = "SELECT * FROM Rubric WHERE SUBSTRING(Details, 1, 7) <> 'DELETED';";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RInput.DataSource = dt;
                    RInput.DisplayMember = "Details";
                    RInput.ValueMember = "ID";
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
                string Query = "SELECT * FROM RubricLevel WHERE SUBSTRING(Details, 1, 7) <> 'DELETED';";
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    RubricLevelView.DataSource = dt;
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
        private void RubricLevelView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < RubricLevelView.Rows.Count)
            {
                DataGridViewRow selectedRow = RubricLevelView.Rows[e.RowIndex];
                key = int.Parse(selectedRow.Cells[0].Value.ToString());
                RInput.Text = selectedRow.Cells[1].Value.ToString();
                DInput.Text = selectedRow.Cells[2].Value.ToString();
                MInput.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"Update RubricLevel Set Details=Concat('DELETED',@Details) where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.Parameters.AddWithValue("@Details", DInput.Text);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Rubric level deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Connection))
            {
                string Query = $"Update RubricLevel Set RubricID=@RInput,Details=@DInput,MeasurementLevel=@MInput where ID=@key";
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand(Query, sqlConnection);
                    cmd.Parameters.AddWithValue("@Key", key);
                    cmd.Parameters.AddWithValue("@RInput", Convert.ToInt32(RInput.SelectedValue));
                    cmd.Parameters.AddWithValue("@DInput", DInput.Text);
                    cmd.Parameters.AddWithValue("@MInput", Convert.ToInt32(MInput.Text));
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected>0)
                    {
                        MessageBox.Show("Rubric level updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
