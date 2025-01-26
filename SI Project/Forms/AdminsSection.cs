using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SI_Project
{
    public partial class AdminsSection : Form
    {
        private List<Admin> admins;
        private int currentIndex = -1;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private OleDbConnection connection = new OleDbConnection();
        private class Admin
        {
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
            public required string PhoneNumber { get; set; }
            public required string Email { get; set; }
            public required string Role { get; set; }
            public decimal Salary { get; set; }
        }

        public AdminsSection()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\C#\SI Project\SI_Project.accdb;Persist Security Info=False;";
            this.MouseDown += new MouseEventHandler(AdminsSection_MouseDown);
            this.MouseMove += new MouseEventHandler(AdminsSection_MouseMove);
            this.MouseUp += new MouseEventHandler(AdminsSection_MouseUp);
            LoadRecords();
        }

        private void LoadRecords()
        {
            admins = new List<Admin>();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT [First Name], [Last Name], [Phone Number], [Email], [Role], [Salary] FROM Admins", connection);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Admin admin = new Admin
                    {
                        FirstName = reader["First Name"].ToString(),
                        LastName = reader["Last Name"].ToString(),
                        PhoneNumber = reader["Phone Number"].ToString(),
                        Email = reader["Email"].ToString(),
                        Role = reader["Role"].ToString(),
                        Salary = reader.GetInt32(reader.GetOrdinal("Salary"))
                    };
                    admins.Add(admin);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            if (admins.Count > 0)
            {
                currentIndex = 0;
                DisplayCurrentRecord();
            }
        }

        private void AdminsSection_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }
        private void AdminsSection_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void AdminsSection_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Color color1 = Color.Maroon;
            Color color2 = Color.LightCoral;
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }

        private void AdminsSection_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connectionEtat.ForeColor = Color.Green;
                connectionEtat.Text = "Connected.";
                connection.Close();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine($"Database connection error: {ex.Message}");
                connectionEtat.Text = "Not Connected. Database error.";
                connectionEtat.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                connectionEtat.Text = "Not Connected. An unexpected error occurred.";
                connectionEtat.ForeColor = Color.Red;
            }

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand($"SELECT DISTINCT ROLES FROM ROLE", connection);
                OleDbDataReader reader = command.ExecuteReader();

                admincomborole.Items.Clear();
                while (reader.Read())
                {
                    string value = reader["ROLES"].ToString();
                    admincomborole.Items.Add(value);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand($"SELECT DISTINCT SALARY FROM SALARY", connection);
                OleDbDataReader reader = command.ExecuteReader();

                admincombosalary.Items.Clear();
                while (reader.Read())
                {
                    string value = reader["SALARY"].ToString();
                    admincombosalary.Items.Add(value);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            Application.Exit();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            Hide();
            mainPage.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void administratorsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showtables.Size = new Size(1015, 541);
            showtables.Location = new Point(223, 143);
            AdminName1.Visible = false;
            AdminName2.Visible = false;
            AdminNum.Visible = false;
            AdminEmail.Visible = false;
            AdminRole.Visible = false;
            AdminSalary.Visible = false;
            admintxtname1.Visible = false;
            admintxtname2.Visible = false;
            admintxtnum.Visible = false;
            admintxtemail.Visible = false;
            admincomborole.Visible = false;
            admincombosalary.Visible = false;
            Buttonback.Visible = false;
            nextButton.Visible = false;
            deletebutton.Visible = false;
            addbutton.Visible = false;
            try
            {
                connection.Open();
                showtables.Visible = true;
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Admins", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                showtables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            connection.Close();
        }
        private void readerlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showtables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM Admins WHERE [First Name] = @firstName AND [Last Name] = @lastName AND [Phone Number] = @phoneNumber " +
                    "AND [Email] = @email AND [Role] = @role AND [Salary] = @salary";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", admintxtname1.Text);
                    command.Parameters.AddWithValue("@lastName", admintxtname2.Text);
                    command.Parameters.AddWithValue("@phoneNumber", admintxtnum.Text);
                    command.Parameters.AddWithValue("@email", admintxtemail.Text);
                    command.Parameters.AddWithValue("@role", admincomborole.Text);
                    command.Parameters.AddWithValue("@salary", admincombosalary.Text);

                    command.ExecuteNonQuery();
                    connectionEtat.Text = "Data inserted successfully.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();

            try
            {
                connection.Open();
                showtables.Visible = true;
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Admins", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                showtables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();
        }

        private void addAdministratorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showtables.Size = new Size(1015, 200);
            showtables.Location = new Point(223, 400);
            AdminName1.Visible = true;
            AdminName2.Visible = true;
            AdminNum.Visible = true;
            AdminEmail.Visible = true;
            AdminRole.Visible = true;
            AdminSalary.Visible = true;
            admintxtname1.Visible = true;
            admintxtname2.Visible = true;
            admintxtnum.Visible = true;
            admintxtemail.Visible = true;
            admincomborole.Visible = true;
            admincombosalary.Visible = true;
            Buttonback.Visible = true;
            nextButton.Visible = true;
            deletebutton.Visible = true;
            addbutton.Visible = true;

            try
            {
                connection.Open();
                showtables.Visible = true;
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Admins", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                showtables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            connection.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Admins ([First Name], [Last Name], [Phone Number], [Email], [Role], [Salary]) " +
                               "VALUES (@firstName, @lastName, @phoneNumber, @email, @role, @salary)";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", admintxtname1.Text);
                    command.Parameters.AddWithValue("@lastName", admintxtname2.Text);
                    command.Parameters.AddWithValue("@phoneNumber", admintxtnum.Text);
                    command.Parameters.AddWithValue("@email", admintxtemail.Text);
                    command.Parameters.AddWithValue("@role", admincomborole.Text);
                    command.Parameters.AddWithValue("@salary", admincombosalary.Text);

                    command.ExecuteNonQuery();
                    connectionEtat.Text = "Data inserted successfully.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();

            try
            {
                connection.Open();
                showtables.Visible = true;
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Admins", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                showtables.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            connection.Close();

            admins = new List<Admin>();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void admintxtname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addAdministratorsRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DisplayCurrentRecord()
        {
            if (currentIndex >= 0 && currentIndex < admins.Count)
            {
                var admin = admins[currentIndex];
                admintxtname1.Text = admin.FirstName;
                admintxtname2.Text = admin.LastName;
                admintxtnum.Text = admin.PhoneNumber;
                admintxtemail.Text = admin.Email;
                admincomborole.Text = admin.Role;
                admincombosalary.Text = admin.Salary.ToString();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < admins.Count - 1)
            {
                currentIndex++;
                DisplayCurrentRecord();
            }
            else
            {
                MessageBox.Show("You are at the last record.");
            }
        }

        private void Buttonback_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentRecord();
            }
            else
            {
                MessageBox.Show("You are at the first record.");
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showtables.Size = new Size(1015, 200);
            showtables.Location = new Point(223, 400);
            AdminName1.Visible = true;
            AdminName2.Visible = true;
            AdminNum.Visible = true;
            AdminEmail.Visible = true;
            AdminRole.Visible = true;
            AdminSalary.Visible = true;
            admintxtname1.Visible = true;
            admintxtname2.Visible = true;
            admintxtnum.Visible = true;
            admintxtemail.Visible = true;
            admincomborole.Visible = true;
            admincombosalary.Visible = true;
            Buttonback.Visible = true;
            nextButton.Visible = true;
            deletebutton.Visible = true;
            addbutton.Visible = true;
        }
    }
}
