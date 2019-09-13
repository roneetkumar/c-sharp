using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ConnectedMode.Business;
using Lab1_ConnectedMode.Validation;

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

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(UtilityDB.ConnectDB().State.ToString());
        //}

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string employeeId = textBoxEmployeeID.Text.Trim();

            if (!Validator.IsValidId(employeeId, 4))
            {
                textBoxEmployeeID.Clear();
                textBoxEmployeeID.Focus();
                return;
            }

            Employee emp = new Employee();

            emp.EmployeeID = Convert.ToInt32(textBoxEmployeeID.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee Stored");

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
