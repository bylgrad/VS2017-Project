using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace firstapp
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "vs2010_motorpool";
            uid = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool IsLogin(string a, string b)
        {
            try
            {
                if (this.OpenConnection() == true)
                {
                    int i;
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT COUNT(*) FROM useraccount WHERE username='"+a+"' AND password='"+b+"'";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    i = int.Parse(cmd.ExecuteScalar() + "");
                    if (i == 1)
                    {
                        this.CloseConnection();
                        return true;
                    }
                    else
                    {
                        this.CloseConnection();
                        return false;
                    }
                }
                    else
                    {
                        this.CloseConnection();
                        return false;
                    }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void NewDriver(string objid, string firstname, string lastname, string middlename, string idno)
        {
            string query = "INSERT INTO master_driver (objid, firstname, lastname, middlename, idno) VALUES('" + objid + "', '" + firstname + "', '" + lastname + "', '" + middlename + "', '" + idno + "')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        public void UpdateDriver(string objid, string firstname, string lastname, string middlename, string idno)
        {
            string query = "UPDATE master_driver SET firstname = '" + firstname + "', lastname = '" + lastname + "', middlename = '" + middlename + "', idno = '" + idno + "' WHERE objid = '" + objid + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }



        public void NewVehicle(string objid, string plateno, string brand, string model, string version, string age, string fueltype, string state)
        {
            try
            {
                string datelisted = DateTime.Now.ToString();
                string remarks = "NEW ENTRY";
                string query = "INSERT INTO master_vehicle (objid, plateno, brand, model, version, age, fueltype, state, datelisted, remarks) VALUES('" + objid + "', '" + plateno + "', '" + brand + "', '" + model + "', '" + version + "', '" + age + "', '" + fueltype + "', '" + state + "', '" + datelisted + "', '" + remarks + "')";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.RetryCancel);
            }
            
        }



        public void UpdateVehicle(string objid, string plateno, string brand, string model, string version, string age, string fueltype, string state)
        {
            string remarks = "UPDATED";
            string datelisted = DateTime.Now.ToLongTimeString();
            string query = "UPDATE master_vehicle SET plateno='" + plateno + "', brand='" + brand + "', model='" + model + "', version='" + version + "', age='" + age + "', fueltype='" + fueltype + "', state='" + state + "', datelisted='" + datelisted + "', remarks='" + remarks + "' WHERE objid = '" + objid + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //Insert statement
        /*public void Insert()
        {
            String objid = DateTime.Now.ToString("MMddyyyyHHmmssfff");
            string query = "INSERT INTO driver (objid, firstname, lastname, middlename, idno) VALUES('"+objid+"', 'Pora', 'Explorer', 'D', '2126073')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        } */

        //Update statement
        /*   public void Update()
           {
               string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

               //Open connection
               if (this.OpenConnection() == true)
               {
                   //create mysql command
                   MySqlCommand cmd = new MySqlCommand();
                   //Assign the query using CommandText
                   cmd.CommandText = query;
                   //Assign the connection using Connection
                   cmd.Connection = connection;

                   //Execute query
                   cmd.ExecuteNonQuery();

                   //close connection
                   this.CloseConnection();
               }
           } */

        //Delete statement
        /*   public void Delete()
           {
               string query = "DELETE FROM tableinfo WHERE name='John Smith'";

               if (this.OpenConnection() == true)
               {
                   MySqlCommand cmd = new MySqlCommand(query, connection);
                   cmd.ExecuteNonQuery();
                   this.CloseConnection();
               }
           } */


        //Select statement
        public List<string>[] Select()
        {

            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT COUNT(*) FROM useraccount";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "F:\\" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond;
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
