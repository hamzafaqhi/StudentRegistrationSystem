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
    public partial class AssignCourses : MaterialSkin.Controls.MaterialForm
    {
        public AssignCourses()
        {
            InitializeComponent();
        }
        SqlDataAdapter adpt;
        DataTable dts;
     sqlconnection con = new sqlconnection();
     string id;
     public void showteacher()
     {
         adpt = new SqlDataAdapter("select teacherid,fname from teacher", con.openconn());
         dts = new DataTable();
         
         adpt.Fill(dts);
         cmb_tch.DataSource = dts;
         cmb_tch.DisplayMember = "fname";
         cmb_tch.ValueMember = "teacherid";

     }
        
     public void showcrs()
     {
         adpt = new SqlDataAdapter("select courseid,Coursename from course", con.openconn());
         dts = new DataTable();
         adpt.Fill(dts);
         cmb_crs.DataSource = dts;
         cmb_crs.DisplayMember = "Coursename";
         cmb_crs.ValueMember = "courseid";

     }

     public void showstdclass()
     {
         adpt = new SqlDataAdapter("select Classid,Class_name from Class", con.openconn());
         dts = new DataTable();
         adpt.Fill(dts);
         cmb_class.DataSource = dts;
         cmb_class.DisplayMember = "Class_name";
         cmb_class.ValueMember = "Classid";

     }

     private void AssignCourses_Load(object sender, EventArgs e)
     {
         showstdclass();
         showteacher();
         showcrs();
         dts = new DataTable();
         adpt = new SqlDataAdapter("select a.assign_id,c.Class_name,cr.coursename,t.fname from assign a,teacher t ,course cr,Class c  where a.class_id =c.Classid and a.course_id = cr.courseid and a.teacher_id =t.teacherid  ", con.openconn());

         adpt.Fill(dts);

         asgn_dgv.DataSource = dts;
     }

     private void button1_Click(object sender, EventArgs e)
     {
         SqlCommand command = new SqlCommand("insert into assign(course_id,teacher_id,class_id) values ('" + Convert.ToInt32(cmb_crs.SelectedValue.ToString()) + "','" + Convert.ToInt32(cmb_tch.SelectedValue.ToString()) + "','" + Convert.ToInt32(cmb_class.SelectedValue.ToString()) + "' )",con.openconn());
         command.ExecuteNonQuery();
         con.connclose();
         MessageBox.Show("Successffully Assigned");
         this.Refresh();
     }

     private void button2_Click(object sender, EventArgs e)
     {
         this.Hide();
         MainForm main = new MainForm();
         main.Show();
     }

     private void button3_Click(object sender, EventArgs e)
     {
         SqlCommand command = new SqlCommand("Delete from assign Where assign_id = '" + id + "'", con.openconn());
         command.ExecuteNonQuery();
         this.Refresh();
     }

     private void asgn_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
     {

     }

     private void asgn_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
     {
         int index = e.RowIndex;
         DataGridViewRow selectedRow = asgn_dgv.Rows[index];
         id = selectedRow.Cells[0].Value.ToString();
     }

    }
}
