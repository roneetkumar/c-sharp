using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Term_Prep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (Convert.ToDouble(textBox1.Text) * 0.1550).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox8.Text = "";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox7.Text = (Convert.ToDouble(textBox2.Text) * 1.1960).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox7.Text = "";
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            try
            {
            textBox6.Text = (Convert.ToDouble(textBox3.Text) * 2.4711).ToString();   

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox6.Text = "";
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (Convert.ToDouble(textBox4.Text) * 0.3861).ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox5.Text = "";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
