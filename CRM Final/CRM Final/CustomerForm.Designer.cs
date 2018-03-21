namespace CRM_Final
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label phoneNumberAltLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label vehicleLabel;
            System.Windows.Forms.Label invoicesLabel;
            System.Windows.Forms.Label notesLabel;
            this.cRMDataSet = new CRM_Final.CRMDataSet();
            this.customerTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableTableAdapter = new CRM_Final.CRMDataSetTableAdapters.CustomerTableTableAdapter();
            this.tableAdapterManager = new CRM_Final.CRMDataSetTableAdapters.TableAdapterManager();
            this.customerTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customerTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberAltTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.vehicleTextBox = new System.Windows.Forms.TextBox();
            this.invoicesTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.vehicleCustomerBtn = new System.Windows.Forms.Button();
            this.invoiceCustomerSearch = new System.Windows.Forms.Button();
            this.customerExitBtn = new System.Windows.Forms.Button();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            phoneNumberAltLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            vehicleLabel = new System.Windows.Forms.Label();
            invoicesLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingNavigator)).BeginInit();
            this.customerTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableBindingSource
            // 
            this.customerTableBindingSource.DataMember = "CustomerTable";
            this.customerTableBindingSource.DataSource = this.cRMDataSet;
            // 
            // customerTableTableAdapter
            // 
            this.customerTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = this.customerTableTableAdapter;
            this.tableAdapterManager.InvoicesTableTableAdapter = null;
            this.tableAdapterManager.PartsTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRM_Final.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableTableAdapter = null;
            // 
            // customerTableBindingNavigator
            // 
            this.customerTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerTableBindingNavigator.BindingSource = this.customerTableBindingSource;
            this.customerTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerTableBindingNavigatorSaveItem});
            this.customerTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerTableBindingNavigator.Name = "customerTableBindingNavigator";
            this.customerTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerTableBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.customerTableBindingNavigator.TabIndex = 0;
            this.customerTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customerTableBindingNavigatorSaveItem
            // 
            this.customerTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerTableBindingNavigatorSaveItem.Image")));
            this.customerTableBindingNavigatorSaveItem.Name = "customerTableBindingNavigatorSaveItem";
            this.customerTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerTableBindingNavigatorSaveItem.Text = "Save Data";
            this.customerTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerTableBindingNavigatorSaveItem_Click);
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(44, 56);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(44, 13);
            fNameLabel.TabIndex = 3;
            fNameLabel.Text = "FName:";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "FName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(146, 53);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 4;
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(44, 93);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(44, 13);
            lNameLabel.TabIndex = 5;
            lNameLabel.Text = "LName:";
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(146, 90);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(44, 131);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(146, 128);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(44, 170);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(146, 167);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // phoneNumberAltLabel
            // 
            phoneNumberAltLabel.AutoSize = true;
            phoneNumberAltLabel.Location = new System.Drawing.Point(44, 210);
            phoneNumberAltLabel.Name = "phoneNumberAltLabel";
            phoneNumberAltLabel.Size = new System.Drawing.Size(96, 13);
            phoneNumberAltLabel.TabIndex = 11;
            phoneNumberAltLabel.Text = "Phone Number Alt:";
            // 
            // phoneNumberAltTextBox
            // 
            this.phoneNumberAltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "PhoneNumberAlt", true));
            this.phoneNumberAltTextBox.Location = new System.Drawing.Point(146, 207);
            this.phoneNumberAltTextBox.Name = "phoneNumberAltTextBox";
            this.phoneNumberAltTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberAltTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(44, 249);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(146, 246);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Location = new System.Drawing.Point(33, 358);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new System.Drawing.Size(45, 13);
            vehicleLabel.TabIndex = 15;
            vehicleLabel.Text = "Vehicle:";
            // 
            // vehicleTextBox
            // 
            this.vehicleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Vehicle", true));
            this.vehicleTextBox.Location = new System.Drawing.Point(84, 355);
            this.vehicleTextBox.Name = "vehicleTextBox";
            this.vehicleTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleTextBox.TabIndex = 16;
            // 
            // invoicesLabel
            // 
            invoicesLabel.AutoSize = true;
            invoicesLabel.Location = new System.Drawing.Point(220, 358);
            invoicesLabel.Name = "invoicesLabel";
            invoicesLabel.Size = new System.Drawing.Size(50, 13);
            invoicesLabel.TabIndex = 17;
            invoicesLabel.Text = "Invoices:";
            // 
            // invoicesTextBox
            // 
            this.invoicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Invoices", true));
            this.invoicesTextBox.Location = new System.Drawing.Point(276, 355);
            this.invoicesTextBox.Name = "invoicesTextBox";
            this.invoicesTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoicesTextBox.TabIndex = 18;
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(44, 285);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 19;
            notesLabel.Text = "Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerTableBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(146, 282);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 20);
            this.notesTextBox.TabIndex = 20;
            // 
            // vehicleCustomerBtn
            // 
            this.vehicleCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleCustomerBtn.Location = new System.Drawing.Point(84, 386);
            this.vehicleCustomerBtn.Name = "vehicleCustomerBtn";
            this.vehicleCustomerBtn.Size = new System.Drawing.Size(71, 34);
            this.vehicleCustomerBtn.TabIndex = 21;
            this.vehicleCustomerBtn.Text = "Vehicle";
            this.vehicleCustomerBtn.UseVisualStyleBackColor = true;
            this.vehicleCustomerBtn.Click += new System.EventHandler(this.vehicleCustomerBtn_Click);
            // 
            // invoiceCustomerSearch
            // 
            this.invoiceCustomerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCustomerSearch.Location = new System.Drawing.Point(289, 386);
            this.invoiceCustomerSearch.Name = "invoiceCustomerSearch";
            this.invoiceCustomerSearch.Size = new System.Drawing.Size(71, 34);
            this.invoiceCustomerSearch.TabIndex = 22;
            this.invoiceCustomerSearch.Text = "Invoices";
            this.invoiceCustomerSearch.UseVisualStyleBackColor = true;
            this.invoiceCustomerSearch.Click += new System.EventHandler(this.invoiceCustomerSearch_Click);
            // 
            // customerExitBtn
            // 
            this.customerExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerExitBtn.Location = new System.Drawing.Point(394, 397);
            this.customerExitBtn.Name = "customerExitBtn";
            this.customerExitBtn.Size = new System.Drawing.Size(75, 23);
            this.customerExitBtn.TabIndex = 23;
            this.customerExitBtn.Text = "Exit";
            this.customerExitBtn.UseVisualStyleBackColor = true;
            this.customerExitBtn.Click += new System.EventHandler(this.customerExitBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 432);
            this.Controls.Add(this.customerExitBtn);
            this.Controls.Add(this.invoiceCustomerSearch);
            this.Controls.Add(this.vehicleCustomerBtn);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(phoneNumberAltLabel);
            this.Controls.Add(this.phoneNumberAltTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(vehicleLabel);
            this.Controls.Add(this.vehicleTextBox);
            this.Controls.Add(invoicesLabel);
            this.Controls.Add(this.invoicesTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.customerTableBindingNavigator);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTableBindingNavigator)).EndInit();
            this.customerTableBindingNavigator.ResumeLayout(false);
            this.customerTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource customerTableBindingSource;
        private CRMDataSetTableAdapters.CustomerTableTableAdapter customerTableTableAdapter;
        private CRMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox phoneNumberAltTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox vehicleTextBox;
        private System.Windows.Forms.TextBox invoicesTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button vehicleCustomerBtn;
        private System.Windows.Forms.Button invoiceCustomerSearch;
        private System.Windows.Forms.Button customerExitBtn;
    }
}