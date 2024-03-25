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
    public partial class Results : Form
    {
        private string ConnectionString = @"Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;";
        public Results()
        {
            InitializeComponent();
            AddItems3();
            AddItems1();
            AddItems2();
            AddItems4();
            AddItems5();
            AddItems6();
            BindData();
        }
        private void AddItems4()
        {
            string query = "SELECT Name FROM AssessmentComponent";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox2.Items.Clear();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();
        }
        private void AddItems5()
        {
            string query = "SELECT RubricId FROM RubricLevel";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox6.Items.Clear();

            while (reader.Read())
            {
                comboBox6.Items.Add(reader.GetInt32(0));
            }

            reader.Close();
            con.Close();
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-L60GA3Q;Database=ProjectB;Trusted_Connection=True;");
        void BindData()
        {
            SqlCommand command = new SqlCommand("select ((rl.MeasurementLevel * assc.TotalMarks) / 4) as ObtainedMarks, " +
            " Student.FirstName, rl.Details, ass.Title, assc.TotalMarks as ComponentMarks, rl.MeasurementLevel " +
            " from RubricLevel as rl, StudentResult as sd, AssessmentComponent as assc, Student, Assessment as ass" +
            " where rl.Id = sd.RubricMeasurementId And assc.Id = sd.AssessmentComponentId And ass.Id = assc.AssessmentId " +
            " And sd.StudentId = Student.Id", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnEvaluate_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO StudentResult (StudentId, AssessmentComponentId, RubricMeasurementId, EvaluationDate) " +
                                                       "VALUES (@StudentId, @AssCompId, @RubLvlId, @EvaluationDate)", con);

                SqlCommand c1 = new SqlCommand("select Id from Student where RegistrationNumber=@Regno", con);
                c1.Parameters.AddWithValue("@Regno", comboBox1.Text);
                SqlDataReader reader = c1.ExecuteReader();
                reader.Read();
                int i = reader.GetInt32(0);
                reader.Close();
                c1.ExecuteScalar();

                SqlCommand c2 = new SqlCommand("select Id from AssessmentComponent where Name=@Name", con);
                c2.Parameters.AddWithValue("@Name", comboBox2.Text);
                SqlDataReader reader2 = c2.ExecuteReader();
                reader2.Read();
                int j = reader2.GetInt32(0);
                reader2.Close();
                c2.ExecuteScalar();

                SqlCommand c3 = new SqlCommand("select Id from RubricLevel where Details=@Details", con);
                c3.Parameters.AddWithValue("@Details", comboBox3.Text);
                SqlDataReader r3 = c3.ExecuteReader();
                r3.Read();
                int x = r3.GetInt32(0);
                r3.Close();
                c3.ExecuteScalar();

                sqlCommand.Parameters.AddWithValue("@StudentId", i);
                sqlCommand.Parameters.AddWithValue("@AssCompId", j);
                sqlCommand.Parameters.AddWithValue("@RubLvlId", x);
                sqlCommand.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Evaluation Added!");
                BindData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("same student id can't use " + ex.Message);
            }
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
        }
        private void AddItems6()
        {
            string query = "SELECT Details FROM Rubric";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox5.Items.Clear();

            while (reader.Read())
            {
                comboBox5.Items.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();
        }
        private void AddItems3()
        {
            string query = "SELECT Details FROM RubricLevel";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox3.Items.Clear();

            while (reader.Read())
            {
                comboBox3.Items.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();
        }
        private void AddItems1()
        {
            string query = "SELECT RegistrationNumber FROM Student";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox1.Items.Clear();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();
        }



        private void AddItems2()
        {
            string query = "SELECT Title FROM Assessment";


            con.Open();

            SqlCommand command = new SqlCommand(query, con);

            SqlDataReader reader = command.ExecuteReader();
            comboBox4.Items.Clear();

            while (reader.Read())
            {
                comboBox4.Items.Add(reader.GetString(0));
            }

            reader.Close();
            con.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Results_Load(object sender, EventArgs e)
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
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
