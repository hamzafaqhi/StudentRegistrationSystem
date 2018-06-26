using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem.screens
{
    public partial class SplashScreen : MaterialSkin.Controls.MaterialForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();


            tmr.Interval = 3000;


            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            login l = new login();

            l.Show();

            //hide this form

            this.Hide();

        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
