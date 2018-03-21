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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void partsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.PartsTable' table. You can move, or remove it, as needed.
            this.partsTableTableAdapter.Fill(this.cRMDataSet.PartsTable);

        }

        private void vehiclePartbtn_Click(object sender, EventArgs e)
        {
            // goes to vehicle form is btn is clicked.
            VehicleForm myVehicleForm = new VehicleForm();
            myVehicleForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // closes the form.
            this.Close();
        }
    }
}
