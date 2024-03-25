using DB_Lab_Management_System.Assessments;
using DB_Lab_Management_System.CLOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab_Management_System.Assessments
{
    public partial class Form5 : Form
    {
        int key = 0;
        private string ConnectionString = "Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        public Form5()
        {
            InitializeComponent();
            PopulateComboBoxWithAssesTitles();
            PopulateComboBoxWithRubricDetails();
            DisplayAssessmentComponents();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }
        private void PopulateComboBoxWithAssesTitles()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT Title FROM Assessment where substring(title,1,7)<>'Deleted'";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear the ComboBox
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();


                        comboBox1.Items.Add(title);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateComboBoxWithRubricDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT * FROM Rubric where substring(details,1,7)<>'Deleted';";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    // Clear the ComboBox
                    comboBox2.Items.Clear();

                    while (reader.Read())
                    {
                        string detail = reader["Details"].ToString();

                        // Add the detail to the ComboBox
                        comboBox2.Items.Add(detail);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetAssesIdFromTitle(string assesTitle)
        {
            int assesId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Id FROM Assessment WHERE Title = @Title", connection))
                {
                    command.Parameters.AddWithValue("@Title", assesTitle);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        assesId = int.Parse(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }

            return assesId;
        }
        private int GetRubricId(string rubricdetail)
        {
            int rubricId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Id FROM Rubric WHERE Details = @Detail", connection))
                {
                    command.Parameters.AddWithValue("@Detail", rubricdetail);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        rubricId = int.Parse(reader["Id"].ToString());
                    }

                    reader.Close();
                }
            }

            return rubricId;
        }
        private void AddData(int assesId, string name, int totalMarks, string rubricdetail)
        {
            int rubricId = GetRubricId(rubricdetail);
            if (rubricId == -1)
            {
                MessageBox.Show("Rubric not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO AssessmentComponent (AssessmentId, Name, TotalMarks, RubricId, DateCreated, DateUpdated) VALUES (@AssesID, @Name, @TotalMarks, @RubricID, GETDATE(), GETDATE())", connection))
                {
                    command.Parameters.AddWithValue("@AssesID", assesId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@TotalMarks", totalMarks);
                    command.Parameters.AddWithValue("@RubricID", rubricId);

                    int rowsAffected = command.ExecuteNonQuery();
                    DisplayAssessmentComponents();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error adding data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void UpdateData(int assesId, string name, int totalMarks, string rubricdetail)
        {
            try
            {
                int rubricId = GetRubricId(rubricdetail);
                if (rubricId == -1)
                {
                    MessageBox.Show("Rubric not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE AssessmentComponent SET Name = @Name, TotalMarks = @TotalMarks, RubricId = @RubricID, DateUpdated = GETDATE() WHERE Id=@key", connection))
                    {
                        command.Parameters.AddWithValue("@AssessmentID", assesId);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@TotalMarks", totalMarks);
                        command.Parameters.AddWithValue("@RubricID", rubricId);
                        command.Parameters.AddWithValue("@key", key);
                        int rowsAffected = command.ExecuteNonQuery();
                        DisplayAssessmentComponents();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error updating data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteData(int assesId, string rubricdetail)
        {
            try
            {
                int rubricId = GetRubricId(rubricdetail);
                if (rubricId == -1)
                {
                    MessageBox.Show("Rubric not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM AssessmentComponent WHERE AssessmentID = @AssessmentID AND RubricId = @RubricID", connection))
                    {
                        command.Parameters.AddWithValue("@AssessmentID", assesId);
                        command.Parameters.AddWithValue("@RubricID", rubricId);
                        DisplayAssessmentComponents();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error deleting data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || Nametxt.Text == "" || Markstxt.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int assesId = GetAssesIdFromTitle(comboBox1.SelectedItem.ToString());
                string name = Nametxt.Text;
                int totalMarks = int.Parse(Markstxt.Text);
                string rubricTitle = comboBox2.SelectedItem.ToString();

                // Update data in database
                UpdateData(assesId, name, totalMarks, rubricTitle);
                DisplayAssessmentComponents();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || Nametxt.Text == "" || Markstxt.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {

                int assesId = GetAssesIdFromTitle(comboBox1.SelectedItem.ToString());
                string rubricTitle = comboBox2.SelectedItem.ToString();
                DeleteData(assesId, rubricTitle);
                DisplayAssessmentComponents();
            }
        }
        private void DisplayAssessmentComponents()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM AssessmentComponent";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No assessment components found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving assessment components: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetRubricDetail(int rubricId)
        {
            string detail = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Details FROM Rubric WHERE Id = @RubricId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RubricId", rubricId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        detail = reader["Details"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting rubric detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return detail;
        }
        private string GetAssessmentTitle(int assessmentId)
        {
            string title = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Title FROM Assessment WHERE Id = @AssessmentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AssessmentId", assessmentId);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        title = reader["Title"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting assessment title: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return title;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                key = int.Parse(row.Cells[0].Value.ToString());
                comboBox1.SelectedItem = GetAssessmentTitle(int.Parse(row.Cells["AssessmentId"].Value.ToString()));
                Nametxt.Text = row.Cells["Name"].Value.ToString();
                Markstxt.Text = row.Cells["TotalMarks"].Value.ToString();
                comboBox2.SelectedItem = GetRubricDetail(int.Parse(row.Cells["RubricId"].Value.ToString()));
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAssessments manage = new ManageAssessments();
            manage.Show();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || Nametxt.Text == "" || Markstxt.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int assesId = GetAssesIdFromTitle(comboBox1.SelectedItem.ToString());
                string name = Nametxt.Text;
                int totalMarks = int.Parse(Markstxt.Text);
                string rubricTitle = comboBox2.SelectedItem.ToString();

                // Add data to database
                AddData(assesId, name, totalMarks, rubricTitle);
                DisplayAssessmentComponents();
            }
        }
    }
}
