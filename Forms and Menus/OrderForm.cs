﻿using System;
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

        public OrderForm( string pMessage)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + pMessage;
        }

    }
}
