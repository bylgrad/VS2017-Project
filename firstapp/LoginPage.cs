using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Threading;


namespace firstapp
{
    public partial class LoginPage : Form
    {
        //Thread thread;
        MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=1234;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");

        public LoginPage()
        {
            InitializeComponent();
            //dBConnect.Insert();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            DBConnect dBConnect = new DBConnect();
            string user = txtUsername.Text.ToUpper();
            string pass = txtPassword.Text.ToUpper();
            if(dBConnect.IsLogin(user, pass) == true)
            {
                //this.Close();
                //thread = new Thread(mainform);
                //thread.Name = "ambot";
                //thread.SetApartmentState(ApartmentState.STA);
                //thread.Start();
                this.Hide();
                Main main = new Main(txtUsername.Text, "ADMIN");
                
                main.ShowDialog();
                this.Close();
                
            }
             else
            {
                MessageBox.Show("Incorrect Username and Password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            //connection.Close();
        }

        //private void mainform()
        //{
        //    String n = txtUsername.Text;
        //    Console.WriteLine("Thread Running");
        //    Application.Run(new Main(n, "ADMIN"));
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DBConnect dBConnect = new DBConnect();
            //dBConnect.Insert();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Backup();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Count();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
