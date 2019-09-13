using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1_ConnectedMode.Validation
{
    public static class Validator
    {
        public static bool IsValidId(string input, int length)
        {
            if (!Regex.IsMatch(input, @"^\d{"+ length +"}$"))
            {
                MessageBox.Show("Employee Id", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsValidName(string input, int length)
        {

            return true;
        }

    }
}
