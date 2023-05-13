namespace CourseManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Courses = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.Lessons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1069, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Management Portal";
            // 
            // Courses
            // 
            this.Courses.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Courses.ForeColor = System.Drawing.Color.DarkCyan;
            this.Courses.Location = new System.Drawing.Point(815, 212);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(319, 69);
            this.Courses.TabIndex = 1;
            this.Courses.Text = "Courses";
            this.Courses.UseVisualStyleBackColor = true;
            this.Courses.Click += new System.EventHandler(this.Courses_Click);
            // 
            // Students
            // 
            this.Students.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Students.ForeColor = System.Drawing.Color.DarkCyan;
            this.Students.Location = new System.Drawing.Point(1213, 212);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(319, 69);
            this.Students.TabIndex = 2;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Teachers
            // 
            this.Teachers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Teachers.ForeColor = System.Drawing.Color.DarkCyan;
            this.Teachers.Location = new System.Drawing.Point(1605, 212);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(319, 69);
            this.Teachers.TabIndex = 3;
            this.Teachers.Text = "Teachers";
            this.Teachers.UseVisualStyleBackColor = true;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Lessons
            // 
            this.Lessons.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lessons.ForeColor = System.Drawing.Color.DarkCyan;
            this.Lessons.Location = new System.Drawing.Point(1213, 442);
            this.Lessons.Name = "Lessons";
            this.Lessons.Size = new System.Drawing.Size(319, 90);
            this.Lessons.TabIndex = 4;
            this.Lessons.Text = "Create Lessons";
            this.Lessons.UseVisualStyleBackColor = true;
            this.Lessons.Click += new System.EventHandler(this.Lessons_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(2076, 1133);
            this.Controls.Add(this.Lessons);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Courses;
        private Button Students;
        private Button Teachers;
        private Button Lessons;
    }
}