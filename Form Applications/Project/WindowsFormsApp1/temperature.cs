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
    public partial class temperature : Form
    {
        public temperature()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to quit this application?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double c = float.Parse(textBox1.Text);

                double f = c * (1.8) + 32;

                textBox2.Text = f.ToString();


                File.AppendAllText("TempConversions.txt", textBox1.Text + " C " + " = " + textBox2.Text + " F," + DateTime.Now.ToString() + Environment.NewLine);

            }
            else if (radioButton2.Checked)
            {
                double f = float.Parse(textBox2.Text);
                double n = 9;
                double m = 5;
                double c = (f - 32) * (m / n);

                textBox1.Text = c.ToString();
                File.AppendAllText("TempConversions.txt", textBox2.Text + " F " + " = " + textBox2.Text + " C," + DateTime.Now.ToString() + Environment.NewLine);

            }

            {
                if (float.Parse(textBox1.Text) >= 100)
                    textBox3.Text = "Water boils";
                else if (float.Parse(textBox1.Text) >= 40)
                    textBox3.Text = "Hot Bath";
                else if (float.Parse(textBox1.Text) >= 37)
                    textBox3.Text = "Body temperature";
                else if (float.Parse(textBox1.Text) >= 30)
                    textBox3.Text = "Beach weather";
                else if (float.Parse(textBox1.Text) >= 21)
                    textBox3.Text = "Room temperature";
                else if (float.Parse(textBox1.Text) >= 10)
                    textBox3.Text = "Cool Day";
                else if (float.Parse(textBox1.Text) <= 0)
                    textBox3.Text = "Freezing point of water";
                else if (float.Parse(textBox1.Text) <= -18)
                    textBox3.Text = "Very Cold Day";
                else if (float.Parse(textBox1.Text) <= -40)
                    textBox3.Text = "Extremely Cold Day\n(and the same number!)";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("TempConversions.txt"), "File", MessageBoxButtons.OK);

        }

        private void TemperatureForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
