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
    public partial class VehicleForm : Form
    {
        public VehicleForm()
        {
            InitializeComponent();
        }

        private void vehicleTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.VehicleTable' table. You can move, or remove it, as needed.
            this.vehicleTableTableAdapter.Fill(this.cRMDataSet.VehicleTable);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Goes to the CustomerForm is btn is clicked.
            CustomerForm myCustomerForm = new CustomerForm();
            myCustomerForm.ShowDialog();
        }

        private void partsVehicleBtn_Click(object sender, EventArgs e)
        {
            // Goes to the Parts Form if the btn is clicked.
            Parts myParts = new Parts();
            myParts.ShowDialog();
        }

        private void invoicesVehicleBtn_Click(object sender, EventArgs e)
        {
            // Goes to the Invoice form if the btn is clicked.
            Invoice myInvoice = new Invoice();
            myInvoice.ShowDialog();
        }

        private void vehicleExitBtn_Click(object sender, EventArgs e)
        {
            // Closes the Form.
            this.Close();
        }
    }
}
