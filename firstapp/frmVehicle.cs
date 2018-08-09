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
    public partial class frmVehicle : Form
    {
        public frmVehicle()
        {
            InitializeComponent();
        }

        public static string objectid;

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVehicle_Load(object sender, EventArgs e)
        {

        }

        public string estate(string state)
        {
            if (state == "READ")
            {
                //txtFirstname.Enabled = false;
                //txtLastname.Enabled = false;
                //txtMiddlename.Enabled = false;
                //txtIDno.Enabled = false;
                panelVehicle.Enabled = false;
                btnSave.Visible = false;
                btnClear.Visible = false;
                btnCancel.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                return state;
            }
            else if (state == "EDIT")
            {
                //txtFirstname.Enabled = true;
                //txtLastname.Enabled = true;
                //txtMiddlename.Enabled = true;
                //txtIDno.Enabled = true;
                panelVehicle.Enabled = true;
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
                //txtFirstname.Enabled = true;
                //txtLastname.Enabled = true;
                //txtMiddlename.Enabled = true;
                //txtIDno.Enabled = true;
                panelVehicle.Enabled = true;
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


        public void ClearVehicle()
        {
            txtAge.Text = null;
            txtBrand.Text = null;
            txtFuelType.Text = null;
            txtModel.Text = null;
            txtPlateNo.Text = null;
            txtState.Text = null;
            txtVersion.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                string Objid = "V-" + DateTime.Now.Year + DateTime.Now.ToString("MMddyyyyHHmmssfff");

                DialogResult dialogResult = MessageBox.Show("This information will be saved. Proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult.ToString() == "Yes")
                {
                    DBConnect dBConnect = new DBConnect();
                    dBConnect.NewVehicle(Objid, txtPlateNo.Text, txtBrand.Text, txtModel.Text, txtVersion.Text, txtAge.Text, txtFuelType.Text, txtState.Text);
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
                    dBConnect.UpdateVehicle(objectid, txtPlateNo.Text, txtBrand.Text, txtModel.Text, txtVersion.Text, txtAge.Text, txtFuelType.Text, txtState.Text);
                    this.Close();
                    estate("READ");
                }
            }
        }
    }
}
