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
    public partial class CustomerForm : Form
    {
        SqlConnection con;
        DBconnector dbc;
        Customer cu;

        public CustomerForm()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\user;Initial Catalog=SQLdatabase;Integrated Security=True;Connect" +
                " Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            dbc = new DBconnector();

            //get the first index
            int first = dbc.getFirstId("Customer");

            //get the first customer
            cu = getCustomerFromDB(first);
            nId.Value = first;

            //get all customers
            updateList();

            //show the first customer
            fillForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dbc.checkIfExist("Customer", (int)nId.Value))
            {
                dbc.update("Customer", cu);
            }
            else
            {
                dbc.insert("Customer", cu);
            }

            updateList();
        }

        //get a Customer object using info from DB
        private Customer getCustomerFromDB(int index)
        {
            List<string> l = dbc.get("Customer", index);
            return new Customer(Int32.Parse(l[0]), l[1], l[2], l[3], l[4]);
        }

        private void fillForm()
        {

            nId.Value = cu.id;
            tbName.Text = cu.name;
            tbAddress.Text = cu.address;
            tbEmail.Text = cu.email;
            mtbTel.Text = cu.phone;
        }

        private void updateList()
        {
            listView.Items.Clear();

            //get all the customers from the database
            List<List<string>> list = dbc.getList("Customer");
            foreach (List<string> l in list)
            {
                //fill in one row in the listView
                Customer c = new Customer(Int32.Parse(l[0]), l[1], l[2], l[3], l[4]);
                ListViewItem item = new ListViewItem(new[] { c.id.ToString(), c.name });
                listView.Items.Add(item);
            }

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectedListViewItemCollection items = listView.SelectedItems;
            if (items.Count > 0)
            {
                int index = Int32.Parse(items[0].Text);
                cu = getCustomerFromDB(index);
                fillForm();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbc.delete("Customer", Int32.Parse(nId.Text));
            updateList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int id = dbc.getLastId("Customer") + 1;
            nId.Value = id;
        }

        private void nId_ValueChanged(object sender, EventArgs e)
        {
            cu.id = (int) nId.Value;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            cu.name = tbName.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            cu.email = tbEmail.Text;
        }

        private void mtbTel_TextChanged(object sender, EventArgs e)
        {
            cu.phone = mtbTel.Text;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            cu.address = tbAddress.Text;
        }
    }
}
