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
    public partial class TransactionForm : Form
    {
        private const decimal TAX = 0.13M;
        SqlConnection con;
        DBconnector dbc;
        Transaction tr;

        public TransactionForm()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLdatabase;Integrated Security=True;Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbc = new DBconnector();

            //get the first index
            int first = dbc.getFirstId("Transaction");
            
            //get the first transaction
            tr = getTransactionFromDB(first);
            nId.Value = first;

            //get all transactions
            updateList();                      
            
            //show the first transaction
            fillForm();

        }

        //set a unique id
        private void btnNew_Click(object sender, EventArgs e)
        {
            int id = dbc.getLastId("Transaction") + 1;
            nId.Value = id;
        }

        //save a transaction in DB, if it doesn't exist, create a new one, if it does, update it
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dbc.checkIfExist("Transaction", (int)nId.Value))
            {
                dbc.update("Transaction", tr);
            }
            else
            {
                dbc.insert("Transaction", tr);
            }

            updateList();
        }

        //delete a transaction
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbc.delete("Transaction", Int32.Parse(nId.Text));
            updateList();
        }

        //load the selected Transaction from DB and display it
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedListViewItemCollection items = listView.SelectedItems;
            if (items.Count > 0)
            {
                int index = Int32.Parse(items[0].Text);
                tr = getTransactionFromDB(index);
                fillForm();
            }
        }

        private void nId_ValueChanged(object sender, EventArgs e)
        {
            tr.id = (int)nId.Value;
        }

        //update customer name
        private void nCustomerId_ValueChanged(object sender, EventArgs e)
        {
            tr.setCustomer((int)nCustomerId.Value);
            nCustomerId.Value = tr.cust.id;
            lblCustomerName.Text = tr.cust.name;

        }

        //update movie name, price, tax and total
        private void nMovieId_ValueChanged(object sender, EventArgs e)
        {

            tr.setMovie((int)nMovieId.Value);
            nMovieId.Value = tr.mov.id;
            lblMovieName.Text = tr.mov.name;
            lblPrice.Text = tr.mov.price.ToString();
            lblTax.Text = tr.tax.ToString();
            lblTotal.Text = tr.total.ToString();

        }

        //update qty, tax and total
        private void nQty_ValueChanged(object sender, EventArgs e)
        {
            tr.qty = (int)nQty.Value;
            tr.calcCost();
            lblTax.Text = tr.tax.ToString();
            lblTotal.Text = tr.total.ToString();
        }     

        //get a Transaction object using info from DB
        private Transaction getTransactionFromDB(int index)
        {
            List<string> l = dbc.get("Transaction", index);
            return new Transaction(Int32.Parse(l[0]), Int32.Parse(l[1]), Int32.Parse(l[2]), Int32.Parse(l[3]));
        }

        //get all the info from Transaction object and display it
        private void fillForm()
        {
            nId.Value = tr.id;
            nCustomerId.Value = tr.cust.id;
            nMovieId.Value = tr.mov.id; 
            nQty.Value = tr.qty;
            lblCustomerName.Text = tr.cust.name;
            lblMovieName.Text = tr.mov.name;
            lblPrice.Text = tr.mov.price.ToString();
            lblTax.Text = tr.tax.ToString();
            lblTotal.Text = tr.total.ToString();          
        }

        //get all the transaction records and pu them to the ListView
        private void updateList()
        {
            listView.Items.Clear();

            //get all the transactions from the database
            List<List<string>> l = dbc.getList("Transaction");
            foreach (List<string> record in l)
            {
                //fill in one row in the listView
                Transaction t = new Transaction(Int32.Parse(record[0]), Int32.Parse(record[1]), Int32.Parse(record[2]), Int32.Parse(record[3]));
                ListViewItem item = new ListViewItem(new[] { t.id.ToString(), t.cust.name, t.mov.name, t.qty.ToString(), t.total.ToString() });
                listView.Items.Add(item);
            }
        }  

    }
}
