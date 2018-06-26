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
using StudentRegistrationSystem.DbSqlServer;

namespace StudentRegistrationSystem
{
    public partial class Student_registration : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter adpt;
        DataTable dts;
        sqlconnection con = new sqlconnection();
        DataTable dt = new DataTable();
        string gender;
        int j=0;
        int flag = 0;
        public Student_registration()
        {
            InitializeComponent();
            showcountry();
            showcity();
            showprovince();
            showstdclass();
        }
        String id;
        public Student_registration(String first_name,String last_name,String father_name,String father_id,String email,String mobile,String class_name,String dob,String address,String gender,String city,String province,String country,String id)
        {   flag = 1;
        this.id = id;
            InitializeComponent();
            showcountry();
            showcity();
            showprovince();
            showstdclass();
            text_stdname.Text = first_name;
            text_lastname.Text = last_name;
            text_fathername.Text = father_name;
            text_fatherid.Text = father_id;
            text_email.Text = email;
            text_mobile.Text = mobile;
            combo_class.Text = class_name;
            dobpicker.Text = dob;
            text_address.Text = address;
            if (gender == "Male")
            {
                rdn_male.Checked = true;
            }
            else
            {
                rdn_female.Checked = true;
            }
            combo_city.Text = city;
            combo_province.Text = province;
            combo_country.Text = country;
            


        }
        //method for loading data in combo box
        public void showcountry()
        {
            adpt = new SqlDataAdapter("select country_id,country_name from country", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_country.DataSource = dts;
            combo_country.DisplayMember = "country_name";
            combo_country.ValueMember = "country_id";

        }
        public void showcity()
        {
            adpt = new SqlDataAdapter("select city_id,cityname from city", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_city.DataSource = dts;
            combo_city.DisplayMember = "cityname";
            combo_city.ValueMember = "city_id";

        }

        public void showprovince()
        {
            adpt = new SqlDataAdapter("select province_id,province_name from province", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_province.DataSource = dts;
            combo_province.DisplayMember = "province_name";
            combo_province.ValueMember = "province_id";

        }

        public void showstdclass()
        {
            adpt = new SqlDataAdapter("select Classid,Class_name from Class", con.openconn());
            dts = new DataTable();
            adpt.Fill(dts);
            combo_class.DataSource = dts;
            combo_class.DisplayMember = "Class_name";
            combo_class.ValueMember = "Classid";

        }

        //Method to insert data

        public void save()
        {
            adpt = new SqlDataAdapter("Select username from LoginTable",con.openconn());
            adpt.Fill(dt);
            con.connclose();
            int username = 0;
            for (int i = 0; i < dt.Rows.Count - 1;i++) {
                if(dt.Rows[i]["username"].ToString() == username_textbox.Text){
                    username =1;
                }
            }
                if ((text_stdname.Text == "") || (text_lastname.Text == "") || (text_fathername.Text == "") ||
                (text_fatherid.Text == "") || (text_email.Text == "") || (text_mobile.Text == "") ||

                 (combo_class.Text == "") || (dobpicker.Text == "") || (text_address.Text == "") || (combo_province.Text == "") || (combo_city.Text == "") || (combo_country.Text == "")

                || (StdpictureBox.Image == null) ||
                (rdn_male.Checked == false) && (rdn_female.Checked == false))
                {

                    MessageBox.Show("One or more Fields are Empty..!");


                }
                else if(username==1)
                { MessageBox.Show("Username Already Exits"); }
                else
                {
                    if (flag == 0)
                    {
                        con.openconn();
                        if (rdn_male.Checked)
                        {
                            gender = "Male";

                        }
                        else
                        {
                            gender = "Female";
                        }
                        SqlCommand cmd = new SqlCommand("INSERT INTO Student(Firstname,Lastname,Fathername,Fatherid,email,mobileno,Class,Datefbirth,Address,Gender,Countryid,Cityid,Provinceid,studentimage) VALUES ('" + text_stdname.Text + "','" + text_lastname.Text + "','" + text_fathername.Text + "','" + text_fatherid.Text + "','" + text_email.Text + "','" + text_mobile.Text + "','" + Convert.ToInt32(combo_class.SelectedValue) + "','" + Convert.ToDateTime(dobpicker.Text) + "','" + text_address.Text + "','" + gender + "','" + Convert.ToInt32(combo_country.SelectedValue) + "','" + Convert.ToInt32(combo_city.SelectedValue) + "','" + Convert.ToInt32(combo_province.SelectedValue) + "',@studentimage)", con.openconn());
                        MemoryStream stream = new MemoryStream();
                        StdpictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        String user= "User";
                        SqlCommand login_table = new SqlCommand("Insert into LoginTable(username,password,role) values ('" + username_textbox.Text + "','" + pass_textBox.Text + "','"+user+"')",con.openconn());
                        byte[] pic = stream.ToArray();
                        cmd.Parameters.AddWithValue("@studentimage", pic);
                        j = cmd.ExecuteNonQuery();
                        login_table.ExecuteNonQuery();
                        if (j > 0)
                        {
                            MessageBox.Show("Record Save Successfully!" + j + "Row");



                        }

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("update Student set Firstname='" + text_stdname.Text + "', Lastname='" + text_lastname.Text + "',Fathername='" + text_fathername.Text + "',Fatherid='" + text_fatherid.Text + "',Email='" + text_email.Text + "',Mobileno='" + text_mobile.Text + "',studentimage='" + StdpictureBox.Image + "',Class='" + combo_class.SelectedValue.ToString() + "',Datefbirth='" + Convert.ToDateTime(dobpicker.Text) + "',Address='" + text_address.Text + "',Gender='" + gender + "',CountryID='" + combo_country.SelectedValue.ToString() + "',ProvinceID='" + combo_province.SelectedValue.ToString() + "',CityID='" + combo_city.SelectedValue.ToString() + "' Where Studentid = '" + id + "'", con.openconn());
                        cmd.ExecuteNonQuery();

                    }
                    con.connclose();
                    registered_students r = new registered_students();
                    r.Show();
                    this.Dispose();
                }
        }
        
            
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            registered_students stu = new registered_students();
            stu.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StdpictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Select Image (*.png;*.jpg;*|*.png*;.jpg;*)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StdpictureBox.Image = new Bitmap(ofd.FileName);
            }
                
        }

        private void Student_registration_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void text_stdname_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void rdn_male_CheckedChanged(object sender, EventArgs e)
        {
            
            
                gender="Male";
            
        }

        private void rdn_female_CheckedChanged(object sender, EventArgs e)
        {
            gender="Female";


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void combo_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_class.Text = "";

        }

        private void combo_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_country.Text = "";
        }

        private void combo_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_city.Text = "";
        }

        private void combo_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_province.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            text_stdname.Clear();
            text_lastname.Clear();
            text_fathername.Clear();
            text_fatherid.Clear();
            text_email.Clear();
            text_address.Clear();
            text_mobile.Clear();
            text_stdname.Focus();
            combo_city.Text = "";
            combo_class.Text = "";
            combo_province.Text = "";
            combo_country.Text = "";
            dobpicker.Text = null;
            rdn_female.Checked = false;
            rdn_male.Checked = false;
            StdpictureBox.Image = null;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
