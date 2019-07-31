using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class moneyExchange : Form
    {
        struct Money
        {
            public string name;
            public double ToDollar;
            public double ToCurrent;
        }
        Money CAD;
        Money EUR;
        Money INR;
        Money USD;
        Money GBP;

        public moneyExchange()
        {
            CAD = new Money();
            CAD.name = "CAD";
            CAD.ToDollar = 0.76555;
            CAD.ToCurrent = 0.30608;

            EUR = new Money();
            EUR.name = "EUR";
            EUR.ToDollar = 1.12176;
            EUR.ToCurrent = 0.89135;

            USD = new Money();
            USD.name = "USD";
            USD.ToDollar = 1;
            USD.ToCurrent = 1;

            INR = new Money();
            INR.name = "INR";
            INR.ToDollar = 0.015;
            INR.ToCurrent = 0.30608;

            GBP = new Money();
            GBP.name = "GBP";
            GBP.ToDollar = 1.24186;
            GBP.ToCurrent = 0.80511;

            InitializeComponent();
        }


        void ConvertM(string m1, float n1, string m2)
        {
            List<Money> MoneyList = new List<Money>();
            MoneyList.Add(USD);
            MoneyList.Add(GBP);
            MoneyList.Add(INR);
            MoneyList.Add(EUR);
            MoneyList.Add(CAD);

            Money MoneyFrom = MoneyList.Find(m => m.name == m1);
            Money MoneyTO = MoneyList.Find(m => m.name == m2);

            double ToDollar = MoneyFrom.ToDollar * n1;

            double result = ToDollar * MoneyTO.ToCurrent;

            textBox2.Text = result.ToString();
            File.AppendAllText("MoneyConversions.txt", n1.ToString() + " " + MoneyFrom.name + " = " + result.ToString() + " " + MoneyTO.name + "      " + DateTime.Now.ToString() + Environment.NewLine);


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to quit application Exchange Money", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("MoneyConversions.txt"), "Read File", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string m1 = "", m2 = "";
                {
                    if (radioButton1.Checked)
                        m1 = "CAD";
                    else if (radioButton2.Checked)
                        m1 = "USD";
                    else if (radioButton3.Checked)
                        m1 = "EUR";
                    else if (radioButton4.Checked)
                        m1 = "GBP";
                    else if (radioButton5.Checked)
                        m1 = "INR";
                }
                {
                    if (radioButton10.Checked)
                        m2 = "CAD";
                    else if (radioButton9.Checked)
                        m2 = "USD";
                    else if (radioButton8.Checked)
                        m2 = "EUR";
                    else if (radioButton7.Checked)
                        m2 = "GBP";
                    else if (radioButton6.Checked)
                        m2 = "INR";
                }

                ConvertM(m1, float.Parse(textBox1.Text), m2);

            }
            catch
            {

            }

        }

        private void MoneyExchange_Load(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
