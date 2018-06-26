using StudentRegistrationSystem.DbSqlServer;
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
using System.Data.SqlClient;
using System.IO;
namespace StudentRegistrationSystem
{
    public partial class teacher_registration : MaterialSkin.Controls.MaterialForm
    {
        public teacher_registration()
        {
            InitializeComponent();
        }
        SqlDataAdapter adpt;
        DataTable dts;
        sqlconnection con = new sqlconnection();
        string gender;
        int j = 0;
        int flag = 0;
        string id;

        //method for loading data from datagridview
          public teacher_registration(String first_name,String last_name,String father_name,String cnic,String email,String mobile,String course_name,String dob,String address,String gender,String city,String province,String country,String id)
        {
            flag = 1;
            this.id = id;
            InitializeComponent();
            text_tchname.Text = first_name;
            text_tchlastname.Text= last_name;
            text_tchfathername.Text = father_name;
           text_tchCNIC.Text = cnic;
            text_tchemail.Text = email;
            text_tchmobile.Text = mobile;
            combo_course.Text = course_name;
            tchdob.Text = dob;
            text_tchaddress.Text = address;
            if (gender == "Male")
            {
                rdn_tchmale.Checked = true;
            }
            else
            {
                rdn_tchfemale.Checked = true;
            }
            combo_tchcity.Text = city;
            combo_tchprovince.Text = province;
            combo_tchcountry.Text = country;



        }

        //method to load data in combo box
        public void showcountry()
        {
            adpt = new SqlDataAdapter("select country_id,country_name from country", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_tchcountry.DataSource = dts;
            combo_tchcountry.DisplayMember = "country_name";
            combo_tchcountry.ValueMember = "country_id";

        }
        public void showcity()
        {
            adpt = new SqlDataAdapter("select city_id,cityname from city", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_tchcity.DataSource = dts;
            combo_tchcity.DisplayMember = "cityname";
            combo_tchcity.ValueMember = "city_id";

        }

        public void showprovince()
        {
            adpt = new SqlDataAdapter("select province_id,province_name from province", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_tchprovince.DataSource = dts;
            combo_tchprovince.DisplayMember = "province_name";
            combo_tchprovince.ValueMember = "province_id";

        }

        public void showcourse()
        {
            adpt = new SqlDataAdapter("select courseid,Coursename from course", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_course.DataSource = dts;
            combo_course.DisplayMember = "Coursename";
            combo_course.ValueMember = "courseid";

        }


        public void save()
        {
            if ((text_tchname.Text == "") || (text_tchlastname.Text == "") || (text_tchfathername.Text == "") ||
            (text_tchCNIC.Text == "") || (text_tchemail.Text == "") || (text_tchmobile.Text == "") ||

             (combo_course.Text == "") || (tchdob.Text == "") || (text_tchaddress.Text == "") || (combo_tchprovince.Text == "") || (combo_tchcity.Text == "") || (combo_tchcountry.Text == "")

            || (tchpictureBox.Image == null) ||
            (rdn_tchmale.Checked == false) && (rdn_tchfemale.Checked == false))
            {

                MessageBox.Show("One or more Fields are Empty..!");


            }

            else
            {

                con.openconn();
                if (flag == 0)
                {
                    if (rdn_tchmale.Checked)
                    {
                        gender = "Male";

                    }
                    else
                    {
                        gender = "Female";
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO Teacher(fname,lname,fathername,cnic,email,mobile,crsid,dateofbirth,address,gender,con_id,c_id,pro_id,pic) VALUES ('" + text_tchname.Text + "','" + text_tchlastname.Text + "','" + text_tchfathername.Text + "','" + text_tchCNIC.Text + "','" + text_tchemail.Text + "','" + text_tchmobile.Text + "','" + Convert.ToInt32(combo_course.SelectedValue.ToString()) + "','" + Convert.ToDateTime(tchdob.Text) + "','" + text_tchaddress.Text + "','" + gender + "','" + Convert.ToInt32(combo_tchcountry.SelectedValue.ToString()) + "','" + Convert.ToInt32(combo_tchcity.SelectedValue.ToString()) + "','" + Convert.ToInt32(combo_tchprovince.SelectedValue.ToString()) + "',@pic)", con.openconn());
                    MemoryStream stream = new MemoryStream();
                    tchpictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@pic", pic);
                    j = cmd.ExecuteNonQuery();
                    if (j > 0)
                    {
                        MessageBox.Show("Record Save Successfully!");



                    }
                   
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update Teacher set fname='"+text_tchname.Text+"', lname='"+text_tchlastname.Text+"',fathername='"+ text_tchfathername.Text +"',cnic='"+ text_tchCNIC.Text + "',email='"+ text_tchemail.Text +"', mobile='" + text_tchmobile.Text +"', pic='" + tchpictureBox.Image +"',crsid='"+combo_course.SelectedValue.ToString()+"',dateofbirth='"+ Convert.ToDateTime(tchdob.Text) + "',address='"+ text_tchaddress.Text +"',gender='"+ gender+ "',con_id='"+ Convert.ToInt32(combo_tchcountry.SelectedValue) +"',pro_id='" + Convert.ToInt32(combo_tchprovince.SelectedValue) +"',c_id='" + Convert.ToInt32(combo_tchcity.SelectedValue)+ "' Where teacherid = '"+id+"'" ,con.openconn());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update Successfully!");
                    Registered_teachers r = new Registered_teachers();
                    r.Show();
                    this.Dispose();

                }
                con.connclose();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registered_teachers obj = new Registered_teachers();
            obj.Show();

        }

        private void teacher_registration_Load(object sender, EventArgs e)
        {
            showcity();
            showcountry();
            showcourse();
            showprovince();
        }

        private void tchpictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Select Image (*.png;*.jpg;*|*.png*;.jpg;*)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tchpictureBox.Image = new Bitmap(ofd.FileName);
            }
        }

        private void rdn_tchmale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdn_tchfemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            text_tchname.Clear();
            text_tchlastname.Clear();
            text_tchfathername.Clear();
            text_tchCNIC.Clear();
            text_tchCNIC.Clear();
            text_tchaddress.Clear();
            text_tchmobile.Clear();
            text_tchname.Focus();
            combo_tchcity.Text = "";
            combo_course.Text = "";
            combo_tchprovince.Text = "";
            combo_tchcountry.Text = "";
            tchdob.Text = null;
            rdn_tchfemale.Checked = false;
            rdn_tchmale.Checked = false;
            tchpictureBox.Image = null;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
