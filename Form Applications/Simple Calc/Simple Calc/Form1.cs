using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, result = 0;

            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
            
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox1.Text = "0";
                textBox1.Focus();
            }
            finally
            {
                if (comboBox1.SelectedItem.ToString() == "+")
                {
                    result = num1 + num2;
                }
                else if (comboBox1.SelectedItem.ToString() == "-")
                {
                    result = num1 - num2;
                }
                else if (comboBox1.SelectedItem.ToString() == "*")
                {
                    result = num1 * num2;
                }
                else if (comboBox1.SelectedItem.ToString() == "/")
                {
                    result = (num1 == 0 && num2 == 0) ? 0 : num1 / num2;
                }
                textBox3.Text = result.ToString();
            }

            try
            {
                num2 = Convert.ToDouble(textBox2.Text);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox2.Text = "0";
            }
            finally
            {
                if(comboBox1.SelectedItem.ToString() == "+")
                {
                    result = num1 + num2;
                }
                else if(comboBox1.SelectedItem.ToString() == "-")
                {
                    result = num1 - num2;
                }
                else if (comboBox1.SelectedItem.ToString() == "*")
                {
                    result = num1 * num2;
                }
                else if(comboBox1.SelectedItem.ToString() == "/")
                {
                    result = (num1 == 0 && num2 == 0) ? 0 : num1 / num2;
                }
                textBox3.Text = result.ToString();
            }
        }
   
        private void TextBox1_Click(object sender, EventArgs e) => textBox1.Text = "";

        private void TextBox2_Click(object sender, EventArgs e) => textBox2.Text = "";

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string option = "";

            option = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (option == "Yes")
            {
                MessageBox.Show("You decide to quit.");
                this.Close();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }

    }
}
