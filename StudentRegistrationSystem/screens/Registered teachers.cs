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
    public partial class Registered_teachers : MaterialSkin.Controls.MaterialForm
    {
        public Registered_teachers()
        {
            InitializeComponent();
        }
        SqlDataAdapter adpt;
        DataTable dt;
        sqlconnection con = new sqlconnection();
        String first_name, last_name, father_name, cnic, email, mobile, course_name, dob, address, gender, city, province, country, id;

        private void btntch_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher_registration teach = new teacher_registration();
            teach.Show();

        }

        private void btntch_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void btntch_delete_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("Delete from teacher Where teacherid = '" + id + "'", con.openconn());
            command.ExecuteNonQuery();
            this.Dispose();
            Registered_teachers t = new Registered_teachers();
            t.Show();
        }

        private void Getdata_Click(object sender, EventArgs e)
        {
          
        }

        private void Registered_teachers_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select teacherid,fname,lname,fathername,cnic,email,mobile,Coursename,dateofbirth,address,gender,cityname,Province_name, country_name from  teacher t INNER JOIN city C ON t.c_id = C.city_id INNER JOIN country CO ON t.con_id = CO.country_id INNER JOIN course CL ON t.crsid = CL.courseid INNER JOIN province P ON t.pro_id = P.province_id", con.openconn());
            dt = new DataTable();

            adpt.Fill(dt);

            tchdata.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = tchdata.Rows[index];
            id = selectedRow.Cells[0].Value.ToString();
            first_name = selectedRow.Cells[1].Value.ToString();
            last_name = selectedRow.Cells[2].Value.ToString();
            father_name = selectedRow.Cells[3].Value.ToString();
            cnic = selectedRow.Cells[4].Value.ToString();
            email = selectedRow.Cells[5].Value.ToString();
            mobile = selectedRow.Cells[6].Value.ToString();
            course_name = selectedRow.Cells[7].Value.ToString();
            dob = selectedRow.Cells[8].Value.ToString();
            address = selectedRow.Cells[9].Value.ToString();
            gender = selectedRow.Cells[10].Value.ToString();
            city = selectedRow.Cells[11].Value.ToString();
            province = selectedRow.Cells[12].Value.ToString();
            country = selectedRow.Cells[13].Value.ToString();

        }

        private void btntc_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacher_registration t = new teacher_registration(first_name, last_name, father_name, cnic, email, mobile, course_name, dob, address, gender, city, province, country, id);
            t.Show();  
        }

        private void Clear(object sender, EventArgs e)
        {
            this.Hide();
            teacher_registration t = new teacher_registration(first_name, last_name, father_name, cnic, email, mobile, course_name, dob, address, gender, city, province, country, id);
            t.Show();  
        }
    }
   }

