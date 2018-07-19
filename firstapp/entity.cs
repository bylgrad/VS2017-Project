using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    class entity
    {
        
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
            public string objid;
            public string firstname;
            public string lastname;
            public string middlename;
            public string idno;

            public Driver() { }
            public Driver(string objid, string firstname, string lastname, string middlename, string idno)
            {
                this.objid = objid;
                this.firstname = firstname;
                this.lastname= lastname;
                this.middlename= middlename;
                this.idno= idno;
            }
        }
        public void SaveDriver(String a)
        {

        }
    }
}
