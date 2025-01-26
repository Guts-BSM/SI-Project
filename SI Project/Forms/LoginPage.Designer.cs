
namespace SI_Project
{
    partial class Login_page
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
            connectionEtat = new Label();
            loginbox = new GroupBox();
            logintxt2 = new TextBox();
            logintxt1 = new TextBox();
            LoginButton = new Button();
            loginText2 = new Label();
            loginText1 = new Label();
            CloseButton = new Button();
            pictureBox1 = new PictureBox();
            loginbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // connectionEtat
            // 
            connectionEtat.AutoSize = true;
            connectionEtat.BackColor = Color.Transparent;
            connectionEtat.ForeColor = Color.Black;
            connectionEtat.Location = new Point(12, 2);
            connectionEtat.Name = "connectionEtat";
            connectionEtat.Size = new Size(16, 15);
            connectionEtat.TabIndex = 0;
            connectionEtat.Text = "...";
            connectionEtat.Click += label1_Click;
            // 
            // loginbox
            // 
            loginbox.BackColor = Color.Transparent;
            loginbox.BackgroundImageLayout = ImageLayout.None;
            loginbox.Controls.Add(logintxt2);
            loginbox.Controls.Add(logintxt1);
            loginbox.Controls.Add(LoginButton);
            loginbox.Controls.Add(loginText2);
            loginbox.Controls.Add(loginText1);
            loginbox.FlatStyle = FlatStyle.Popup;
            loginbox.Font = new Font("Segoe UI", 18F);
            loginbox.ForeColor = Color.Snow;
            loginbox.Location = new Point(378, 38);
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(346, 254);
            loginbox.TabIndex = 1;
            loginbox.TabStop = false;
            loginbox.Text = "Login";
            loginbox.Enter += groupBox1_Enter;
            // 
            // logintxt2
            // 
            logintxt2.Cursor = Cursors.IBeam;
            logintxt2.Font = new Font("Segoe UI", 12F);
            logintxt2.Location = new Point(72, 144);
            logintxt2.Name = "logintxt2";
            logintxt2.PasswordChar = '*';
            logintxt2.Size = new Size(203, 29);
            logintxt2.TabIndex = 4;
            logintxt2.TextChanged += logintxt2_TextChanged;
            // 
            // logintxt1
            // 
            logintxt1.Cursor = Cursors.IBeam;
            logintxt1.Font = new Font("Segoe UI", 12F);
            logintxt1.Location = new Point(72, 61);
            logintxt1.Name = "logintxt1";
            logintxt1.Size = new Size(203, 29);
            logintxt1.TabIndex = 3;
            logintxt1.TextChanged += logintxt1_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.FlatAppearance.BorderColor = Color.LightCoral;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 14F);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(20, 202);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(307, 34);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // loginText2
            // 
            loginText2.AutoSize = true;
            loginText2.BackColor = Color.Transparent;
            loginText2.FlatStyle = FlatStyle.Flat;
            loginText2.Font = new Font("Segoe UI", 14F);
            loginText2.Location = new Point(6, 116);
            loginText2.Name = "loginText2";
            loginText2.Size = new Size(91, 25);
            loginText2.TabIndex = 1;
            loginText2.Text = "Password";
            loginText2.TextAlign = ContentAlignment.MiddleCenter;
            loginText2.Click += loginText2_Click;
            // 
            // loginText1
            // 
            loginText1.AutoSize = true;
            loginText1.BackColor = Color.Transparent;
            loginText1.FlatStyle = FlatStyle.Flat;
            loginText1.Font = new Font("Segoe UI", 14F);
            loginText1.Location = new Point(6, 33);
            loginText1.Name = "loginText1";
            loginText1.Size = new Size(97, 25);
            loginText1.TabIndex = 0;
            loginText1.Text = "Username";
            loginText1.TextAlign = ContentAlignment.MiddleCenter;
            loginText1.Click += label1_Click_1;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Red;
            CloseButton.BackgroundImage = Properties.Resources.Iconsmind_Outline_Close_512;
            CloseButton.BackgroundImageLayout = ImageLayout.Zoom;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatStyle = FlatStyle.Popup;
            CloseButton.ForeColor = Color.Transparent;
            CloseButton.Location = new Point(772, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(10, 10);
            CloseButton.TabIndex = 2;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.fn_final_logo;
            pictureBox1.Location = new Point(49, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(783, 342);
            Controls.Add(pictureBox1);
            Controls.Add(CloseButton);
            Controls.Add(loginbox);
            Controls.Add(connectionEtat);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_page";
            Text = "Privet School";
            Load += Login_page_Load;
            loginbox.ResumeLayout(false);
            loginbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void loginText2_Click(object sender, EventArgs e)
        {
            
        }

        private void logintxt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void logintxt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Label connectionEtat;
        private GroupBox loginbox;
        private TextBox logintxt2;
        private TextBox logintxt1;
        private Button LoginButton;
        private Label loginText2;
        private Label loginText1;
        private Button CloseButton;
        private PictureBox pictureBox1;
    }
}
