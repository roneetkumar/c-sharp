using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        Calc calcObj;
        int dotCount = 0;
        string operation = "";
        bool operationClicked = false;

        class Calc
        {
            private double num1, num2;

            public double Num1 {
                get => num1;
                set => num1 = value;
            }
            public double Num2 {
                get => num2;
                set => num2 = value;
            }

            public double add() => Num1 + Num2;
            public double sub() => Num1 - Num2;
            public double mul() => Num1 * Num2;
            public double div() => Num1 / Num2;
        }
        public Calculator()
        {
            InitializeComponent();
        }
       
        private void Calculator_Load(object sender, EventArgs e)
        {
            calcObj = new Calc();
        }

        private void numClick(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (operationClicked))
            {
                display.Clear();
                dotCount = 0;
            }

            operationClicked = false;

            Button button = (Button)sender;

            if(button.Text == "." && dotCount < 1)
            {
                dotCount++;
                display.Text += button.Text;
            }
            if (button.Text != ".")
            {
                display.Text += button.Text;
            }
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            calcObj.Num1 = Convert.ToDouble(display.Text);
            display.Text = "";
            operationClicked = true;
        }

        private void ansClick(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    calcObj.Num2 = Convert.ToDouble(display.Text);
                    display.Text = (calcObj.Num1 + calcObj.Num2).ToString();
                    break;
                case "-":
                    calcObj.Num2 = Convert.ToDouble(display.Text);
                    display.Text = (calcObj.Num1 - calcObj.Num2).ToString();
                    break;
                case "*":
                    calcObj.Num2 = Convert.ToDouble(display.Text);
                    display.Text = (calcObj.Num1 * calcObj.Num2).ToString();
                    break;
                case "/":
                    calcObj.Num2 = Convert.ToDouble(display.Text);
                    display.Text = (calcObj.Num1 / calcObj.Num2).ToString();
                    break;
                default:
                    break;
            }

            //MessageBox.Show(calcObj.Num1.ToString() + " " + operation + " " + calcObj.Num2.ToString() + " = " + (calcObj.Num1 + calcObj.Num2));

            double ans = double.Parse(display.Text);

            if (ans == (double)ans)
                dotCount = 1;
            else
                dotCount = 0;
        }

        private void clear(object sender, EventArgs e)
        {
            display.Text = "";
            dotCount = 0;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(display.Text.Length) > 0)
                display.Text = display.Text.Remove(Convert.ToInt32(display.Text.Length) - 1);
        }
    }
}
