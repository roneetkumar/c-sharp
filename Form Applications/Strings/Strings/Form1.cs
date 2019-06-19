using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;
            fullName = fullName.Trim();

            string[] names = fullName.Split(' ');

            string name(string text)
            {
                string firstLetter, otherFirstLetters;
                if (text.Length > 0)
                {
                    firstLetter = text.Substring(0, 1).ToUpper();
                    otherFirstLetters = text.Substring(1).ToLower();
                    return firstLetter + otherFirstLetters;
                }
                return "";
            }


            if (names.Length == 1){
                MessageBox.Show(
                     "First Name  :  " + name(names[0]) + "\n\n");
            }
            else if (names.Length == 2){
                MessageBox.Show(
                     "First Name  :  " + name(names[0]) + "\n\n" +
                     "Last Name   :  " + name(names[1]) + "\n\n");
            }
            else {
                MessageBox.Show(
                     "First Name  :  " + name(names[0]) + "\n\n" +
                     "Middle Name :  " + name(names[1]) + "\n\n" +
                     "Last Name   :  " + name(names[2]));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBox2.Text;
            string digits = "", standard = "";
           
            foreach(char number in phoneNumber)
            {
                if (char.IsDigit(number))
                {
                    digits += number;
                }
            }

            standard = digits.Insert(3, "-");
            standard = standard.Insert(7, "-");

            MessageBox.Show(
                    "Entered  :  " + phoneNumber + "\n\n" +
                    "Digits only :  " + digits + "\n\n" +
                    "Standard format   :  " + standard);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
