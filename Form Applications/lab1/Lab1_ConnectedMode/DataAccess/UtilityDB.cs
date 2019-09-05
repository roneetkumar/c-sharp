using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1_ConnectedMode.DataAccess
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connectDB = new SqlConnection();
            connectDB.ConnectionString = "Server=DESKTOP-NOC7ELQ; database=EmployeeDB; user=sa; password=qwerty"; //Trusted_Connection=True;
            connectDB.Open();
            return connectDB;
        }
    }
}
