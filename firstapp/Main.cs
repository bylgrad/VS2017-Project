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
    public partial class Main : Form
    {
        public Main(String UID, String Role)
        {
            InitializeComponent();
            sessionUID.Text = UID;
            sessionROLE.Text = Role;
        }
        public string user;

        public class Driver
        {
            public string objid;
            public string brand;
            public string model;
            public string version;
            public int age;
            public DateTime datelisted;
            public string fueltype;
            public string state;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //Driver driver = new Driver();
            //frmVehicle.user = "ADMIN";
            // driver.objid = "0000" + DateTime.Now;
            this.treeView1.Nodes[0].ExpandAll();

            f = new listDriver
            {
                TopLevel = false
            };
            
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private Form f;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)

            {
                case "DRIVER":

                    f.Dispose();
                    f = new listDriver
                    {
                        TopLevel = false
                    };

                    this.panel1.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;


                case "VEHICLE":

                    f.Dispose();
                    f = new listVehicle
                    {
                        TopLevel = false
                    };

                    this.panel1.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "REQUEST":

                    f.Dispose();
                    f = new listRequest
                    {
                        TopLevel = false
                    };

                    this.panel1.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;

                case "TRAVEL":

                    f.Dispose();
                    f = new listTravel
                    {
                        TopLevel = false
                    };

                    this.panel1.Controls.Add(f);
                    f.Dock = DockStyle.Fill;
                    f.Show();
                    break;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
