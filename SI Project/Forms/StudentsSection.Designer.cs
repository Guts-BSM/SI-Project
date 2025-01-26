using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Data;

namespace SI_Project
{
    partial class StudentsSection
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
            connectionEtat = new Label();
            CloseButton = new Button();
            backbutton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // connectionEtat
            // 
            connectionEtat.AutoSize = true;
            connectionEtat.BackColor = Color.Transparent;
            connectionEtat.ForeColor = Color.White;
            connectionEtat.Location = new Point(12, 700);
            connectionEtat.Name = "connectionEtat";
            connectionEtat.Size = new Size(16, 15);
            connectionEtat.TabIndex = 5;
            connectionEtat.Text = "...";
            connectionEtat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.BackgroundImage = Properties.Resources.Iconsmind_Outline_Close_512;
            CloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.ForeColor = Color.Transparent;
            CloseButton.Location = new Point(1268, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(10, 10);
            CloseButton.TabIndex = 6;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.LightCoral;
            backbutton.Cursor = Cursors.Hand;
            backbutton.FlatAppearance.BorderSize = 0;
            backbutton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            backbutton.FlatStyle = FlatStyle.Flat;
            backbutton.Location = new Point(1019, 685);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(94, 30);
            backbutton.TabIndex = 15;
            backbutton.Text = "BACK";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // StudentsSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1280, 720);
            Controls.Add(backbutton);
            Controls.Add(CloseButton);
            Controls.Add(connectionEtat);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentsSection";
            Text = "Students Section";
            Load += StudentsSection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label connectionEtat;
        private Button CloseButton;
        private Button backbutton;
        private PictureBox pictureBox1;
    }
}