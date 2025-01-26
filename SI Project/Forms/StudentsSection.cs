using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Drawing2D;

namespace SI_Project
{
    public partial class StudentsSection : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private OleDbConnection connection = new OleDbConnection();
        public StudentsSection()
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
            Color color1 = Color.Maroon;
            Color color2 = Color.LightCoral;
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 45f))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }

        private void StudentsSection_Load(object sender, EventArgs e)
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
    }
}
