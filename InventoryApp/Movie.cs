using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    //This class represents a movie
    class Movie : Record
    {
        DBconnector dbc = new DBconnector();

        public int id { set; get; }
        public string name { set; get; }
        public string number { set; get; }
        public DateTime date { set; get; }
        public string location { set; get; }
        public string genre { set; get; }
        public int rating { set; get; }
        public int duration { set; get; }
        public decimal price { set; get; }

        public Movie(int id)
        {      
            this.id = id;          
        }

        public Movie(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Movie(int id, string name, decimal price, string number, DateTime date, string location, string genre, int rating, int duration)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.number = number;
            this.date = date;
            this.location = location;
            this.genre = genre;
            this.rating = rating;
            this.duration = duration;
        }

        //get the info from DB
        public void loadRecord()
        {
            List<string> l = dbc.get("Movie", id);

            name = l[1];
            price = decimal.Parse(l[2]);
            number = l[3];
            date = DateTime.Parse(l[4]);
            location = l[5];
            genre = l[6];
            rating = Int32.Parse(l[7]);
            duration = Int32.Parse(l[8]);

        }

        //used when updating and inserting records in DB
        override public string[] getParameters()
        {
            string[] s = new string[9];

            s[0] = id.ToString();
            s[1] = name;
            s[2] = price.ToString();
            s[3] = number.ToString();
            s[4] = date.ToString();
            s[5] = location;
            s[6] = genre;
            s[7] = rating.ToString();
            s[8] = duration.ToString();

            return s;
        }
        //used when updating and inserting records in DB
        override public string[] getParameterNames()
        {
            string[] s = new string[9];

            s[0] = "id";
            s[1] = "name";
            s[2] = "price";
            s[3] = "number";
            s[4] = "date";
            s[5] = "location";
            s[6] = "genre";
            s[7] = "rating";
            s[8] = "duration";

            return s;
        }
    }
}
