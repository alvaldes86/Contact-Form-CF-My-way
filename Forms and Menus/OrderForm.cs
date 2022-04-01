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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// display a message for the user
        /// </summary>
        public OrderForm(string pMessage)
        {
            InitializeComponent();

            lblWelcome.Text = "Welcome " + pMessage;
        }

        /// <summary>
        /// instanciate and pass and Item object to the method
        /// </summary>
        public OrderForm(Item pItem)
        {
            InitializeComponent();

            txtDescription.Text = pItem.Description;
            txtPrice.Text = pItem.Price.ToString();
            txtUnits.Text = pItem.Units.ToString();

           lblMessage.Text = pItem.ToString();
        }

        /// <summary>
        /// The btnClose_Click method coses the OrderForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
