using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrics_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            //label5.Text = trackBar1.Value.ToString();
            int trackCurrentValue = trackBar1.Value;
            int trackPreviousValue = trackCurrentValue;
            int X = 55;
            int Y = 156;
            panel1.Controls.Clear();

            if(trackCurrentValue >= trackPreviousValue)
            {
                for (int i = 0; i < trackCurrentValue; i++)
                {
                    TextBox box = new TextBox();
                    box.Location = new Point(X, Y);
                    box.Text = (i + 1).ToString();

                    label5.Text = box.Name =  "box" + (i + 1).ToString();
                    this.Controls.Add(box);
                    Y += 20;
                }
            }
            else
            {
                for (int i = 10; i >= trackCurrentValue; i--)
                {
                }
            }
                

        }



        // generate the matric dynamically
        // RetrieveVirtualItemEventArgs info from matrix
        // produce answer



    }
}
