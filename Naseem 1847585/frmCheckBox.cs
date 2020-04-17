using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naseem_1847585
{
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string msg = "" ;

            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }
            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }
            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }
            
            if (msg.Length == 0)
            {
                msg = ( "Nothing Selected" );
            }
            MessageBox.Show ( "Order " + msg);
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
