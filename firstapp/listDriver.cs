﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstapp
{
    public partial class listDriver : Form
    {
        private Form f;
        public listDriver()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDriver frmDriver = new frmDriver();
            frmDriver.ShowDialog();
        }

        private void listDriver_Load(object sender, EventArgs e)
        {

        }
    }
}
