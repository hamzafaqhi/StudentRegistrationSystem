using StudentRegistrationSystem.screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        int panelWidth;
        bool hidden;
        
        public MainForm()
        {
            InitializeComponent();
            panelWidth = panelslide.Width;
            hidden = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_std_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            registered_students student = new registered_students();
            student.Show();

        }

        private void btn_teach_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registered_teachers teacher = new Registered_teachers();
            teacher.Show();

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_registraton admin = new admin_registraton();
            admin.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelslide.Width = panelslide.Width + 10;
                if (panelslide.Width >= panelWidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();

                }
            }
            else
            {
                panelslide.Width = panelslide.Width - 10;
                if (panelslide.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }

            }
        }

        private void coursesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Course c = new Course();
            c.Show();
        }

        private void coursesassignbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignCourses ac = new AssignCourses();
            ac.Show();
        }

       
    }
}
