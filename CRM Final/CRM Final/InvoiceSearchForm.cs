using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Final
{
    public partial class InvoiceSearchForm : Form
    {
        public InvoiceSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if btn is clicked, goes to the Invoice
            Invoice myInvoice = new Invoice();
            myInvoice.ShowDialog();
        }

        private void invoicesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void InvoiceSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.InvoicesTable' table. You can move, or remove it, as needed.
            this.invoicesTableTableAdapter.Fill(this.cRMDataSet.InvoicesTable);

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            // Cloes the form
            this.Close();
        }

        private void searchInvoicebtn_Click(object sender, EventArgs e)
        {
            // If btn is clicked, searches for the Customer Info.
            this.invoicesTableTableAdapter.CustomerInfoSearch(this.cRMDataSet.InvoicesTable, invoiceSearchTxtBox.Text);
        }

        private void editInvoicebtn_Click(object sender, EventArgs e)
        {
            // if btn is clicked, goes to the Invoice Form.
            Invoice myInvoice = new Invoice();
            myInvoice.ShowDialog();
        }
    }
}
