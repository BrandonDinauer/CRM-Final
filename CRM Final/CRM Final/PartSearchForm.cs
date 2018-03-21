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
    public partial class PartSearchForm : Form
    {
        public PartSearchForm()
        {
            InitializeComponent();
        }

        private void partsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void PartSearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.PartsTable' table. You can move, or remove it, as needed.
            this.partsTableTableAdapter.Fill(this.cRMDataSet.PartsTable);

        }

        private void partsAddbtn_Click(object sender, EventArgs e)
        {
            // Makes it so if the addBtn is clicked, then it will go to the PartsForm
            Parts myParts = new Parts();
            myParts.ShowDialog();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        private void searchPartbtn_Click(object sender, EventArgs e)
        {
            // This is how to search for the part name
            this.partsTableTableAdapter.PartSearch(this.cRMDataSet.PartsTable, partSearchTxtBox.Text);
        }
    }
}
