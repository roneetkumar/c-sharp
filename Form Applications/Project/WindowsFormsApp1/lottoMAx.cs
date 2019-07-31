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
    public partial class lottoMAx : Form
    {
        public lottoMAx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string stArray = "";
            int[] Array = new int[8];
            Random rand = new Random();
            for (int i = 0; i < 8;)
            {
                int temp = rand.Next(1, 49);

                if (Array.Contains(temp) == false)
                {
                    Array[i] = temp;
                    if (i != 7)
                        stArray += temp.ToString() + ",";
                    else
                        stArray += temp.ToString();

                    listBox1.Items.Add(temp);
                    i++;
                }

            }

            File.AppendAllText("LottoNbrs.txt", "Max,     " + DateTime.Now.ToString() + ",        " + stArray + "         Extra 29" + Environment.NewLine);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to quit this application?", "Exit ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("LottoNbrs.txt"), "Read", MessageBoxButtons.OK);

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
