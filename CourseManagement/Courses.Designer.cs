namespace CourseManagement
{
    partial class Courses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labe1 = new System.Windows.Forms.Label();
            this.Name_ = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Duration_ = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Price_ = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Name2 = new System.Windows.Forms.Label();
            this.NameBox2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Duration2 = new System.Windows.Forms.Label();
            this.Price2 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(964, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.BackColor = System.Drawing.Color.Azure;
            this.labe1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labe1.Location = new System.Drawing.Point(1039, 81);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(203, 65);
            this.labe1.TabIndex = 1;
            this.labe1.Text = "Courses";
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_.Location = new System.Drawing.Point(49, 10);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(74, 30);
            this.Name_.TabIndex = 3;
            this.Name_.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(159, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(180, 31);
            this.NameBox.TabIndex = 4;
            // 
            // Duration_
            // 
            this.Duration_.AutoSize = true;
            this.Duration_.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Duration_.Location = new System.Drawing.Point(49, 60);
            this.Duration_.Name = "Duration_";
            this.Duration_.Size = new System.Drawing.Size(104, 30);
            this.Duration_.TabIndex = 5;
            this.Duration_.Text = "Duration";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 59);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(180, 31);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Price_
            // 
            this.Price_.AutoSize = true;
            this.Price_.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price_.Location = new System.Drawing.Point(49, 105);
            this.Price_.Name = "Price_";
            this.Price_.Size = new System.Drawing.Size(65, 30);
            this.Price_.TabIndex = 7;
            this.Price_.Text = "Price";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(159, 106);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(180, 31);
            this.PriceBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(282, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Name_);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.PriceBox);
            this.panel1.Controls.Add(this.Duration_);
            this.panel1.Controls.Add(this.Price_);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(646, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 207);
            this.panel1.TabIndex = 10;
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name2.Location = new System.Drawing.Point(29, 13);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(74, 30);
            this.Name2.TabIndex = 10;
            this.Name2.Text = "Name";
            // 
            // NameBox2
            // 
            this.NameBox2.Location = new System.Drawing.Point(144, 14);
            this.NameBox2.Name = "NameBox2";
            this.NameBox2.Size = new System.Drawing.Size(180, 31);
            this.NameBox2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 31);
            this.textBox2.TabIndex = 15;
            // 
            // Duration2
            // 
            this.Duration2.AutoSize = true;
            this.Duration2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Duration2.Location = new System.Drawing.Point(29, 61);
            this.Duration2.Name = "Duration2";
            this.Duration2.Size = new System.Drawing.Size(104, 30);
            this.Duration2.TabIndex = 12;
            this.Duration2.Text = "Duration";
            // 
            // Price2
            // 
            this.Price2.AutoSize = true;
            this.Price2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price2.Location = new System.Drawing.Point(29, 106);
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(65, 30);
            this.Price2.TabIndex = 14;
            this.Price2.Text = "Price";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(144, 60);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(180, 31);
            this.numericUpDown3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Name2);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.NameBox2);
            this.panel2.Controls.Add(this.Price2);
            this.panel2.Controls.Add(this.Duration2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(1062, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 206);
            this.panel2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SpringGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(287, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(1507, 666);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 53);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2103, 970);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labe1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labe1;
        private Label Name_;
        private TextBox NameBox;
        private Label Duration_;
        private NumericUpDown numericUpDown1;
        private Label Price_;
        private TextBox PriceBox;
        private Button button1;
        private Panel panel1;
        private Label Name2;
        private TextBox NameBox2;
        private TextBox textBox2;
        private Label Duration2;
        private Label Price2;
        private NumericUpDown numericUpDown3;
        private Panel panel2;
        private Button button2;
        private Button button3;
    }
}