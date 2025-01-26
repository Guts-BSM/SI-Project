using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;

namespace SI_Project {
    public partial class Login_page : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private OleDbConnection connection = new OleDbConnection();
        public Login_page()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Projects\C#\SI Project\SI_Project.accdb;Persist Security Info=False;";
            this.MouseDown += new MouseEventHandler(AdminsSection_MouseDown);
            this.MouseMove += new MouseEventHandler(AdminsSection_MouseMove);
            this.MouseUp += new MouseEventHandler(AdminsSection_MouseUp);
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
            Color color1 = Color.Black;
            Color color2 = Color.Maroon;
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }
        private void Login_page_Load(object sender, EventArgs e)
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
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Login where User='" + logintxt1.Text + "' and Pass='" + logintxt2.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count >= 1)
            {
                connectionEtat.Text = "Connected and Login Successful";
                connectionEtat.ForeColor = Color.Green;
                connection.Close();
                connection.Dispose();
                Hide();
                MainPage mainPage = new MainPage();
                mainPage.ShowDialog();
            }
            else
            {
                connectionEtat.Text = "Login Failed.";
                connectionEtat.ForeColor = Color.Red;
                MessageBox.Show("Username or Password is incorrect.");
            }
            connection.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
