namespace CRM_Final
{
    partial class InvoiceSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceSearchForm));
            this.createbtn = new System.Windows.Forms.Button();
            this.searchInvoicebtn = new System.Windows.Forms.Button();
            this.editInvoicebtn = new System.Windows.Forms.Button();
            this.invoiceSearchTxtBox = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
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
            this.invoicesTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingNavigator)).BeginInit();
            this.invoicesTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.Location = new System.Drawing.Point(96, 335);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(104, 36);
            this.createbtn.TabIndex = 0;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchInvoicebtn
            // 
            this.searchInvoicebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoicebtn.Location = new System.Drawing.Point(206, 334);
            this.searchInvoicebtn.Name = "searchInvoicebtn";
            this.searchInvoicebtn.Size = new System.Drawing.Size(117, 37);
            this.searchInvoicebtn.TabIndex = 1;
            this.searchInvoicebtn.Text = "Search";
            this.searchInvoicebtn.UseVisualStyleBackColor = true;
            this.searchInvoicebtn.Click += new System.EventHandler(this.searchInvoicebtn_Click);
            // 
            // editInvoicebtn
            // 
            this.editInvoicebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editInvoicebtn.Location = new System.Drawing.Point(329, 335);
            this.editInvoicebtn.Name = "editInvoicebtn";
            this.editInvoicebtn.Size = new System.Drawing.Size(111, 36);
            this.editInvoicebtn.TabIndex = 2;
            this.editInvoicebtn.Text = "Edit";
            this.editInvoicebtn.UseVisualStyleBackColor = true;
            this.editInvoicebtn.Click += new System.EventHandler(this.editInvoicebtn_Click);
            // 
            // invoiceSearchTxtBox
            // 
            this.invoiceSearchTxtBox.Location = new System.Drawing.Point(191, 308);
            this.invoiceSearchTxtBox.Name = "invoiceSearchTxtBox";
            this.invoiceSearchTxtBox.Size = new System.Drawing.Size(143, 20);
            this.invoiceSearchTxtBox.TabIndex = 3;
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(456, 357);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(88, 36);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
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
            this.invoicesTableBindingNavigator.Size = new System.Drawing.Size(545, 25);
            this.invoicesTableBindingNavigator.TabIndex = 5;
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
            // invoicesTableDataGridView
            // 
            this.invoicesTableDataGridView.AutoGenerateColumns = false;
            this.invoicesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.invoicesTableDataGridView.DataSource = this.invoicesTableBindingSource;
            this.invoicesTableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.invoicesTableDataGridView.Name = "invoicesTableDataGridView";
            this.invoicesTableDataGridView.Size = new System.Drawing.Size(545, 271);
            this.invoicesTableDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Invoice ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Invoice ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vehicle Info";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vehicle Info";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Labor Costs";
            this.dataGridViewTextBoxColumn3.HeaderText = "Labor Costs";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Parts Used";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parts Used";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Customer Info";
            this.dataGridViewTextBoxColumn5.HeaderText = "Customer Info";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By Customer Info";
            // 
            // InvoiceSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(545, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoicesTableDataGridView);
            this.Controls.Add(this.invoicesTableBindingNavigator);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.invoiceSearchTxtBox);
            this.Controls.Add(this.editInvoicebtn);
            this.Controls.Add(this.searchInvoicebtn);
            this.Controls.Add(this.createbtn);
            this.Name = "InvoiceSearchForm";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.InvoiceSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableBindingNavigator)).EndInit();
            this.invoicesTableBindingNavigator.ResumeLayout(false);
            this.invoicesTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button searchInvoicebtn;
        private System.Windows.Forms.Button editInvoicebtn;
        private System.Windows.Forms.TextBox invoiceSearchTxtBox;
        private System.Windows.Forms.Button exitbtn;
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
        private System.Windows.Forms.DataGridView invoicesTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
    }
}