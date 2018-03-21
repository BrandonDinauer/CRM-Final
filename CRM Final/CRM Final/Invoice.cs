using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CRM_Final
{
    public partial class Invoice : Form
    {

        public Invoice()
        {
            InitializeComponent();
        }

        private void invoicesTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cRMDataSet);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMDataSet.InvoicesTable' table. You can move, or remove it, as needed.
            this.invoicesTableTableAdapter.Fill(this.cRMDataSet.InvoicesTable);

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // variables for the invoice.
            double total, fluidCheck, tax, laborCost, partsUsed;
            // set fluid to 0.
            fluidCheck = 0;
            // Creates the Invoice.Txt StreamWriter and file
            StreamWriter File = new StreamWriter("Invoice.txt");
            // TryParses for the laborCosts and partsUsed
            double.TryParse(labor_CostsTextBox.Text, out laborCost);
            double.TryParse(parts_UsedTextBox.Text, out partsUsed);
            // If else statment for if the estimate checkbox is checked add estimate, else, make it an invoice.
            if (estemateCheckBox.Checked)
            {
                File.Write("Joe's Automotive Information Estimate\r\n");
            }
            else
            {
                File.Write("Joe's Automotive Information Invoice");
            }
            // If the fluidCheckBox is checked, change the fluidCheck to 24.99 and add it to the file.
            if (fluidCheckbox.Checked)
            {
                fluidCheck = 24.99;
                File.Write("Fluid Checkup: $24.99\r\n");
            }
            // Else, make it so it says $0.
            else
            {
                File.Write("Fluid Checkup: $0\r\n");
            }
            // Gets the tax for the total.
            tax = (fluidCheck + laborCost) * 0.06;
            // Adds all together to get the total.
            total = fluidCheck + laborCost + tax;
            // Writes all needed info into the file.
            File.Write("Labor Costs: " + laborCost.ToString("C") + "\r\n");
            File.Write("Parts Used: " + partsUsed + "\r\n");
            File.Write("Total: " + total.ToString("C") + "\r\n");
            File.Write("Vehicle Information: " + vehicle_InfoTextBox.Text + "\r\n");
            File.Write("Customer Information: " + customer_InfoTextBox.Text);
            File.Close();
            // Changes the totalLbl to the actual total and changes it to a currency.
            invoiceTotallbl.Text = total.ToString("C");
        }

    }
}
