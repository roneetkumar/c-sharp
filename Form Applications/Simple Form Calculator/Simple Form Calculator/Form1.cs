using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Form_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;

            try
                {
                label6.Text = "";
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                }
                catch (Exception)
                {
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                }
   

            textBox3.Text = (num1 + num2).ToString();
            textBox4.Text = (num1 - num2).ToString();
            textBox5.Text = (num1 * num2).ToString();
            textBox6.Text = (num1 / num2).ToString();
        }

        private void Button2_Click(object sender, EventArgs e) => Close();
        private void textBox1_clicked(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
                textBox1.Text = "";
        }

        private void textBox2_clicked(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
        }
    }
}
