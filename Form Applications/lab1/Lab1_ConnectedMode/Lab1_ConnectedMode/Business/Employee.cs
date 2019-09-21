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
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public List<Employee> GetEmployeeList()
        {
            return (EmployeeDB.GetRecordList());
        }

        public bool IsUniqueEmployeeId(int empId)
        {
            return (EmployeeDB.IsUniqueId(empId));
        }
        public Employee SearchEmployee(int id)
        {
            return (EmployeeDB.SearchRecord(id));
        }
    }
}
