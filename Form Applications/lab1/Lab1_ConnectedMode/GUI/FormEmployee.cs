using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ConnectedMode.DataAccess;
using Lab1_ConnectedMode.Business;

namespace Lab1_ConnectedMode.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UtilityDB.ConnectDB().State.ToString());
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.EmployeeID = 1234;
            emp.FirstName = "Roneet";
            emp.LastName = "Kumar";
            emp.JobTitle = "Programmer";
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee Stored");
        }
    }
}
