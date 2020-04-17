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
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
            
        {
            pictry.Image = Image.FromFile("C:\\Users\\m7md\\Desktop\\classwork 1#\\powerrangers.jpg");
        }

        private void pictry_Click(object sender, EventArgs e)
        {

        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            try
            {
                pictry2.Image = Naseem_1847585.Properties.Resources.formontera;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Creating Image From Resource !! ");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
