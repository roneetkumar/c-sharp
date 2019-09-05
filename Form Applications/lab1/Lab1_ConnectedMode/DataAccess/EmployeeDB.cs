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
        //what is a purpose of methods -> saverecord (employee(class name) emp(object))
        //parameter yes -> employee emp
        //where to use? use Employee.cs

        public static void SaveRecord(Employee emp)
        {
            // connect the database

            SqlConnection connDB = UtilityDB.ConnectDB();

            //create and customize the object of type sqlcommand

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employees(EmployeeID, FirstName, LastName, JobTitle)" + 
                              " VALUES (@EmployeeID, @FirstName, @LastName, @JobTitle)";

            cmd.Parameters.AddWithValue("@EmployeeID",emp.EmployeeID);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

            cmd.ExecuteNonQuery();
            //INSERT INTO employees " + "
            //Values (4444, "Mary", "Grean" , "Pregrammer"); SQL ' ';
            //close the database
            connDB.Close();
        }

    }
}
