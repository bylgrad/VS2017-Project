using System;
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
    public partial class frmDriver : Form
    {
        public frmDriver()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstname.Text = null;
            txtIDno.Text = null;
            txtLastname.Text = null;
            txtMiddlename.Text = null;
        }
    }
}
