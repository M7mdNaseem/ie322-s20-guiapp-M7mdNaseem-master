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
    public partial class frmCombo : Form


    {
        public frmCombo()
        {
            InitializeComponent();

            // Adding items to the Combobox

            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("Monday");
            cmbDays.Items.Add("Teusday");
            cmbDays.Items.Add("Wednesday");
            cmbDays.Items.Add("Thursday");
            cmbDays.Items.Add("Friday");
            cmbDays.Items.Add("Saturday");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCombo_Load(object sender, EventArgs e)
        {

        }

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            //using method1
            MessageBox.Show(cmbDays.Text);
        }

        private void btnRemoveIndex_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(6);
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            cmbDays.Items.Remove("Sunday");
        }

        private void btnRemoveItem1_Click(object sender, EventArgs e)
        {
            if(cmbDays.Items.Count >=1)
            { 
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
            }
            else

            { 
                MessageBox.Show("Can't remove last item");
            }

        }

        private void btnMethod2_Click(object sender, EventArgs e)
        {
            string itemText = cmbDays.GetItemText(cmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void btnRemoveItem2_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
            }
            else

            {
                MessageBox.Show("Can't remove 2nd last item");
            }
        }
    }
}