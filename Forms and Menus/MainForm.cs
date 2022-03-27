using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_and_Menus
{
    public partial class MainForm : Form
    {

        //1:01:20

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            Hide();  //Control the display of the main form
            frmAbout.ShowDialog();
            // frmAbout.Show(); allows the user to interant with multiple form at once
            Show();  //Control the display of the main form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;  //continue, close form
            }
            else
            {
                e.Cancel = true; //cancel form close
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            /*
            OrderForm myForm = new OrderForm(txtName.Text);
            myForm.ShowDialog();
            */

            //perform data validation
            if (IsValid())
            {
                Item myItem = new Item(txtDescription.Text, Decimal.Parse(txtPrice.Text, txtUnits.Text);
            }
        }
    }
}
