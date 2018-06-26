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
    public partial class registered_students : MaterialSkin.Controls.MaterialForm
    {
        public registered_students()
        {
            InitializeComponent();
        }
        SqlDataAdapter adpt;
        DataTable dt;
        sqlconnection con = new sqlconnection();
        String first_name, last_name, father_name, father_id, email, mobile, class_name, dob, address, gender, city, province, country, id;
        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_registration std = new Student_registration();
            std.Show();
        }

        private void registered_students_Load(object sender, EventArgs e)
        {

            adpt = new SqlDataAdapter("select Studentid,Firstname,Lastname,Fathername,Fatherid,Email,Mobileno,Class_name,Datefbirth,Address,Gender,cityname,Province_name, country_name from  Student S INNER JOIN city C ON S.CityID = C.city_id INNER JOIN country CO ON S.CountryID = CO.country_id INNER JOIN Class CL ON S.Class = CL.Classid INNER JOIN province P ON S.ProvinceID = P.province_id", con.openconn());
            dt = new DataTable();

            adpt.Fill(dt);

            std_dgv.DataSource = dt;
        }

        private void btnrgd_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }


       
        private void btnrgd_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_registration s = new Student_registration(first_name, last_name, father_name, father_id, email, mobile, class_name, dob, address, gender, city, province, country, id);
            s.Show();  
                
        }
     

       private void btnrgd_delete_Click(object sender, EventArgs e)
       {
          SqlCommand command = new SqlCommand("Delete from Student Where Studentid = '" + id+ "'", con.openconn());
          command.ExecuteNonQuery();
           this.Dispose();
           registered_students r= new registered_students();
           r.Show();
         
       }

       private void std_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       private void std_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
       {
           int index = e.RowIndex;
           DataGridViewRow selectedRow = std_dgv.Rows[index];
           
           id= selectedRow.Cells[0].Value.ToString();
           first_name = selectedRow.Cells[1].Value.ToString();
           last_name = selectedRow.Cells[2].Value.ToString();
           father_name = selectedRow.Cells[3].Value.ToString();
           father_id = selectedRow.Cells[4].Value.ToString();
           email = selectedRow.Cells[5].Value.ToString();
           mobile = selectedRow.Cells[6].Value.ToString();
           class_name = selectedRow.Cells[7].Value.ToString();
           dob = selectedRow.Cells[8].Value.ToString();
           address = selectedRow.Cells[9].Value.ToString();
           gender = selectedRow.Cells[10].Value.ToString();
           city = selectedRow.Cells[11].Value.ToString();
           province = selectedRow.Cells[12].Value.ToString();
           country = selectedRow.Cells[13].Value.ToString();

          
       }
    }
}
