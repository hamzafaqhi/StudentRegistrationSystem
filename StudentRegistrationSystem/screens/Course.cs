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
    public partial class Course : MaterialSkin.Controls.MaterialForm
    {
        public Course()
        {
            InitializeComponent();
        }
        SqlDataAdapter adpt;
        DataTable dts;
        sqlconnection con = new sqlconnection();
        int flag = 0;
 
        String crs_name, crs_fee,id;






        private void Course_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select courseid,coursename,coursefee from course", con.openconn());
            dts = new DataTable();

            adpt.Fill(dts);

            crs_dgv.DataSource = dts;
        }



        private void crs_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = crs_dgv.Rows[index];
            id = selectedRow.Cells[0].Value.ToString();
            crs_name = selectedRow.Cells[1].Value.ToString();
            crs_fee = selectedRow.Cells[2].Value.ToString();
            
        }

        private void btncrs_update_Click(object sender, EventArgs e)
        {
           
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            create_course c = new create_course();
            c.Show();
            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm m = new MainForm();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from course Where courseid = '" + id + "'", con.openconn());
            command.ExecuteNonQuery();
            this.Dispose();
            Course c= new Course();
            c.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            create_course c = new create_course(id,crs_name,crs_fee);
            c.Show();  
        }
    }
}
