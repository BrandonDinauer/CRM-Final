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
    public partial class CustomerSearchForm : Form
    {
        public CustomerSearchForm()
        {
            InitializeComponent();
        }

        private void customerTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void CustomerSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.cRMDataSet.CustomerTable);

        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            // Makes it so it can be searched by the LName.
            this.customerTableTableAdapter.SearchLName(this.cRMDataSet.CustomerTable, customerSearchTxtBox.Text);
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            // If the addBtn is clicked, changes to the customerform.
            CustomerForm myCustomerForm = new CustomerForm();
            myCustomerForm.ShowDialog();
        }

        private void customerExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
