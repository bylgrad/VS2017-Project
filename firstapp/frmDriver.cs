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
        public string state;
        
        public frmDriver()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            estate(state);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDriver();
        }

        public void ClearDriver()
        {
            txtFirstname.Text = null;
            txtIDno.Text = null;
            txtLastname.Text = null;
            txtMiddlename.Text = null;
        }

        public static string objectid;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                string Objid = "D-" + DateTime.Now.Year + DateTime.Now.ToString("MMddyyyyHHmmssfff");

                DialogResult dialogResult = MessageBox.Show("This information will be saved. Proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult.ToString() == "Yes")
                {
                    DBConnect dBConnect = new DBConnect();
                    dBConnect.NewDriver(Objid, txtFirstname.Text, txtLastname.Text, txtMiddlename.Text, txtIDno.Text);
                    this.Close();
                    estate("READ");
                }
            }
            else if (btnSave.Text == "Update")
            {
                DialogResult dialogResult = MessageBox.Show("This information will be updated. Proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult.ToString() == "Yes")
                {
                    DBConnect dBConnect = new DBConnect();
                    dBConnect.UpdateDriver(objectid, txtFirstname.Text, txtLastname.Text, txtMiddlename.Text, txtIDno.Text);
                    this.Close();
                    estate("READ");
                }
            }
        }

        public string estate(string state)
        {
            if (state == "READ")
            {
                panelDriver.Enabled = false;
                btnSave.Visible = false;
                btnClear.Visible = false;
                btnCancel.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                return state;
            }
            else if (state == "EDIT")
            {
                panelDriver.Enabled = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = true;
                btnSave.Text = "Update";
                btnClear.Visible = true;
                btnCancel.Visible = true;
                return state;
            }
            else if (state == "CREATE")
            {
                panelDriver.Enabled = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = true;
                btnClear.Visible = true;
                btnCancel.Visible = true;
                return state;
            }
            else
            {
                return state;
            }
        }

        private void frmDriver_Load(object sender, EventArgs e)
        {
            //estate(state);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           estate("EDIT");
        }
    }
}
