using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab1_ConnectedMode.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connectDB = new SqlConnection();
            connectDB.ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString; //Trusted_Connection=True;
            connectDB.Open();
            return connectDB;
        }
    }
}
