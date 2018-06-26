using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationSystem.utilities
{
    public class Appsetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["dbs"].ConnectionString;
        }
    }
}
