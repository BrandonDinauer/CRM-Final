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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            // If this btn is clicked, goes to the Vehicle Search Form.
            VehicleSearchForm myvehicleSearchForm = new VehicleSearchForm();
            myvehicleSearchForm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            // If this btn is clicked, goes to the customer search form.
            CustomerSearchForm mycustomerSearchForm = new CustomerSearchForm();
            mycustomerSearchForm.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            // If btn is clicked, goes to the Parts Search Form.
            PartSearchForm mypartSearchForm = new PartSearchForm();
            mypartSearchForm.ShowDialog();
        }

        private void invoicesButton_Click(object sender, EventArgs e)
        {
            // If this btn is clicked, goes to the Invoice Search Form.
            InvoiceSearchForm myinvoiceSearchForm = new InvoiceSearchForm();
            myinvoiceSearchForm.ShowDialog();
        }
    }
}
