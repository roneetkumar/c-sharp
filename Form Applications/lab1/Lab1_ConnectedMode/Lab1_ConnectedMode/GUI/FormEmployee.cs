using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_ConnectedMode.Validation;
using Lab1_ConnectedMode.Business;

namespace Lab1_ConnectedMode.GUI
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(UtilityDB.ConnectDB().State.ToString());
            string input = "";
            Employee emp = new Employee();
            input = textBoxEmpId.Text.Trim();
            if (!Validator.IsValidId(input, 4))
            {
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;

            }
            int tempId= Convert.ToInt32(textBoxEmpId.Text.Trim());
            if (!(emp.IsUniqueEmployeeId(tempId)))
            {
                MessageBox.Show("This Employee ID already exists!","Duplicate Employee ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxEmpId.Clear();
                textBoxEmpId.Focus();
                return;
            }

            input = textBoxFirstName.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
                return;

            }


            input = textBoxLastName.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxLastName.Clear();
                textBoxLastName.Focus();
                return;
            }

            input = textBoxJobTitle.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxJobTitle.Clear();
                textBoxJobTitle.Focus();
                return;
            }

            // valid data
           // Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmpId.Text.Trim());
            emp.FirstName = textBoxFirstName.Text.Trim();
            emp.LastName = textBoxLastName.Text.Trim();
            emp.JobTitle = textBoxJobTitle.Text.Trim();
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee record has been saved successfully.", "Employee Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {
            listViewEmployee.Items.Clear();
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetEmployeeList();
           if (listEmp != null)
            {
                foreach (Employee empItem in listEmp)
                {
                    ListViewItem item = new ListViewItem(empItem.EmployeeId.ToString());
                    item.SubItems.Add(empItem.FirstName);
                    item.SubItems.Add(empItem.LastName);
                    item.SubItems.Add(empItem.JobTitle);
                    listViewEmployee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No Employee Data in the database.", "No Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        private void comboBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxOption.SelectedIndex;
            switch (indexSelected)
            {
                case 1: //search by EmployeeId
                    labelMessage.Text = "Please enter Employee Id";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 2: //search by FirstName
                    labelMessage.Text = "Please enter First Name";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                case 3://search by LastName
                    labelMessage.Text = "Please enter Last Name";
                    textBoxInput.Clear();
                    textBoxInput.Focus();
                    break;
                default:
                    labelMessage.Text = "";
                    break;
               
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!(Validator.IsValidId(textBoxInput.Text.Trim())))
            {
                textBoxInput.Clear();
                textBoxInput.Focus();
                return;
            }
            Employee emp = new Employee();
            emp = emp.SearchEmployee(Convert.ToInt32(textBoxInput.Text.Trim()));
            if (emp!=null)
            {
                textBoxEmpId.Text = emp.EmployeeId.ToString();
                textBoxFirstName.Text = emp.FirstName;
                textBoxLastName.Text = emp.LastName;
                textBoxJobTitle.Text = emp.JobTitle;
            }
            else
            {
                textBoxInput.Clear();
                textBoxInput.Focus();
                string error = "Record not found !" + "\n" + "Please enter Employee Id again.";
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            comboBoxOption.SelectedIndex = 0;
        }
    }
}
