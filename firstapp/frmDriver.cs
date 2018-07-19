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

        private void btnSave_Click(object sender, EventArgs e)
        {
            entity.Driver driver = new entity.Driver()
            {
                objid = DateTime.Now.Year + DateTime.Now.ToString("MMddyyyyHHmmssfff"),
                firstname = txtFirstname.Text,
                lastname = txtLastname.Text,
                middlename = txtMiddlename.Text,
                idno = txtIDno.Text
            };
            labelEntity.Text = driver.objid;
            DBConnect.NewDriver newDriver = new DBConnect.NewDriver();
            newDriver.AddDriver();

        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            entity.Vehicle vehicle = new entity.Vehicle();
        }
    }
}
