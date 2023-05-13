using Microsoft.Data.SqlClient;
using System.Drawing.Text;

namespace CourseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            Courses c= new Courses();
            c.Show();
           
        }

        private void Students_Click(object sender, EventArgs e)
        {
            Student_Form s = new Student_Form();
            s.Show();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Show();
        }

        private void Lessons_Click(object sender, EventArgs e)
        {
            Lesson l = new Lesson();
            l.Show();
        }
    }
}