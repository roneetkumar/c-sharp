using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateAndTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime enteredValue, currentDate = DateTime.Today;
            DateTime.TryParse(textBox1.Text, out enteredValue);
            if (enteredValue.ToShortDateString() == "1/1/0001")
            {
                MessageBox.Show("Wrong date:" + textBox1.Text + "\n\nTryParse date:" + enteredValue.ToShortDateString(),
                 "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                TimeSpan timeTillDue = enteredValue.Subtract(currentDate);
                int daysTillDue = timeTillDue.Days;
                MessageBox.Show("Current date: " + currentDate.ToShortDateString() +
                "\n\nFuture date: " + textBox1.Text + "\n\n" + daysTillDue);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime enteredValue, currentDate = DateTime.Today;
            DateTime.TryParse(textBox2.Text, out enteredValue);
            if (enteredValue.ToShortDateString() == "1/1/0001" || enteredValue.ToShortDateString() == "0001-01-01")
            {
                MessageBox.Show("Wrong date:" + textBox2.Text + "\n\nTryParse date:" + enteredValue.ToShortDateString(),
                 "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                int currentYear, bdayYear, currentMonth, bdayMonth, currentDay, bdayDay;
                currentYear = currentDate.Year; bdayYear = enteredValue.Year;
                currentMonth = currentDate.Month; bdayMonth = enteredValue.Month;
                currentDay = currentDate.Day; bdayDay = enteredValue.Day;
                if (currentMonth == bdayMonth)
                {
                    if (currentDay == bdayDay)
                    {
                        MessageBox.Show("Current date:" + currentDate.ToLongDateString() +
                      "\n\nBirth Date:" + enteredValue.ToLongDateString() +
                      "\n\nAge:" + (currentYear - bdayYear) +
                      "\n\nHappy Bday", "Title");
                    }
                    else if (currentDay > bdayDay)
                    {
                        MessageBox.Show("Current date:" + currentDate.ToLongDateString() +
                      "\n\nBirth Date:" + enteredValue.ToLongDateString() +
                      "\n\nAge:" + (currentYear - bdayYear), "Title");
                    }
                    else
                    {
                        MessageBox.Show("Current date:" + currentDate.ToLongDateString() +
                        "\n\nBirth Date:" + enteredValue.ToLongDateString() +
                        "\n\nAge:" + (currentYear - bdayYear - 1), "Title");
                    }
                }
                else if (currentMonth > bdayMonth)
                {
                    MessageBox.Show("Current date:" + currentDate.ToLongDateString() +
                  "\n\nBirth Date:" + enteredValue.ToLongDateString() +
                  "\n\nAge:" + (currentYear - bdayYear), "Title");
                }
                else
                {
                    MessageBox.Show("Current date:" + currentDate.ToLongDateString() +
                  "\n\nBirth Date:" + enteredValue.ToLongDateString() +
                  "\n\nAge:" + (currentYear - bdayYear - 1), "Title");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
