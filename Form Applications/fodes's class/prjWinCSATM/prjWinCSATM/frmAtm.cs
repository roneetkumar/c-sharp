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
    public partial class frmAtm : Form
    {
        public frmAtm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAtm_Load(object sender, EventArgs e)
        {
            this.Height = 244;
            this.Width = 593;

            clsAccount ac = new clsAccount("AC11", "Checkin", 2, 11, 2000, "active", 20000 ); 
            MessageBox.Show(ac.Consult());


            /**
            clsTime Rv = new clsTime();
            Rv.Hour = 12;
            Rv.Minute = 30;
            Rv.Second = 20;
            MessageBox.Show(Rv.ToUniversal());
            MessageBox.Show(Rv.ToStandard());

            Rv.Hour = 18;
            Rv.Minute = 30;
            Rv.Second = 20;
            MessageBox.Show(Rv.ToStandard());
            MessageBox.Show(Rv.ToUniversal());

            Rv.Hour = 9;
            Rv.Minute = 30;
            Rv.Second = 20;
            MessageBox.Show(Rv.ToStandard());
    */
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            this.Height = 355;
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            this.Height = 474;
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            this.Height = 634;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            this.Height = 786;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 244;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
