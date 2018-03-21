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
    public partial class VehicleSearchForm : Form
    {
        public VehicleSearchForm()
        {
            InitializeComponent();
        }

        private void vehicleTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void VehicleSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.VehicleTable' table. You can move, or remove it, as needed.
            this.vehicleTableTableAdapter.Fill(this.cRMDataSet.VehicleTable);

        }

        private void vehicleSearchBtn_Click(object sender, EventArgs e)
        {
            // Searches by the Owners Last Name.
            this.vehicleTableTableAdapter.OwnerLNameSearch(this.cRMDataSet.VehicleTable, vehicleSearchTxtBox.Text);
        }

        private void vehicleAddBtn_Click(object sender, EventArgs e)
        {
            // Goes to the Vehicle Form if the btn is clicked.
            VehicleForm myVehicleForm = new VehicleForm();
            myVehicleForm.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closes the form.
            this.Close();
        }
    }
}
