

namespace SI_Project
{
    partial class AdminsSection
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            connectionEtat = new Label();
            CloseButton = new Button();
            backbutton = new Button();
            adminsMenu = new MenuStrip();
            administratorsListToolStripMenuItem = new ToolStripMenuItem();
            addAdministratorsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            showtables = new DataGridView();
            addbutton = new Button();
            deletebutton = new Button();
            Buttonback = new Button();
            nextButton = new Button();
            admintxtemail = new TextBox();
            admintxtname1 = new TextBox();
            admintxtname2 = new TextBox();
            admintxtnum = new TextBox();
            admincomborole = new ComboBox();
            admincombosalary = new ComboBox();
            AdminName1 = new Label();
            AdminName2 = new Label();
            AdminNum = new Label();
            AdminEmail = new Label();
            AdminRole = new Label();
            AdminSalary = new Label();
            pictureBox1 = new PictureBox();
            adminsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showtables).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // connectionEtat
            // 
            connectionEtat.AutoSize = true;
            connectionEtat.BackColor = Color.LightCoral;
            connectionEtat.FlatStyle = FlatStyle.Flat;
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
            // adminsMenu
            // 
            adminsMenu.AutoSize = false;
            adminsMenu.BackColor = Color.LightCoral;
            adminsMenu.BackgroundImageLayout = ImageLayout.Zoom;
            adminsMenu.Dock = DockStyle.None;
            adminsMenu.Font = new Font("Segoe UI", 12F);
            adminsMenu.GripMargin = new Padding(0);
            adminsMenu.ImageScalingSize = new Size(10, 10);
            adminsMenu.Items.AddRange(new ToolStripItem[] { administratorsListToolStripMenuItem, addAdministratorsToolStripMenuItem, reportsToolStripMenuItem });
            adminsMenu.LayoutStyle = ToolStripLayoutStyle.Table;
            adminsMenu.Location = new Point(0, 104);
            adminsMenu.Name = "adminsMenu";
            adminsMenu.RightToLeft = RightToLeft.No;
            adminsMenu.Size = new Size(202, 616);
            adminsMenu.TabIndex = 16;
            adminsMenu.Text = "Menu";
            adminsMenu.ItemClicked += menuStrip1_ItemClicked;
            // 
            // administratorsListToolStripMenuItem
            // 
            administratorsListToolStripMenuItem.Name = "administratorsListToolStripMenuItem";
            administratorsListToolStripMenuItem.Size = new Size(153, 25);
            administratorsListToolStripMenuItem.Text = "Administrators List";
            administratorsListToolStripMenuItem.Click += administratorsListToolStripMenuItem_Click;
            // 
            // addAdministratorsToolStripMenuItem
            // 
            addAdministratorsToolStripMenuItem.Name = "addAdministratorsToolStripMenuItem";
            addAdministratorsToolStripMenuItem.Size = new Size(157, 25);
            addAdministratorsToolStripMenuItem.Text = "Add Administrators";
            addAdministratorsToolStripMenuItem.Click += addAdministratorsToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(76, 25);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // showtables
            // 
            showtables.AllowUserToAddRows = false;
            showtables.AllowUserToDeleteRows = false;
            showtables.AllowUserToResizeColumns = false;
            showtables.AllowUserToResizeRows = false;
            showtables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showtables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showtables.BackgroundColor = Color.LightCoral;
            showtables.BorderStyle = BorderStyle.None;
            showtables.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = Color.Maroon;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            showtables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            showtables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showtables.Cursor = Cursors.NoMoveVert;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightCoral;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = Color.Maroon;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            showtables.DefaultCellStyle = dataGridViewCellStyle2;
            showtables.GridColor = Color.Maroon;
            showtables.Location = new Point(223, 134);
            showtables.Name = "showtables";
            showtables.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightCoral;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle3.SelectionForeColor = Color.Maroon;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            showtables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            showtables.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightCoral;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Firebrick;
            dataGridViewCellStyle4.SelectionForeColor = Color.Maroon;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            showtables.RowsDefaultCellStyle = dataGridViewCellStyle4;
            showtables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            showtables.Size = new Size(1015, 541);
            showtables.TabIndex = 18;
            showtables.Visible = false;
            showtables.CellContentClick += showtables_CellContentClick;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.LightCoral;
            addbutton.Cursor = Cursors.Hand;
            addbutton.FlatAppearance.BorderSize = 0;
            addbutton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            addbutton.FlatStyle = FlatStyle.Flat;
            addbutton.Location = new Point(783, 356);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 23);
            addbutton.TabIndex = 19;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Visible = false;
            addbutton.Click += addbutton_Click;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = Color.LightCoral;
            deletebutton.Cursor = Cursors.Hand;
            deletebutton.FlatAppearance.BorderSize = 0;
            deletebutton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Location = new Point(693, 356);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(75, 23);
            deletebutton.TabIndex = 20;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Visible = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // Buttonback
            // 
            Buttonback.BackColor = Color.LightCoral;
            Buttonback.Cursor = Cursors.Hand;
            Buttonback.FlatAppearance.BorderSize = 0;
            Buttonback.FlatAppearance.MouseOverBackColor = Color.Maroon;
            Buttonback.FlatStyle = FlatStyle.Flat;
            Buttonback.Location = new Point(250, 356);
            Buttonback.Name = "Buttonback";
            Buttonback.Size = new Size(23, 23);
            Buttonback.TabIndex = 21;
            Buttonback.Text = "<";
            Buttonback.UseVisualStyleBackColor = false;
            Buttonback.Visible = false;
            Buttonback.Click += Buttonback_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.LightCoral;
            nextButton.Cursor = Cursors.Hand;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatAppearance.MouseOverBackColor = Color.Maroon;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Location = new Point(279, 356);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(23, 23);
            nextButton.TabIndex = 22;
            nextButton.Text = ">";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Visible = false;
            nextButton.Click += nextButton_Click;
            // 
            // admintxtemail
            // 
            admintxtemail.Location = new Point(509, 227);
            admintxtemail.Name = "admintxtemail";
            admintxtemail.Size = new Size(198, 23);
            admintxtemail.TabIndex = 23;
            admintxtemail.Visible = false;
            // 
            // admintxtname1
            // 
            admintxtname1.Location = new Point(248, 178);
            admintxtname1.Name = "admintxtname1";
            admintxtname1.Size = new Size(198, 23);
            admintxtname1.TabIndex = 25;
            admintxtname1.Visible = false;
            admintxtname1.TextChanged += admintxtname1_TextChanged;
            // 
            // admintxtname2
            // 
            admintxtname2.Location = new Point(509, 178);
            admintxtname2.Name = "admintxtname2";
            admintxtname2.Size = new Size(198, 23);
            admintxtname2.TabIndex = 26;
            admintxtname2.Visible = false;
            admintxtname2.TextChanged += admintxtname2_TextChanged;
            // 
            // admintxtnum
            // 
            admintxtnum.Location = new Point(248, 227);
            admintxtnum.Name = "admintxtnum";
            admintxtnum.Size = new Size(198, 23);
            admintxtnum.TabIndex = 27;
            admintxtnum.Visible = false;
            // 
            // admincomborole
            // 
            admincomborole.FormattingEnabled = true;
            admincomborole.Location = new Point(250, 275);
            admincomborole.Name = "admincomborole";
            admincomborole.Size = new Size(198, 23);
            admincomborole.TabIndex = 28;
            admincomborole.Visible = false;
            // 
            // admincombosalary
            // 
            admincombosalary.FormattingEnabled = true;
            admincombosalary.Location = new Point(511, 275);
            admincombosalary.Name = "admincombosalary";
            admincombosalary.Size = new Size(198, 23);
            admincombosalary.TabIndex = 29;
            admincombosalary.Visible = false;
            // 
            // AdminName1
            // 
            AdminName1.AutoSize = true;
            AdminName1.BackColor = Color.White;
            AdminName1.FlatStyle = FlatStyle.Flat;
            AdminName1.Font = new Font("Segoe UI", 10F);
            AdminName1.Location = new Point(248, 156);
            AdminName1.Name = "AdminName1";
            AdminName1.Size = new Size(75, 19);
            AdminName1.TabIndex = 31;
            AdminName1.Text = "First Name";
            AdminName1.Visible = false;
            AdminName1.Click += label2_Click;
            // 
            // AdminName2
            // 
            AdminName2.AutoSize = true;
            AdminName2.BackColor = Color.White;
            AdminName2.FlatStyle = FlatStyle.Flat;
            AdminName2.Font = new Font("Segoe UI", 10F);
            AdminName2.Location = new Point(509, 156);
            AdminName2.Name = "AdminName2";
            AdminName2.Size = new Size(74, 19);
            AdminName2.TabIndex = 32;
            AdminName2.Text = "Last Name";
            AdminName2.Visible = false;
            AdminName2.Click += label3_Click;
            // 
            // AdminNum
            // 
            AdminNum.AutoSize = true;
            AdminNum.BackColor = Color.White;
            AdminNum.FlatStyle = FlatStyle.Flat;
            AdminNum.Font = new Font("Segoe UI", 10F);
            AdminNum.Location = new Point(248, 205);
            AdminNum.Name = "AdminNum";
            AdminNum.Size = new Size(102, 19);
            AdminNum.TabIndex = 33;
            AdminNum.Text = "Phone Number";
            AdminNum.Visible = false;
            AdminNum.Click += label4_Click;
            // 
            // AdminEmail
            // 
            AdminEmail.AutoSize = true;
            AdminEmail.BackColor = Color.White;
            AdminEmail.FlatStyle = FlatStyle.Flat;
            AdminEmail.Font = new Font("Segoe UI", 10F);
            AdminEmail.Location = new Point(509, 205);
            AdminEmail.Name = "AdminEmail";
            AdminEmail.Size = new Size(41, 19);
            AdminEmail.TabIndex = 34;
            AdminEmail.Text = "Email";
            AdminEmail.Visible = false;
            AdminEmail.Click += label5_Click;
            // 
            // AdminRole
            // 
            AdminRole.AutoSize = true;
            AdminRole.BackColor = Color.White;
            AdminRole.FlatStyle = FlatStyle.Flat;
            AdminRole.Font = new Font("Segoe UI", 10F);
            AdminRole.Location = new Point(250, 253);
            AdminRole.Name = "AdminRole";
            AdminRole.Size = new Size(35, 19);
            AdminRole.TabIndex = 35;
            AdminRole.Text = "Role";
            AdminRole.Visible = false;
            AdminRole.Click += label6_Click;
            // 
            // AdminSalary
            // 
            AdminSalary.AutoSize = true;
            AdminSalary.BackColor = Color.White;
            AdminSalary.FlatStyle = FlatStyle.Flat;
            AdminSalary.Font = new Font("Segoe UI", 10F);
            AdminSalary.Location = new Point(511, 253);
            AdminSalary.Name = "AdminSalary";
            AdminSalary.Size = new Size(45, 19);
            AdminSalary.TabIndex = 36;
            AdminSalary.Text = "Salary";
            AdminSalary.Visible = false;
            AdminSalary.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminsSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1280, 720);
            Controls.Add(admincombosalary);
            Controls.Add(admincomborole);
            Controls.Add(admintxtnum);
            Controls.Add(admintxtname2);
            Controls.Add(admintxtname1);
            Controls.Add(admintxtemail);
            Controls.Add(AdminSalary);
            Controls.Add(AdminRole);
            Controls.Add(AdminEmail);
            Controls.Add(AdminNum);
            Controls.Add(AdminName2);
            Controls.Add(AdminName1);
            Controls.Add(nextButton);
            Controls.Add(Buttonback);
            Controls.Add(deletebutton);
            Controls.Add(addbutton);
            Controls.Add(backbutton);
            Controls.Add(CloseButton);
            Controls.Add(connectionEtat);
            Controls.Add(adminsMenu);
            Controls.Add(showtables);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = adminsMenu;
            Name = "AdminsSection";
            Text = "Admins Section";
            Load += AdminsSection_Load;
            adminsMenu.ResumeLayout(false);
            adminsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showtables).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void admintxtname1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }



        #endregion

        private Label connectionEtat;
        private Button CloseButton;
        private Button backbutton;
        private MenuStrip adminsMenu;
        private ToolStripMenuItem addAdministratorsToolStripMenuItem;
        private ToolStripMenuItem administratorsListToolStripMenuItem;
        private DataGridView showtables;
        private Button addbutton;
        private Button deletebutton;
        private Button Buttonback;
        private Button nextButton;
        private TextBox admintxtemail;
        private TextBox admintxtname1;
        private TextBox admintxtname2;
        private TextBox admintxtnum;
        private ComboBox admincomborole;
        private ComboBox admincombosalary;
        private Label AdminName1;
        private Label AdminName2;
        private Label AdminNum;
        private Label AdminEmail;
        private Label AdminRole;
        private Label AdminSalary;
        private PictureBox pictureBox1;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}