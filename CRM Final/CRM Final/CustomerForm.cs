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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void customerTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.cRMDataSet.CustomerTable);

        }

        private void vehicleCustomerBtn_Click(object sender, EventArgs e)
        {
            // If the btn is clicked, goes to the Vehicle Form.
            VehicleForm myVehicleForm = new VehicleForm();
            myVehicleForm.ShowDialog();
        }

        private void invoiceCustomerSearch_Click(object sender, EventArgs e)
        {
            // If btn is clicked, goes to the InvoiceForm
            Invoice myInvoices = new Invoice();
            myInvoices.ShowDialog();
        }

        private void customerExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
