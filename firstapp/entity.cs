using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace firstapp
{
    class entity
    {
        public MySqlConnection connection;
        public string server;
        public string database;
        public string uid;
        public string password;

        public entity()
        {
            Initialize();
        }
        public void Initialize()
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

        public class Vehicle
        {
            string objid;
            string plateno;
            string brand;
            string model;
            string version;
            int age;
            DateTime datelisted;
            string fueltype;
            string state;
            string remarks;

            public Vehicle() { }
            public Vehicle(String objid, String plateno, String brand, String model, String version, int age, DateTime datelisted, String fueltype, String state, String remarks)
            {
                this.objid = objid;
                this.plateno = plateno;
                this.brand = brand;
                this.model = model;
                this.version = version;
                this.age = age;
                this.datelisted = datelisted;
                this.fueltype = fueltype;
                this.state = state;
                this.remarks = remarks;
            }
        }

        public class Useraccount
        {
            public string userid;
            public string username;
            public string password;
            public string role;

            public Useraccount() { }
            public Useraccount(string uid, string user, string pwd, string role)
            {
                this.userid = uid;
                this.username = user;
                this.password = pwd;
                this.role = role;
            }
        }

        public class Driver
        {
             string objid;
             string firstname;
             string lastname;
             string middlename;
             string idno;

            public String getObjid()
            {
                return objid;
            }
            public void setObjid(String objid)
            {
                this.objid = objid;
            }

            public String getFirstname()
            {
                return firstname;
            }
            public void setFirstname(String firstname)
            {
                this.firstname = firstname;
            }

            public String getLastname()
            {
                return lastname;
            }
            public void setLastname(String lastname)
            {
                this.lastname = lastname;
            }

            public String getMiddlename()
            {
                return middlename;
            }
            public void setMiddlename(String middlename)
            {
                this.middlename = middlename;
            }

            public String getIdno()
            {
                return idno;
            }
            public void setIdno(String idno)
            {
                this.idno = idno;
            }

            public void newdriver()
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=1234;database=vs2010_motorpool;allowuservariables=True;persistsecurityinfo=True");
                //entity.Driver driver = new entity.Driver();
                string query = "INSERT INTO driver (objid, firstname, lastname, middlename, idno) VALUES('" + getObjid() + "', '" + getFirstname() + "', '" + getLastname() + "', '" + getMiddlename() + "', '" + getIdno() + "')";
                    //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();
                
            }
            
            //public Driver() { }
            //public Driver(string objid, string firstname, string lastname, string middlename, string idno)
            //{
            //    this.objid = objid;
            //    this.firstname = firstname;
            //    this.lastname= lastname;
            //    this.middlename= middlename;
            //    this.idno= idno;
            //}
        }
    }
}
