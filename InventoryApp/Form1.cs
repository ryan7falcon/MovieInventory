using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        MovieForm movForm;
        CustomerForm custForm;
        TransactionForm trForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movForm == null)
            {
                movForm = new MovieForm();
                movForm.MdiParent = this;
                movForm.FormClosed += MovFrm_FormClosed;
                movForm.Show();
            }
            else
            {
                movForm.Activate();
            }
        }

        private void MovFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            movForm = null;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (custForm == null)
            {
                custForm = new CustomerForm();
                custForm.MdiParent = this;
                custForm.FormClosed += CustFrm_FormClosed;
                custForm.Show();
            }
            else
            {
                custForm.Activate();
            }
        }

        private void CustFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            custForm = null;
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trForm == null)
            {
                trForm = new TransactionForm();
                trForm.MdiParent = this;
                trForm.FormClosed += TransactionFrm_FormClosed;
                trForm.Show();
            }
            else
            {
                trForm.Activate();
            }
        }

        private void TransactionFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            trForm = null;
        }
    }
}
