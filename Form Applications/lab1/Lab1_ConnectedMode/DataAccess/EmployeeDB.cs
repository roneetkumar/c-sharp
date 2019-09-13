using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Lab1_ConnectedMode.Business;

namespace Lab1_ConnectedMode.DataAccess
{
    public static class EmployeeDB
    {
        public static void SaveRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employees(EmployeeID, FirstName, LastName, JobTitle)" + 
                              " VALUES (@EmployeeID, @FirstName, @LastName, @JobTitle)";

            cmd.Parameters.AddWithValue("@EmployeeID",emp.EmployeeID);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

            cmd.ExecuteNonQuery();
            connDB.Close();
        }

    }
}
