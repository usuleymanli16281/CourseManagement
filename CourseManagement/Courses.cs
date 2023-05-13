using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            var courses = new List<Course>();
            courses = GetCourses();
            dataGridView1.DataSource = courses;
            NameBox2.Enabled= false;
            numericUpDown3.Enabled= false;
            textBox2.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var courses = new List<Course>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"Insert into Course(Name,Duration,Price,CreationTime,ModificationTime)
                                        Values(@Name,@Duration,@Price,@CreationTime,@ModificationTime)";
                command.Parameters.Add(new SqlParameter("@Name", NameBox.Text));
                command.Parameters.Add(new SqlParameter("@Duration", numericUpDown1.Value));
                command.Parameters.Add(new SqlParameter("@Price", PriceBox.Text));
                command.Parameters.Add(new SqlParameter("@CreationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                command.Parameters.Add(new SqlParameter("@ModificationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                MessageBox.Show($"{NameBox.Text} course created", "New Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
                courses = GetCourses();
            }
            dataGridView1.DataSource = courses;
            NameBox.Text = "";
            numericUpDown1.Value = 0;
            PriceBox.Text = "";
        }
        private List<Course> GetCourses()
        {
            var courses = new List<Course>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Course";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var course = new Course();
                    var id = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var duration = dr.GetInt32(5);
                    var price = dr.GetInt32(2);
                    var creationtime = dr.GetString(3);
                    var modificationtime = dr.GetString(4);
                    course.Id = id;
                    course.Name = name;
                    course.Duration = duration;
                    course.Price = price;
                    course.CreationTime = creationtime;
                    course.ModificationTime = modificationtime;
                    courses.Add(course);
                }

            }
            return courses;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var courses = new List<Course>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Update Course set Name =@Name, Price = @Price, ModificationTime = @ModificationTime, Duration = @Duration   where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Name", NameBox2.Text));
                command.Parameters.Add(new SqlParameter("@Price", textBox2.Text));
                command.Parameters.Add(new SqlParameter("@ModificationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                command.Parameters.Add(new SqlParameter("@Duration", numericUpDown3.Value));
                command.Parameters.Add(new SqlParameter("@Id", id));
                MessageBox.Show($"Course with {id} Id updated", "Course Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
                courses = GetCourses();
                dataGridView1.DataSource = courses;
            }
            NameBox.Text = "";
            numericUpDown1.Value = 0;
            PriceBox.Text = "";
            NameBox2.Enabled = false;
            numericUpDown3.Enabled = false;
            textBox2.Enabled = false;
        }
        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameBox2.Enabled = true;
            numericUpDown3.Enabled = true;
            textBox2.Enabled = true;
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string creationtime = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string modificationtime = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int duration = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            NameBox2.Text = name;
            textBox2.Text = price.ToString();
            numericUpDown3.Value = duration;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var courses = new List<Course>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Delete Course where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Id",id));
                DialogResult = MessageBox.Show($"Are you sure course with {id} Id to delete","Delete Course",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(DialogResult== DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                }
                
                courses = GetCourses();
                dataGridView1.DataSource = courses;

            }
        }
    }
}
