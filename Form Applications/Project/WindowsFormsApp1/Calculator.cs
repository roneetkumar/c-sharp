using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public Calculator() => InitializeComponent();

        private void Calculator_Load(object sender, EventArgs e) => calcObj = new Calc();

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
            if (button.Text != ".") display.Text += button.Text;
            
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
            double result;
            string dir = @"C:\Test\";
            string filePath = @"C:\Test\Calculator History.txt";

            calcObj.Num2 = Convert.ToDouble(display.Text);

            result = (operation == "+") ?
                        (calcObj.Num1 + calcObj.Num2) :
                     (operation == "-") ?
                        (calcObj.Num1 - calcObj.Num2) :
                     (operation == "*") ?
                        (calcObj.Num1 * calcObj.Num2) :
                     (operation == "/") ?
                        (calcObj.Num1 / calcObj.Num2) : 0;

            display.Text = result.ToString();

            if (result == (double)result)
                dotCount = 1;
            else
                dotCount = 0;


            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(file);

            textOut.WriteLine(calcObj.Num1.ToString() + " " + operation + " " + calcObj.Num2.ToString() + " = " + result.ToString());
            textOut.Close();
        }

        private void clear(object sender, EventArgs e)
        {
            display.Text = "";
            dotCount = 0;
        }

        private void BtnDel_Click(object sender, EventArgs e) => display.Text = (Convert.ToInt32(display.Text.Length) > 0) ? display.Text.Remove(Convert.ToInt32(display.Text.Length) - 1) : "";

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Test\";
            string filePath = @"C:\Test\Calculator History.txt";
            display.Text = "";
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            FileStream file = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            file.SetLength(0);
            file.Close();
        }
    }
}
