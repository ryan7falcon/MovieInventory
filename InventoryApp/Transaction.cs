using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    class Transaction : Record
    {
        DBconnector dbc = new DBconnector();

        public int id { set; get; }
        
        public int qty { set; get; }

        public Customer cust { set; get; }
        public Movie mov { set ; get; }

        public decimal tax { set; get; }
        public decimal total { set; get; }

        const decimal TAX_RATE = 0.13M;


        public Transaction() { }
        
        //unsafe - customerId and movieId must be valid
        //for use when loading from db
        public Transaction (int id, int customerId, int movieId, int qty)
        {
            this.id = id;
            this.qty = qty;

            setCustomer(customerId);
            setMovie(movieId);

        }
        //same, but accepts an array of string parameters
        public Transaction(string [] args)
        {
            this.id = Int32.Parse(args[0]);
            this.qty = Int32.Parse(args[1]);

            setCustomer(Int32.Parse(args[2]));
            setMovie(Int32.Parse(args[3]));
        }

        //safe
        public Transaction(int id, int qty)
        {
            this.id = id;
            this.qty = qty;
        }

        public decimal calcTax()
        {
            return TAX_RATE * qty * mov.price;
        }

        public decimal calcTotal()
        {
            return (TAX_RATE+1) * qty * mov.price;
        }

        public void calcCost()
        {
            tax = calcTax();
            total = calcTotal();
        }

        public int setMovie(int movieId)
        {
            if (dbc.checkIfExist("Movie", movieId))
            {
                mov = new Movie(movieId);
                mov.loadRecord();
                calcCost();
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public int setCustomer(int customerId)
        {            
            if (dbc.checkIfExist("Customer", customerId))
            {
                cust = new Customer(customerId);
                cust.loadRecord();

                return 0;
            }
            else
            {
                return -1;
            }        
        }

        override public string[] getParameters()
        {
            string[] s = new string[5];

            s[0] = id.ToString();
            s[1] = cust.id.ToString();
            s[2] = mov.id.ToString();
            s[3] = qty.ToString();
            s[4] = total.ToString();

            return s;
        }

        override public string[] getParameterNames()
        {
            string[] s = new string[5];

            s[0] = "id";
            s[1] = "customerId";
            s[2] = "movieId";
            s[3] = "qty";
            s[4] = "total";

            return s;
        }

    }
}
