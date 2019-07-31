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
    public partial class IP4_Validator : Form
    {
        public IP4_Validator()
        {
            InitializeComponent();
        }

        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            string temp = DateTime.Now.ToLongDateString();

            string[] date = temp.Split(' ');

            label1.Text = "Today : " + date[1] + "-" + date[2].Substring(0, 2) + "-19";
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to quit this application?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();

            }
        }
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateIPv4(textBox1.Text))
                MessageBox.Show(textBox1.Text + "\nThe IP this correct", "Valid IP", MessageBoxButtons.OK);
            else
                MessageBox.Show(textBox1.Text + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot (255.255.255.255)", "Error", MessageBoxButtons.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
