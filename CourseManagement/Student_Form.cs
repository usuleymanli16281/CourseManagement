using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagement
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
            var students = new List<Student>();
            students = GetStudents();
            dataGridView1.DataSource= students;
            textBox1.Enabled= false;
            textBox2.Enabled= false;
            dateTimePicker2.Enabled= false;
        }

        int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker2.Enabled = true;
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime.TryParseExact(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime birthdate);
            string creationtime = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string modificationtime = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           
            textBox1.Text = name;
            textBox2.Text = surname;
            dateTimePicker2.Value = birthdate;

        }

        private List<Student> GetStudents()
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Student";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var student = new Student();
                    var id = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var surname = dr.GetString(2);
                    var birthdate = dr.GetDateTime(3).ToString("dd.MM.yyyy");
                    var creationtime = dr.GetString(4);
                    var modificationtime = dr.GetString(5);
                    student.Id = id;
                    student.Name = name;
                    student.Surname = surname;
                    student.BirthDate = birthdate;
                    student.CreationTime = creationtime;
                    student.ModificationTime = modificationtime;
                    students.Add(student);
                }

            }
            return students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"Insert into Student(Name,Surname,BirthDate,CreationTime,ModificationTime)
                                        Values(@Name,@Surname,@BirthDate,@CreationTime,@ModificationTime)";
                command.Parameters.Add(new SqlParameter("@Name", NameBox.Text));
                command.Parameters.Add(new SqlParameter("@Surname", SurnameBox.Text));
                command.Parameters.Add(new SqlParameter("@BirthDate", dateTimePicker1.Value));
                command.Parameters.Add(new SqlParameter("@CreationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                command.Parameters.Add(new SqlParameter("@ModificationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                MessageBox.Show($"Student {NameBox.Text} added", "New Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
                students = GetStudents();
            }
            dataGridView1.DataSource = students;
            NameBox.Text = "";
            SurnameBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
           
        }

        private void Update__Click(object sender, EventArgs e)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Update Student set Name =@Name, Surname = @Surname, ModificationTime = @ModificationTime, BirthDate = @BirthDate   where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Name", textBox1.Text));
                command.Parameters.Add(new SqlParameter("@Surname", textBox2.Text));
                command.Parameters.Add(new SqlParameter("@ModificationTime", DateTime.Now.ToString("dd.MM.yyyy")));
                command.Parameters.Add(new SqlParameter("@BirthDate", dateTimePicker2.Value));
                command.Parameters.Add(new SqlParameter("@Id", id));
                MessageBox.Show($"Student with {id} Id updated", "Updated Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();

                students = GetStudents();
                dataGridView1.DataSource = students;
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker2.Value= DateTime.Now;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void Delete__Click(object sender, EventArgs e)
        {
            var students = new List<Student>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Delete Student where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Id", id));
                DialogResult = MessageBox.Show($"Are you sure student with {id} Id to delete", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(DialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                }
                
                students = GetStudents();
                dataGridView1.DataSource = students;

            }
        }
    }
}
