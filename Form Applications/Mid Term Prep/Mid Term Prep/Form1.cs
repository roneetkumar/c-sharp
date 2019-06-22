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
        public Form1() => InitializeComponent();

        ConvertArea obj = new ConvertArea();
        double num1 = 0;
                
        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
                textBox1.ReadOnly = true;
                obj = new ConvertArea(num1);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox1.Text = "0";
                textBox1.Focus();
                textBox1.ReadOnly = false;
            }
            finally
            {
                textBox8.Text = obj.cmToIn().ToString();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox2.Text);
                textBox2.ReadOnly = true;
                obj = new ConvertArea(num1);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox2.Text = "0";
                textBox2.Focus();
                textBox2.ReadOnly = false;
            }
            finally
            {
                textBox7.Text = obj.mtToyd().ToString();
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox3.Text);
                textBox3.ReadOnly = true;
                obj = new ConvertArea(num1);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox3.Text = "0";
                textBox3.Focus();
                textBox3.ReadOnly = false;
            }
            finally
            {
                textBox6.Text = obj.htToAcr().ToString();
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(textBox4.Text);
                obj = new ConvertArea(num1);
                textBox4.ReadOnly = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox4.Text = "0";
                textBox4.Focus();
                textBox4.ReadOnly = false;
            }
            finally
            {
                textBox5.Text = obj.kmToMile().ToString();
            }
        }

        void reset()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            txtAns1.Text = "a, b, c, d";
            txtAns2.Text = "a, b, c, d";
            txtAns3.Text = "a, b, c, d";
            txtAns4.Text = "a, b, c, d";
            txtAns5.Text = "a, b, c, d";
            this.Text = "Roneet Kumar";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            byte btn = 0;
            btn = Convert.ToByte(MessageBox.Show("You want to quit ? ", "Exit", MessageBoxButtons.OKCancel));
            if (btn == 1)
            {
                MessageBox.Show("You decide to quit.");
                Close();
            }
            else
            {
                reset();
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            txtAns1.Text = "D";
            txtAns2.Text = "A,B,D";
            txtAns3.Text = "A,B";
            txtAns4.Text = "B,C";
            txtAns5.Text = "C";
        }
    }

    public class ConvertArea
    {
        private double num1;

        public double Num1
        {
            get => num1;
            set => num1 = value;
        }

        public ConvertArea() { }
        public ConvertArea(double num1) => this.Num1 = num1;
        public double cmToIn() => Num1 * 0.1550;
        public double mtToyd() => Num1 * 1.1960;
        public double htToAcr() => Num1 * 2.4711;
        public double kmToMile() => Num1 * 0.3861;
    }
}
