using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//required for SQLServer database
using System.Configuration; // required for ConfigurationManager

namespace Lab1_ConnectedMode.DataAccess
{
    public static class UtilityDB
    {
        //version 1
        //public static SqlConnection ConnectDB()
        //{
        //    SqlConnection connDB = new SqlConnection();
        //    connDB.ConnectionString = @"server=TITANCAO-PC\MSSQLSERVER2017; database=EmployeeDB;user=sa;password=lasalle";
        //    connDB.Open();
        //    return connDB;
        //}

        //version 2
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString;
            connDB.Open();  
            return connDB;
        }

    }
}
