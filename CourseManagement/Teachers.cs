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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            var teachers = new List<Teacher>();
            teachers = GetTeachers();
            dataGridView1.DataSource = teachers;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox2.Enabled = false;
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Course";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {

                    var subject = dr.GetString(1);
                    comboBox1.Items.Add(subject);
                    comboBox2.Items.Add(subject);
                }

            }

        }

        private void Delete__Click(object sender, EventArgs e)
        {
            var teachers = new List<Teacher>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Delete Teacher where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Id", id));
                DialogResult = MessageBox.Show($"Are you sure teacher with {id} Id to delete", "Delete Teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();

                }

                teachers = GetTeachers();
                dataGridView1.DataSource = teachers;

            }
        }
        private List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Teacher";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var teacher = new Teacher();
                    var id = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var surname = dr.GetString(2);
                    var birthdate = dr.GetDateTime(3).ToString("dd.MM.yyyy");
                    var subject = dr.GetString(4);

                    teacher.Id = id;
                    teacher.Name = name;
                    teacher.Surname = surname;
                    teacher.BirthDate = birthdate;
                    teacher.Subject = subject;

                    teachers.Add(teacher);
                }

            }
            return teachers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var teachers = new List<Teacher>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"Insert into Teacher(Name,Surname,BirthDate,Subject)
                                        Values(@Name,@Surname,@BirthDate,@Subject)";
                command.Parameters.Add(new SqlParameter("@Name", NameBox.Text));
                command.Parameters.Add(new SqlParameter("@Surname", SurnameBox.Text));
                command.Parameters.Add(new SqlParameter("@BirthDate", dateTimePicker1.Value));
                command.Parameters.Add(new SqlParameter("@Subject", comboBox1.Text));

                MessageBox.Show($"Teacher {NameBox.Text} added", "New Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();
                teachers = GetTeachers();
            }
            dataGridView1.DataSource = teachers;
            NameBox.Text = "";
            SurnameBox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Text = "";
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            var teachers = new List<Teacher>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                connection.Open();
                command.CommandText = @"Update Teacher set Name =@Name, Surname = @Surname, Subject = @Subject, BirthDate = @BirthDate   where Id = @Id";
                command.Parameters.Add(new SqlParameter("@Name", textBox1.Text));
                command.Parameters.Add(new SqlParameter("@Surname", textBox2.Text));
                command.Parameters.Add(new SqlParameter("@Subject", comboBox2.Text));
                command.Parameters.Add(new SqlParameter("@BirthDate", dateTimePicker2.Value));
                command.Parameters.Add(new SqlParameter("@Id", id));
                MessageBox.Show($"Teacher with {id} Id updated", "Updated Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                command.ExecuteNonQuery();

                teachers = GetTeachers();
                dataGridView1.DataSource = teachers;
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker2.Value = DateTime.Now;
            comboBox2.Text = string.Empty;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            dateTimePicker2.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            dateTimePicker2.Enabled = true;
            comboBox2.Enabled = true;
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string surname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime.TryParseExact(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime birthdate);
            string subject = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            textBox1.Text = name;
            textBox2.Text = surname;
            dateTimePicker2.Value = birthdate;
            comboBox2.Text = subject;
        }



        

        

       

        private void comboBox1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                comboBox1.Items.Clear();
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Course";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {

                    var subject = dr.GetString(1);
                    comboBox1.Items.Add(subject);

                }
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                comboBox2.Items.Clear();
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from Course";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {

                    var subject = dr.GetString(1);

                    comboBox2.Items.Add(subject);
                }

            }
        }
    }
}
