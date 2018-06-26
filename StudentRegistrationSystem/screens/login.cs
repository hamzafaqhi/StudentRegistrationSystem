
using StudentRegistrationSystem.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using StudentRegistrationSystem.DbSqlServer;


namespace StudentRegistrationSystem.screens
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        public login()
        {
            InitializeComponent();
            
        }
      
        


        

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (IsFormValid())
            {
                sqlconnection con = new sqlconnection();
                SqlDataAdapter sda = new SqlDataAdapter(" Select Username,Password,Role from LoginTable where Username='" + usernametext.Text + "' and Password='" + passwordtext.Text + "' ", con.openconn());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Username"].ToString() == usernametext.Text && dt.Rows[i]["Password"].ToString() == passwordtext.Text)
                    {
                        flag = 1;
                        if (dt.Rows[i]["Role"].ToString() == "Admin")
                        {

                            this.Hide();
                            MainForm obj = new MainForm();
                            obj.Show();



                        }
                        else if (dt.Rows[i]["Role"].ToString() == "User")
                        {
                            this.Hide();
                            Student_registration obj1 = new Student_registration();
                            obj1.Show();

                        }
                    }
                   
                }
                 if(flag == 0)
                    {
                        MessageBox.Show("Invalid Username/Pasword");
                    }

            }
        }
          

        private bool IsFormValid()
        {
            if (usernametext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is requirred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametext.Clear();
                usernametext.Focus();
                return false;
            }

            if (passwordtext.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password  is requirred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametext.Clear();
                usernametext.Focus();
                return false;

            } 
            return true;
        }
            
        
        

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
