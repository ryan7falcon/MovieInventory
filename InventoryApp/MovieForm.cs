using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace InventoryApp
{
    public partial class MovieForm : Form
    {
        SqlConnection con;
        DBconnector dbc;
        Movie mov;

        public MovieForm()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLdatabase;Integrated Security=True;Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbc = new DBconnector();

            //get the first index
            int first = dbc.getFirstId("Movie");

            //get the first movie
            mov = getMovieFromDB(first);
            nId.Value = first;

            //get all movies
            updateList();

            //show the first movie
            fillForm();
        }
        //get a Movie object using info from DB
        private Movie getMovieFromDB(int index)
        {
            List<string> l = dbc.get("Movie", index);

            return new Movie(Int32.Parse(l[0]), l[1], decimal.Parse(l[2]), l[3], DateTime.Parse(l[4]), l[5], l[6], Int32.Parse(l[7]), Int32.Parse(l[8]));
        }

        private void updateList()
        {
            listView.Items.Clear();

            //get all the Movies from the database
            List<List<string>> list = dbc.getList("Movie");
            foreach (List<string> l in list)
            {
                //fill in one row in the listView
                Movie m = new Movie(Int32.Parse(l[0]), l[1], decimal.Parse(l[2]), l[3], DateTime.Parse(l[4]), l[5], l[6], Int32.Parse(l[7]), Int32.Parse(l[8]));
                ListViewItem item = new ListViewItem(new[] { m.id.ToString(), m.name });
                listView.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dbc.checkIfExist("Movie", (int)nId.Value))
            {
                dbc.update("Movie", mov);
            }
            else
            {
                dbc.insert("Movie", mov);
            }


            updateList();
        }


        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {

            dbc.delete("Movie", Int32.Parse(nId.Text));
            updateList();
        }


        private void lvMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListViewItemCollection items = listView.SelectedItems;
            if (items.Count > 0)
            {
                int index = Int32.Parse(items[0].Text);
                mov = getMovieFromDB(index);
                fillForm();
            }
        }

        private void fillForm()
        {
            nId.Value = mov.id;
            tbName.Text = mov.name;
            nPrice.Value = mov.price;
            tbNumber.Text = mov.number;
            tbDate1.Value = mov.date;
            string loc = mov.location;
            if (loc == "Canadian")
            {
                rbCanadian.Checked = true;
            }
            else
            {
                rbInternational.Checked = true;
            }
            cbxGenre.Text = mov.genre;
            cbxRating.Value = mov.rating;
            nDuration.Value = mov.duration;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int id = dbc.getLastId("Movie") + 1;
            nId.Value = id;
        }

        private void nId_ValueChanged(object sender, EventArgs e)
        {
           mov.id = (int)nId.Value;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            mov.name = tbName.Text;
        }

        private void nPrice_ValueChanged(object sender, EventArgs e)
        {
            mov.price = nPrice.Value;
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            mov.number = tbNumber.Text;
        }

        private void tbDate1_ValueChanged(object sender, EventArgs e)
        {
            mov.date = tbDate1.Value;
        }

        private void rbInternational_CheckedChanged(object sender, EventArgs e)
        {
            mov.location = "International";
        }

        private void rbCanadian_CheckedChanged(object sender, EventArgs e)
        {
            mov.location = "Canadian";
        }

        private void cbxGenre_TextChanged(object sender, EventArgs e)
        {
            mov.genre = cbxGenre.Text;
        }

        private void cbxRating_ValueChanged(object sender, EventArgs e)
        {
            mov.rating = (int)cbxRating.Value;
        }

        private void nDuration_ValueChanged(object sender, EventArgs e)
        {
            mov.duration = (int)nDuration.Value;
        }
    }
}
