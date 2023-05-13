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
    public partial class Lesson : Form
    {
        DateTime startdate = DateTime.Now;
        DateTime enddate = DateTime.Now;

        string correct_time_str = null;
        DateTime correct_time = DateTime.Now;
        int month = 0;
        public Lesson()
        {
            InitializeComponent();
            var createlessons = GetCreateLesson();
            dataGridView1.DataSource= createlessons;
            


        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                comboBox1.Items.Clear();
                var command = connection.CreateCommand();
                command.CommandText = @"Select Course.Name from Course";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {

                    var subject = dr.GetString(0);
                    comboBox1.Items.Add(subject);

                }
            }

        }

        

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    comboBox2.Items.Clear();
                    var command = connection.CreateCommand();
                    command.CommandText = @"Select t.Name + ' ' + t.Surname from Teacher t where t.Subject = @Subject";
                    command.Parameters.Add(new SqlParameter("@Subject", comboBox1.Text));
                    connection.Open();
                    var dr = command.ExecuteReader();
                    while (dr.Read())
                    {

                        var teacher = dr.GetString(0);
                        comboBox2.Items.Add(teacher);

                    }
                }
                dateTimePicker1.Enabled = true;
            }
            else
            {
                MessageBox.Show("You need to add a course", "Course needed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {

                var command = connection.CreateCommand();
                command.CommandText = @"Select c.Duration from Course c where c.Name = @Name";
                command.Parameters.Add(new SqlParameter("@Name", comboBox1.Text));
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {

                    month = dr.GetInt32(0);


                }
            }
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(month);


        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                MessageBox.Show("You need to add a course or a teacher name", "Teacher and Course needed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {

                var command = connection.CreateCommand();
                command.CommandText = @"Select c.CreationTime from Course c where c.Name = @Name";
                command.Parameters.Add(new SqlParameter("@Name", comboBox1.Text));
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    correct_time_str = dr.GetString(0);
                    DateTime.TryParseExact(correct_time_str, "dd.MM.yyyy", null, DateTimeStyles.None, out correct_time);
                }
            }
            dateTimePicker1.MinDate = correct_time;

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text != string.Empty)
            {
                using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    comboBox2.Items.Clear();
                    var command = connection.CreateCommand();
                    command.CommandText = @"Select t.Name + ' ' + t.Surname from Teacher t where t.Subject = @Subject";
                    command.Parameters.Add(new SqlParameter("@Subject", comboBox1.Text));
                    connection.Open();
                    var dr = command.ExecuteReader();
                    while (dr.Read())
                    {

                        var teacher = dr.GetString(0);
                        comboBox2.Items.Add(teacher);

                    }
                }
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            if (dateTimePicker1.Value.ToString("dddd") == "Monday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");

            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Tuesday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Wednesday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Thursday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Friday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Saturday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Sunday");
            }
            else if (dateTimePicker1.Value.ToString("dddd") == "Sunday")
            {
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Monday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Tuesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Wednesday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Thursday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Friday");
                comboBox3.Items.Add($"{dateTimePicker1.Value.ToString("dddd")}, Saturday");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text != string.Empty)
            {
                

                using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    
                    var command = connection.CreateCommand();
                    command.CommandText = @"Insert into CreateLesson(CourseName,Teacher_Name_Surname,StartDate,EndDate,Weekdays)
                                            Values(@cname,@tnamesurname,@startdate,@enddate,@weekdays)";
                   
                    command.Parameters.Add(new SqlParameter("@cname", comboBox1.Text));
                    command.Parameters.Add(new SqlParameter("@tnamesurname", comboBox2.Text));
                    command.Parameters.Add(new SqlParameter("@startdate", dateTimePicker1.Value));
                    command.Parameters.Add(new SqlParameter("@enddate", dateTimePicker2.Value));
                    command.Parameters.Add(new SqlParameter("@weekdays", comboBox3.Text));
                    command.ExecuteNonQuery();
                   
                }
                MessageBox.Show("Lesson created", "Creation of Lesson", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var createlessons = GetCreateLesson();
                dataGridView1.DataSource = createlessons;
               
            }
            else
            {
                MessageBox.Show("Course name should be added", "Course Name Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }
        private List<CreateLesson> GetCreateLesson()
        {
            var createlessons = new List<CreateLesson>();
            using (var connection = new SqlConnection(@"Server=UMID\SQL;Database=Mssqldb;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var command = connection.CreateCommand();
                command.CommandText = @"Select * from CreateLesson";
                connection.Open();
                var dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var createlesson = new CreateLesson();
                    var coursename = dr.GetString(0);
                    var teachernamesurname = dr.GetString(1);
                    var startdate = dr.GetDateTime(2);
                    var enddate = dr.GetDateTime(3);
                    var weekdays= dr.GetString(4);
                    createlesson.CourseName = coursename;
                    createlesson.Teacher_Name_Surname= teachernamesurname;
                    createlesson.StartDate = startdate.ToString("dd.MM.yyyy");
                    createlesson.EndDate = enddate.ToString("dd.MM.yyyy");
                    createlesson.Weekdays= weekdays;
                    createlessons.Add(createlesson);

                    
                }

            }
            return createlessons;
        }
    }
}
