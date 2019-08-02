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
        calcOperations calcObj;
        string operation = "" ;
        bool operationClicked = false;
        int dotCount = 0;


        public Calculator() => InitializeComponent();

        private void Calculator_Load(object sender, EventArgs e)
        {
            calcObj = new calcOperations();
        }

        class calcOperations
        {
            private double num1, num2;

            public double Num1
            {
                get => num1;
                set => num1 = value;
            }

            public double Num2
            {
                get => num2;
                set => num2 = value;
            }

            public double add() => Num1 + Num2;
            public double sub() => Num1 - Num2;
            public double mul() => Num1 * Num2;
            public double div() => Num1 / Num2;

        }

        private void numClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((display.Text == "0") || (operationClicked))
            {
                display.Clear();
                dotCount = 0;
            }
            operationClicked = false;

            if (button.Text == "." && dotCount < 1)
            {
                dotCount++;
                display.Text += button.Text;
            }
            if (button.Text != ".") display.Text += button.Text;
        }

        private void BtnAns_Click(object sender, EventArgs e)
        {

            double result;
            string dir = @"..\..\..\Test\";
            string filePath = @"..\..\..\Test\Calculator History.txt";

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
            //MessageBox.Show(result.ToString());

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

        private void operationClick(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                operation = button.Text;
                calcObj.Num1 = Convert.ToDouble(display.Text);
                display.Clear();
                operationClicked = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Numeric Value");
            }
        }

        private void clearBtn(object sender, EventArgs e)
        {
            display.Clear();
            dotCount = 0;
        }

        private void delBtn(object sender, EventArgs e)
        {
            display.Text = (Convert.ToInt32(display.Text.Length) > 0) ? display.Text.Remove(Convert.ToInt32(display.Text.Length) - 1) : "";
        }

        private void clearHistory(object sender, EventArgs e)
        {
            string dir = @"C:\Test\";
            string filePath = @"C:\Test\Calculator History.txt";
            display.Text = "";
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            FileStream file = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            file.Flush();
            file.Close();
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
