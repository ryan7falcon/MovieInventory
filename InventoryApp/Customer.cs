using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    //This class represents a customer
    class Customer : Record
    {
        DBconnector dbc = new DBconnector();

        public int id { set; get; }
        public string name { set; get; }
        public string address { set; get; }
        public string phone { set; get; }
        public string email { set; get; }



        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Customer(int id, string name, string address, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Customer", id);

            name = l[1].ToString();
        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[5];

            s[0] = id.ToString();
            s[1] = name;
            s[2] = address;
            s[3] = phone;
            s[4] = email;

            return s;
        }
        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[5];

            s[0] = "id";
            s[1] = "name";
            s[2] = "address";
            s[3] = "phone";
            s[4] = "email";

            return s;
        }
    }
}
