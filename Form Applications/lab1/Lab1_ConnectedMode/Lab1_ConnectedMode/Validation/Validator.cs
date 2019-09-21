using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;// required for regular expressions
using System.Windows.Forms;

namespace Lab1_ConnectedMode.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input)
        {
            if (!Regex.IsMatch(input,@"^\d{4}$"))
            {
                MessageBox.Show("Invalid Employee ID.", "Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
            
        }

        public static bool IsValidId(string input,int length)
        {
            if (!Regex.IsMatch(input, @"^\d{" + length + "}$"))
            {
                string error = "Employee ID must be " + length + "-digit number.";
                MessageBox.Show(error,"Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        // This method works only with letters and spaces
        public static bool IsValidName(string input)
        {
            string error = "First name must contain only letters or space(s)";
            if (input.Length==0)
            {
               
                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}
