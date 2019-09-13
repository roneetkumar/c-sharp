using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjWinCSATM.Bus;


namespace prjWinCSATM
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            List<clsAccount> list = new List<clsAccount>();
            Dictionary<string, clsAccount> myList = new Dictionary<string, clsAccount>();

            clsAccount ac1 = new clsAccount("ac001", "checking", 1, 2, 2000, "active", 12000);
            clsAccount ac2 = new clsAccount("ac012", "checking", 3, 2, 2002, "active", 1000);
            clsAccount ac3 = new clsAccount("ac021", "checking", 4, 2, 2002, "active", 7120);
            clsAccount ac4 = new clsAccount("ac077", "checking", 5, 2, 2002, "active", 1360000);

            myList.Add(ac1.Number, ac1);
            myList.Add(ac2.Number, ac2);
            myList.Add(ac3.Number, ac3);
            myList.Add(ac4.Number, ac4);

            string info = "The number of accounts is " + myList.Count.ToString() + "\n";
                 
            foreach (clsAccount item in myList.Values)
            {
                info += item.Consult() + "\n";
            }

            MessageBox.Show(info);

        }
    }
}
