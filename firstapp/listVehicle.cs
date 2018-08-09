using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace firstapp
{
    public partial class listVehicle : Form
    {
        public listVehicle()
        {
            InitializeComponent();
        }

        public void loadVehicle()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;password=1234;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");

            con.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT objid, plateno, brand, model, fueltype, state FROM master_vehicle ORDER BY plateno";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            vehicleList.DataSource = bSource;

            vehicleList.Columns[0].HeaderText = "ID";
            vehicleList.Columns[0].Visible = false;
            vehicleList.Columns[1].HeaderText = "PLATENO";
            vehicleList.Columns[2].HeaderText = "BRAND";
            vehicleList.Columns[3].HeaderText = "MODEL";
            vehicleList.Columns[4].HeaderText = "FUEL TYPE";
            vehicleList.Columns[5].HeaderText = "STATE";
            con.Close();
        }

        private void listVehicle_Load(object sender, EventArgs e)
        {
            loadVehicle();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmVehicle frmVehicle = new frmVehicle();
            frmVehicle.estate("CREATE");
            frmVehicle.ShowDialog();
            frmVehicle.ClearVehicle();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                frmVehicle frmVehicle = new frmVehicle();
                frmVehicle.objectid = vehicleList.CurrentRow.Cells[0].Value.ToString();
                frmVehicle.txtPlateNo.Text = vehicleList.CurrentRow.Cells[1].Value.ToString();
                frmVehicle.txtBrand.Text = vehicleList.CurrentRow.Cells[2].Value.ToString();
                frmVehicle.txtModel.Text = vehicleList.CurrentRow.Cells[3].Value.ToString();
                frmVehicle.txtVersion.Text = vehicleList.CurrentRow.Cells[4].Value.ToString();
                frmVehicle.txtAge.Text = vehicleList.CurrentRow.Cells[5].Value.ToString();
                frmVehicle.txtFuelType.Text = vehicleList.CurrentRow.Cells[6].Value.ToString();
                frmVehicle.txtState.Text = vehicleList.CurrentRow.Cells[7].Value.ToString();

                frmVehicle.estate("READ");
                frmVehicle.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadVehicle();
        }
    }
}
