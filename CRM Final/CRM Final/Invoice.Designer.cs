namespace CRM_Final
{
    partial class Invoice
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
            System.Windows.Forms.Label vehicle_InfoLabel;
            System.Windows.Forms.Label labor_CostsLabel;
            System.Windows.Forms.Label parts_UsedLabel;
            System.Windows.Forms.Label customer_InfoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.label1 = new System.Windows.Forms.Label();
            this.fluidCheckbox = new System.Windows.Forms.CheckBox();
            this.invoiceTotallbl = new System.Windows.Forms.Label();
            this.cRMDataSet = new CRM_Final.CRMDataSet();
            this.invoicesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableTableAdapter = new CRM_Final.CRMDataSetTableAdapters.InvoicesTableTableAdapter();
            this.tableAdapterManager = new CRM_Final.CRMDataSetTableAdapters.TableAdapterManager();
            this.invoicesTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoicesTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicle_InfoTextBox = new System.Windows.Forms.TextBox();
            this.labor_CostsTextBox = new System.Windows.Forms.TextBox();
            this.parts_UsedTextBox = new System.Windows.Forms.TextBox();
            this.customer_InfoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.estemateCheckBox = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            vehicle_InfoLabel = new System.Windows.Forms.Label();
            labor_CostsLabel = new System.Windows.Forms.Label();
            parts_UsedLabel = new System.Windows.Forms.Label();
            customer_InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingNavigator)).BeginInit();
            this.invoicesTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicle_InfoLabel
            // 
            vehicle_InfoLabel.AutoSize = true;
            vehicle_InfoLabel.Location = new System.Drawing.Point(247, 337);
            vehicle_InfoLabel.Name = "vehicle_InfoLabel";
            vehicle_InfoLabel.Size = new System.Drawing.Size(66, 13);
            vehicle_InfoLabel.TabIndex = 7;
            vehicle_InfoLabel.Text = "Vehicle Info:";
            // 
            // labor_CostsLabel
            // 
            labor_CostsLabel.AutoSize = true;
            labor_CostsLabel.Location = new System.Drawing.Point(10, 115);
            labor_CostsLabel.Name = "labor_CostsLabel";
            labor_CostsLabel.Size = new System.Drawing.Size(66, 13);
            labor_CostsLabel.TabIndex = 9;
            labor_CostsLabel.Text = "Labor Costs:";
            // 
            // parts_UsedLabel
            // 
            parts_UsedLabel.AutoSize = true;
            parts_UsedLabel.Location = new System.Drawing.Point(10, 150);
            parts_UsedLabel.Name = "parts_UsedLabel";
            parts_UsedLabel.Size = new System.Drawing.Size(62, 13);
            parts_UsedLabel.TabIndex = 11;
            parts_UsedLabel.Text = "Parts Used:";
            // 
            // customer_InfoLabel
            // 
            customer_InfoLabel.AutoSize = true;
            customer_InfoLabel.Location = new System.Drawing.Point(23, 337);
            customer_InfoLabel.Name = "customer_InfoLabel";
            customer_InfoLabel.Size = new System.Drawing.Size(75, 13);
            customer_InfoLabel.TabIndex = 13;
            customer_InfoLabel.Text = "Customer Info:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe\'s Automotive Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fluidCheckbox
            // 
            this.fluidCheckbox.AutoSize = true;
            this.fluidCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidCheckbox.Location = new System.Drawing.Point(24, 173);
            this.fluidCheckbox.Name = "fluidCheckbox";
            this.fluidCheckbox.Size = new System.Drawing.Size(129, 24);
            this.fluidCheckbox.TabIndex = 1;
            this.fluidCheckbox.Text = "Fluid Checkup";
            this.fluidCheckbox.UseVisualStyleBackColor = true;
            // 
            // invoiceTotallbl
            // 
            this.invoiceTotallbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceTotallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceTotallbl.Location = new System.Drawing.Point(91, 264);
            this.invoiceTotallbl.Name = "invoiceTotallbl";
            this.invoiceTotallbl.Size = new System.Drawing.Size(122, 29);
            this.invoiceTotallbl.TabIndex = 3;
            this.invoiceTotallbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableBindingSource
            // 
            this.invoicesTableBindingSource.DataMember = "InvoicesTable";
            this.invoicesTableBindingSource.DataSource = this.cRMDataSet;
            // 
            // invoicesTableTableAdapter
            // 
            this.invoicesTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = null;
            this.tableAdapterManager.InvoicesTableTableAdapter = this.invoicesTableTableAdapter;
            this.tableAdapterManager.PartsTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRM_Final.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableTableAdapter = null;
            // 
            // invoicesTableBindingNavigator
            // 
            this.invoicesTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoicesTableBindingNavigator.BindingSource = this.invoicesTableBindingSource;
            this.invoicesTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoicesTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoicesTableBindingNavigatorSaveItem});
            this.invoicesTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoicesTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoicesTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoicesTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoicesTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoicesTableBindingNavigator.Name = "invoicesTableBindingNavigator";
            this.invoicesTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesTableBindingNavigator.Size = new System.Drawing.Size(472, 25);
            this.invoicesTableBindingNavigator.TabIndex = 4;
            this.invoicesTableBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // invoicesTableBindingNavigatorSaveItem
            // 
            this.invoicesTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesTableBindingNavigatorSaveItem.Image")));
            this.invoicesTableBindingNavigatorSaveItem.Name = "invoicesTableBindingNavigatorSaveItem";
            this.invoicesTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoicesTableBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesTableBindingNavigatorSaveItem_Click);
            // 
            // vehicle_InfoTextBox
            // 
            this.vehicle_InfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "Vehicle Info", true));
            this.vehicle_InfoTextBox.Location = new System.Drawing.Point(328, 337);
            this.vehicle_InfoTextBox.Name = "vehicle_InfoTextBox";
            this.vehicle_InfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicle_InfoTextBox.TabIndex = 8;
            // 
            // labor_CostsTextBox
            // 
            this.labor_CostsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "Labor Costs", true));
            this.labor_CostsTextBox.Location = new System.Drawing.Point(91, 112);
            this.labor_CostsTextBox.Name = "labor_CostsTextBox";
            this.labor_CostsTextBox.Size = new System.Drawing.Size(100, 20);
            this.labor_CostsTextBox.TabIndex = 10;
            // 
            // parts_UsedTextBox
            // 
            this.parts_UsedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "Parts Used", true));
            this.parts_UsedTextBox.Location = new System.Drawing.Point(91, 147);
            this.parts_UsedTextBox.Name = "parts_UsedTextBox";
            this.parts_UsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_UsedTextBox.TabIndex = 12;
            // 
            // customer_InfoTextBox
            // 
            this.customer_InfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesTableBindingSource, "Customer Info", true));
            this.customer_InfoTextBox.Location = new System.Drawing.Point(104, 334);
            this.customer_InfoTextBox.Name = "customer_InfoTextBox";
            this.customer_InfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_InfoTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total:";
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(383, 380);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(89, 27);
            this.exitbtn.TabIndex = 16;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // estemateCheckBox
            // 
            this.estemateCheckBox.AutoSize = true;
            this.estemateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estemateCheckBox.Location = new System.Drawing.Point(24, 204);
            this.estemateCheckBox.Name = "estemateCheckBox";
            this.estemateCheckBox.Size = new System.Drawing.Size(91, 24);
            this.estemateCheckBox.TabIndex = 17;
            this.estemateCheckBox.Text = "Estimate";
            this.estemateCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(198, 360);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 37);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 409);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.estemateCheckBox);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(vehicle_InfoLabel);
            this.Controls.Add(this.vehicle_InfoTextBox);
            this.Controls.Add(labor_CostsLabel);
            this.Controls.Add(this.labor_CostsTextBox);
            this.Controls.Add(parts_UsedLabel);
            this.Controls.Add(this.parts_UsedTextBox);
            this.Controls.Add(customer_InfoLabel);
            this.Controls.Add(this.customer_InfoTextBox);
            this.Controls.Add(this.invoicesTableBindingNavigator);
            this.Controls.Add(this.invoiceTotallbl);
            this.Controls.Add(this.fluidCheckbox);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingNavigator)).EndInit();
            this.invoicesTableBindingNavigator.ResumeLayout(false);
            this.invoicesTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fluidCheckbox;
        private System.Windows.Forms.Label invoiceTotallbl;
        private CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource invoicesTableBindingSource;
        private CRMDataSetTableAdapters.InvoicesTableTableAdapter invoicesTableTableAdapter;
        private CRMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoicesTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoicesTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehicle_InfoTextBox;
        private System.Windows.Forms.TextBox labor_CostsTextBox;
        private System.Windows.Forms.TextBox parts_UsedTextBox;
        private System.Windows.Forms.TextBox customer_InfoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.CheckBox estemateCheckBox;
        private System.Windows.Forms.Button saveBtn;
    }
}