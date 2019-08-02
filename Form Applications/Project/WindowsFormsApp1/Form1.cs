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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            moneyExchange moneyObj = new moneyExchange();
            moneyObj.Show();
        }

        private void TempBtn_Click(object sender, EventArgs e)
        {
            temperature tempObj = new temperature();
            tempObj.Show();
        }

        private void LottoBtn_Click(object sender, EventArgs e)
        {
            lottoMAx lottomaxObj = new lottoMAx();
            lottomaxObj.Show();
        }

        private void Lotto2Btn_Click(object sender, EventArgs e)
        {
            Lotto649 lottoObj = new Lotto649();
            lottoObj.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IP4_Validator ipObj = new IP4_Validator();
            ipObj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
