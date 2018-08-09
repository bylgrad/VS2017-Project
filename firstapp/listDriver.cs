using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace firstapp
{
    public partial class listDriver : Form
    {

        public listDriver()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDriver frmDriver = new frmDriver();
            frmDriver.estate("CREATE");
            frmDriver.ShowDialog();
            frmDriver.ClearDriver();
        }

        private void listDriver_Load(object sender, EventArgs e)
        {
            stacko();
        }

        public void stacko()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;password=1234;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");

            con.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT objid, lastname, firstname, middlename, idno FROM master_driver ORDER BY lastname";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            driversList.DataSource = bSource;

            driversList.Columns[0].HeaderText = "ID";
            driversList.Columns[0].Visible = false;
            driversList.Columns[1].HeaderText = "LAST NAME";
            driversList.Columns[2].HeaderText = "FIRST NAME";
            driversList.Columns[3].HeaderText = "MIDDLE NAME";
            driversList.Columns[4].HeaderText = "ID NUMBER";
            con.Close();
        }

        //public void loaddata()
        //{
        //    MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=1234;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");
        //    MySqlCommand cmd = connection.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "SELECT * FROM driver";
        //    DataTable dt = new DataTable();
        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    driversList.DataSource = dt;
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            stacko();
        }

        private void listDriver_EnabledChanged(object sender, EventArgs e)
        {
            stacko();
        }

        private void listDriver_Enter(object sender, EventArgs e)
        {

        }

        private void listDriver_Activated(object sender, EventArgs e)
        {
            stacko();
        }

        private void driversList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmDriver frmOpen = new frmDriver();

            frmDriver.objectid = driversList.CurrentRow.Cells[0].Value.ToString();
            frmOpen.txtLastname.Text = driversList.CurrentRow.Cells[1].Value.ToString();
            frmOpen.txtFirstname.Text = driversList.CurrentRow.Cells[2].Value.ToString();
            frmOpen.txtMiddlename.Text = driversList.CurrentRow.Cells[3].Value.ToString();
            frmOpen.txtIDno.Text = driversList.CurrentRow.Cells[4].Value.ToString();
            frmOpen.estate("READ");
            frmOpen.ShowDialog();
        }
    }
}
