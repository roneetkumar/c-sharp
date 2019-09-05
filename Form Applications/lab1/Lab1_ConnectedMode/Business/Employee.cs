using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_ConnectedMode.DataAccess;

namespace Lab1_ConnectedMode.Business
{
    public class Employee
    {
        //private class variables (Encapsulation)
        private int employeeID;
        private string firstName;
        private string lastName;
        private string jobTitle;
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }
    }
}
