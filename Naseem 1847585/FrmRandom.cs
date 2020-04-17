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
    public partial class FrmRandom : Form
    {
        Random y = new Random(); 
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnRN_Click(object sender, EventArgs e)
        {
            btnRN.Text = Convert.ToString(y.Next(1, 10)); 
        }

        private void lblRGB_Click(object sender, EventArgs e)
        {

        }

        private void btnGRC_Click(object sender, EventArgs e)
        {
            int R = y.Next(0, 255);
            int G = y.Next(0, 255);
            int B = y.Next(0, 255);
            lblRGB.Text = Convert.ToString(R) + "-" + Convert.ToString(G) + "-" + Convert.ToString(B);
            btnGRC.BackColor = Color.FromArgb(R, G, B);
            this.BackColor = Color.FromArgb(255 - R, 255 - G, 255 - B);
                
            
           
        }
    }
}
