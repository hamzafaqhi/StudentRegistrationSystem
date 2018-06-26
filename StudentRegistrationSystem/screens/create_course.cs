using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentRegistrationSystem.DbSqlServer;


namespace StudentRegistrationSystem.screens
{
    public partial class create_course : MaterialSkin.Controls.MaterialForm
    {
        
        public create_course()
        {
            InitializeComponent();
        }
        String crs_name, crs_fee, id;
        public create_course(String id,String crs_name,String crs_fee)
        {
            InitializeComponent();
            flag = 1;
            crs_nametext.Text = crs_name;
            crs_feetext.Text = crs_fee;
            this.id = id;
            
        }
       
        int flag = 0;
        sqlconnection con = new sqlconnection();
        int j = 0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void save()
        {
            if (crs_nametext.Text == "" || crs_feetext.Text == "")
            {

                MessageBox.Show("One or more Fields are Empty..!");


            }

            else
            {
                if (flag == 0)
                {

                    con.openconn();


                    {

                        SqlCommand cmd = new SqlCommand("INSERT INTO course(coursename,coursefee) VALUES ('" + crs_nametext.Text + "','" + crs_feetext.Text + "')", con.openconn());

                        j = cmd.ExecuteNonQuery();
                        if (j > 0)
                        {
                            MessageBox.Show("Record Save Successfully!");



                        }

                    }

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update course set coursename='" + crs_nametext.Text + "','" + crs_feetext.Text + "' where courseid = '" + id + "'", con.openconn());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!");
                }
                con.connclose();
                Course c = new Course();
                c.Show();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Show();
            this.Dispose();
        }

        private void create_course_Load(object sender, EventArgs e)
        {
            
        }
    }
}
