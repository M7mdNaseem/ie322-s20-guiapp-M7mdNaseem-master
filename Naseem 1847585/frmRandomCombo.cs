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
    public partial class frmRandomCombo : Form
    {
        Random x = new Random();
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void rdoGreater50_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            cmb1.ResetText();
            cmb1.Items.Clear();
            for (int i = 0; i < x.Next(1,50)-1  ; i++)
            {
                cmb1.Items.Add(x.Next(100,999));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmb1.ResetText();
            cmb1.Items.Clear();
            rdoLess500.Checked = false;
            rdoGreater500.Checked = false; 
        }

        private void btnGenerate2_Click(object sender, EventArgs e)
        {
            cmb2.ResetText();
            cmb2.Items.Clear();
            for (int i = 0; i < x.Next(2, 9)-1 ; i++)
            {
                cmb2.Items.Add(x.Next(10, 99));
            }
        }

        private void cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmb2.Text) > 49)
            {
                rdoGreater50.Checked = true; 
            }
            else
            {
                rdoLess50.Checked = true;
            }
            
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            cmb2.ResetText();
            cmb2.Items.Clear();
            rdoLess50.Checked = false;
            rdoGreater50.Checked = false;
        }
    }
}
