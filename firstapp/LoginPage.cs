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


namespace firstapp
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            //DBConnect dBConnect = new DBConnect();
            //dBConnect.Insert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT count(*) FROM useraccount WHERE username='"+txtUsername.Text+"' AND password = '" + txtPassword.Text + "'", conn);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
                MessageBox.Show("Incorrect Username and Password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DBConnect dBConnect = new DBConnect();
            dBConnect.Insert();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnect dBConnect = new DBConnect();
            dBConnect.Backup();
        }
    }
}
