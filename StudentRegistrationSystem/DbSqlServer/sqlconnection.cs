using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentRegistrationSystem.DbSqlServer
{
  class sqlconnection
    {

      public SqlConnection conn;
      public sqlconnection()
      {
          conn = new SqlConnection(@"Data Source=ADMINRG-9CU4BR3;Initial Catalog=StudentManagementSystem;Integrated Security=True");


      }
      public SqlConnection openconn()
      {
          try
          {
              conn.Open();

          }
          catch (Exception)
          {
              
          }
          return conn;
      }

      public void connclose()
      {
          try
          {
              conn.Close();
          }
          catch (Exception)
          {
              

          }

      }

        
     
    }
}