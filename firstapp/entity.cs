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
            public String objid;
            public String plateno;
            public String brand;
            public String model;
            public String version;
            public int age;
            public DateTime datelisted;
            public String fueltype;
            public String state;
            public String remarks;
        }

        public class Useraccount
        {
            public string userid;
            public string username;
            public string password;
            public string role;
        }

        public class Driver
        {
            public string objid;
            public string firstname;
            public string lastname;
            public string middlename;
            public string idno;

        }
    }
}
