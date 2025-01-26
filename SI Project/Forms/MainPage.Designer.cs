namespace SI_Project
{
    partial class MainPage
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
            CloseButton = new Button();
            connectionEtat = new Label();
            student_sec = new Button();
            teachers_sec = new Button();
            admin_sec = new Button();
            studentlabel = new Label();
            teacherslabel = new Label();
            adminslabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backbutton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.BackgroundImage = Properties.Resources.Iconsmind_Outline_Close_512;
            CloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.ForeColor = Color.Transparent;
            CloseButton.Location = new Point(1039, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(10, 10);
            CloseButton.TabIndex = 3;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // connectionEtat
            // 
            connectionEtat.AutoSize = true;
            connectionEtat.BackColor = Color.Transparent;
            connectionEtat.FlatStyle = FlatStyle.Flat;
            connectionEtat.ForeColor = Color.White;
            connectionEtat.Location = new Point(12, 485);
            connectionEtat.Name = "connectionEtat";
            connectionEtat.Size = new Size(16, 15);
            connectionEtat.TabIndex = 4;
            connectionEtat.Text = "...";
            connectionEtat.TextAlign = ContentAlignment.MiddleCenter;
            connectionEtat.Click += label1_Click;
            // 
            // student_sec
            // 
            student_sec.BackColor = Color.LightCoral;
            student_sec.BackgroundImage = Properties.Resources.Students;
            student_sec.BackgroundImageLayout = ImageLayout.Zoom;
            student_sec.Cursor = Cursors.Hand;
            student_sec.FlatAppearance.BorderColor = Color.LightCoral;
            student_sec.FlatAppearance.BorderSize = 0;
            student_sec.FlatAppearance.MouseOverBackColor = Color.Maroon;
            student_sec.FlatStyle = FlatStyle.Flat;
            student_sec.Location = new Point(84, 110);
            student_sec.Name = "student_sec";
            student_sec.Size = new Size(93, 56);
            student_sec.TabIndex = 5;
            student_sec.UseVisualStyleBackColor = false;
            student_sec.Click += student_sec_Click;
            // 
            // teachers_sec
            // 
            teachers_sec.BackColor = Color.LightCoral;
            teachers_sec.BackgroundImage = Properties.Resources.Teachers;
            teachers_sec.BackgroundImageLayout = ImageLayout.Zoom;
            teachers_sec.Cursor = Cursors.Hand;
            teachers_sec.FlatAppearance.BorderColor = Color.LightCoral;
            teachers_sec.FlatAppearance.BorderSize = 0;
            teachers_sec.FlatAppearance.MouseOverBackColor = Color.Maroon;
            teachers_sec.FlatStyle = FlatStyle.Flat;
            teachers_sec.Location = new Point(84, 202);
            teachers_sec.Name = "teachers_sec";
            teachers_sec.Size = new Size(93, 56);
            teachers_sec.TabIndex = 6;
            teachers_sec.UseVisualStyleBackColor = false;
            teachers_sec.Click += teachers_sec_Click;
            // 
            // admin_sec
            // 
            admin_sec.BackColor = Color.LightCoral;
            admin_sec.BackgroundImage = Properties.Resources.Management;
            admin_sec.BackgroundImageLayout = ImageLayout.Zoom;
            admin_sec.Cursor = Cursors.Hand;
            admin_sec.FlatAppearance.BorderColor = Color.LightCoral;
            admin_sec.FlatAppearance.BorderSize = 0;
            admin_sec.FlatAppearance.MouseOverBackColor = Color.Maroon;
            admin_sec.FlatStyle = FlatStyle.Flat;
            admin_sec.Location = new Point(84, 296);
            admin_sec.Name = "admin_sec";
            admin_sec.Size = new Size(93, 56);
            admin_sec.TabIndex = 7;
            admin_sec.UseVisualStyleBackColor = false;
            admin_sec.Click += admin_sec_Click;
            // 
            // studentlabel
            // 
            studentlabel.AutoSize = true;
            studentlabel.BackColor = Color.Transparent;
            studentlabel.Font = new Font("Segoe UI", 18F);
            studentlabel.ForeColor = Color.Snow;
            studentlabel.Location = new Point(183, 110);
            studentlabel.Name = "studentlabel";
            studentlabel.Size = new Size(193, 32);
            studentlabel.TabIndex = 8;
            studentlabel.Text = "Students Section";
            // 
            // teacherslabel
            // 
            teacherslabel.AutoSize = true;
            teacherslabel.BackColor = Color.Transparent;
            teacherslabel.Font = new Font("Segoe UI", 18F);
            teacherslabel.ForeColor = Color.Snow;
            teacherslabel.Location = new Point(183, 202);
            teacherslabel.Name = "teacherslabel";
            teacherslabel.Size = new Size(192, 32);
            teacherslabel.TabIndex = 9;
            teacherslabel.Text = "Teachers Section";
            teacherslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminslabel
            // 
            adminslabel.AutoSize = true;
            adminslabel.BackColor = Color.Transparent;
            adminslabel.Font = new Font("Segoe UI", 18F);
            adminslabel.ForeColor = Color.Snow;
            adminslabel.Location = new Point(183, 296);
            adminslabel.Name = "adminslabel";
            adminslabel.Size = new Size(256, 32);
            adminslabel.TabIndex = 10;
            adminslabel.Text = "Administration Section";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(183, 153);
            label1.Name = "label1";
            label1.Size = new Size(375, 30);
            label1.TabIndex = 11;
            label1.Text = "In the students section you will find everything related to student lists,\r\n certificates, reports, number of students and their groups.";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(183, 245);
            label2.Name = "label2";
            label2.Size = new Size(467, 30);
            label2.TabIndex = 12;
            label2.Text = "In the teachers section you will find everything related to professors’ lists,\r\n certificates, reports, number of professors, the groups they supervise, and their salaries.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(183, 339);
            label3.Name = "label3";
            label3.Size = new Size(477, 30);
            label3.TabIndex = 13;
            label3.Text = "In the administration section you will find everything related to the lists of administrators,\r\n certificates, reports, number of administrators and their salaries.";
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.LightCoral;
            backbutton.Cursor = Cursors.Hand;
            backbutton.FlatAppearance.BorderSize = 0;
            backbutton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.Location = new Point(766, 470);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(94, 30);
            backbutton.TabIndex = 14;
            backbutton.Text = "BACK";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1052, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1049, 503);
            Controls.Add(backbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(adminslabel);
            Controls.Add(teacherslabel);
            Controls.Add(studentlabel);
            Controls.Add(admin_sec);
            Controls.Add(teachers_sec);
            Controls.Add(student_sec);
            Controls.Add(connectionEtat);
            Controls.Add(CloseButton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Label connectionEtat;
        private Button student_sec;
        private Button teachers_sec;
        private Button admin_sec;
        private Label studentlabel;
        private Label teacherslabel;
        private Label adminslabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button backbutton;
        private PictureBox pictureBox1;
    }
}