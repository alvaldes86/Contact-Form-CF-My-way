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

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// btnAbout_Click event method intanciate and display the AboutForm
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            Hide();  //Control the display of the main form
            frmAbout.ShowDialog();
            // frmAbout.Show(); allows the user to interant with multiple form at once
            Show();  //Control the display of the main form
        }

        /// <summary>
        /// Closes mainform
        /// </summary>      
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

        /// <summary>
        /// MainForm_FormClosing display a warning confirming if the user wants to close the app
        /// </summary>>
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


        /// <summary>
        /// 
        /// </summary>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            /*
            OrderForm myForm = new OrderForm(txtName.Text);
            myForm.ShowDialog();
            */

            //perform data validation
            if (IsValid())
            {
                Item myItem = new Item(txtDescription.Text, Decimal.Parse(txtPrice.Text), txtUnits.Text);
                lblMessage.Text = myItem.ToString();

                OrderForm myForm = new OrderForm(myItem);
                myForm.lblWelcome.Text = "Welcome, " + txtName.Text;
                myForm.ShowDialog();
            }
        }


        /// <summary>
        /// IsValid method detects if a form data is valid
        /// </summary>
        /// <returns>true if value is valid, false otherwise</returns>
        private bool IsValid()
        {
            decimal price;
            bool valid = false;

            //check for required fields
            if(!IsPresent(txtDescription, "Description") || !IsPresent(txtPrice, "Price") || 
                !IsPresent(txtUnits, "Units"))
            {
                lblMessage.Text += Environment.NewLine + "Please enter missing data";
            }
            else if(decimal.TryParse(txtPrice.Text, out price) == false) //check that price is numeric (decimal)
            {
                lblMessage.Text = "Please enter Price";
                txtPrice.SelectAll();
                txtPrice.Focus();
            }
            else
            {
                lblMessage.ResetText();
                valid = true;
            }
            return valid;
        }


        /// <summary>
        /// IsPresent method detects if a text box has a value
        /// </summary>
        /// <param name="pTextBox">Textbox</param>
        /// <param name="pName">Name field</param>
        /// <returns>true if value is present, false otherwise</returns>
        private bool IsPresent(TextBox pTextBox, string pName)
        {
            bool present = false;

            if(pTextBox.Text.Trim()== string.Empty)
            {
                lblMessage.Text = "Please enter " + pName;
                pTextBox.SelectAll();
                pTextBox.Focus();
            }
            else
            {
                present = true;
            }

            return present;
        }

        /// <summary>
        /// Click event handler for clear button. Clears control on form and sets focus on first input control
        /// </summary>
        /// <param name="sender">Control initiating event</param>
        /// <param name="e">Event arguments</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtUnits.Clear();

            lblMessage.Text = string.Empty;

        }
    }
}
