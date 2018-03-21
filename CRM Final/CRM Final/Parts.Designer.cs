namespace CRM_Final
{
    partial class Parts
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
            System.Windows.Forms.Label part_NameLabel;
            System.Windows.Forms.Label in_StockLabel;
            System.Windows.Forms.Label on_OrderLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label vehicles_Part_Works_onLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parts));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehiclePartbtn = new System.Windows.Forms.Button();
            this.cRMDataSet = new CRM_Final.CRMDataSet();
            this.partsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableTableAdapter = new CRM_Final.CRMDataSetTableAdapters.PartsTableTableAdapter();
            this.tableAdapterManager = new CRM_Final.CRMDataSetTableAdapters.TableAdapterManager();
            this.partsTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.partsTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.part_NameTextBox = new System.Windows.Forms.TextBox();
            this.in_StockTextBox = new System.Windows.Forms.TextBox();
            this.on_OrderTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.vehicles_Part_Works_onTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            part_NameLabel = new System.Windows.Forms.Label();
            in_StockLabel = new System.Windows.Forms.Label();
            on_OrderLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            vehicles_Part_Works_onLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingNavigator)).BeginInit();
            this.partsTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // part_NameLabel
            // 
            part_NameLabel.AutoSize = true;
            part_NameLabel.Location = new System.Drawing.Point(11, 97);
            part_NameLabel.Name = "part_NameLabel";
            part_NameLabel.Size = new System.Drawing.Size(60, 13);
            part_NameLabel.TabIndex = 5;
            part_NameLabel.Text = "Part Name:";
            // 
            // in_StockLabel
            // 
            in_StockLabel.AutoSize = true;
            in_StockLabel.Location = new System.Drawing.Point(11, 135);
            in_StockLabel.Name = "in_StockLabel";
            in_StockLabel.Size = new System.Drawing.Size(50, 13);
            in_StockLabel.TabIndex = 7;
            in_StockLabel.Text = "In Stock:";
            // 
            // on_OrderLabel
            // 
            on_OrderLabel.AutoSize = true;
            on_OrderLabel.Location = new System.Drawing.Point(11, 171);
            on_OrderLabel.Name = "on_OrderLabel";
            on_OrderLabel.Size = new System.Drawing.Size(53, 13);
            on_OrderLabel.TabIndex = 9;
            on_OrderLabel.Text = "On Order:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(11, 206);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 11;
            costLabel.Text = "Cost:";
            // 
            // vehicles_Part_Works_onLabel
            // 
            vehicles_Part_Works_onLabel.AutoSize = true;
            vehicles_Part_Works_onLabel.Location = new System.Drawing.Point(11, 244);
            vehicles_Part_Works_onLabel.Name = "vehicles_Part_Works_onLabel";
            vehicles_Part_Works_onLabel.Size = new System.Drawing.Size(121, 13);
            vehicles_Part_Works_onLabel.TabIndex = 13;
            vehicles_Part_Works_onLabel.Text = "Vehicles Part Works on:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vehiclePartbtn
            // 
            this.vehiclePartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclePartbtn.Location = new System.Drawing.Point(138, 279);
            this.vehiclePartbtn.Name = "vehiclePartbtn";
            this.vehiclePartbtn.Size = new System.Drawing.Size(100, 45);
            this.vehiclePartbtn.TabIndex = 1;
            this.vehiclePartbtn.Text = "Vehicle";
            this.vehiclePartbtn.UseVisualStyleBackColor = true;
            this.vehiclePartbtn.Click += new System.EventHandler(this.vehiclePartbtn_Click);
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableBindingSource
            // 
            this.partsTableBindingSource.DataMember = "PartsTable";
            this.partsTableBindingSource.DataSource = this.cRMDataSet;
            // 
            // partsTableTableAdapter
            // 
            this.partsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            // this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableTableAdapter = null;
            this.tableAdapterManager.PartsTableTableAdapter = this.partsTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRM_Final.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableTableAdapter = null;
            // 
            // partsTableBindingNavigator
            // 
            this.partsTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partsTableBindingNavigator.BindingSource = this.partsTableBindingSource;
            this.partsTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partsTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partsTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partsTableBindingNavigatorSaveItem});
            this.partsTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partsTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partsTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partsTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partsTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partsTableBindingNavigator.Name = "partsTableBindingNavigator";
            this.partsTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partsTableBindingNavigator.Size = new System.Drawing.Size(393, 25);
            this.partsTableBindingNavigator.TabIndex = 2;
            this.partsTableBindingNavigator.Text = "bindingNavigator1";
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
            // partsTableBindingNavigatorSaveItem
            // 
            this.partsTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partsTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partsTableBindingNavigatorSaveItem.Image")));
            this.partsTableBindingNavigatorSaveItem.Name = "partsTableBindingNavigatorSaveItem";
            this.partsTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partsTableBindingNavigatorSaveItem.Text = "Save Data";
            this.partsTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.partsTableBindingNavigatorSaveItem_Click);
            // 
            // part_NameTextBox
            // 
            this.part_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsTableBindingSource, "Part Name", true));
            this.part_NameTextBox.Location = new System.Drawing.Point(138, 94);
            this.part_NameTextBox.Name = "part_NameTextBox";
            this.part_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_NameTextBox.TabIndex = 6;
            // 
            // in_StockTextBox
            // 
            this.in_StockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsTableBindingSource, "In Stock", true));
            this.in_StockTextBox.Location = new System.Drawing.Point(138, 132);
            this.in_StockTextBox.Name = "in_StockTextBox";
            this.in_StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.in_StockTextBox.TabIndex = 8;
            // 
            // on_OrderTextBox
            // 
            this.on_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsTableBindingSource, "On Order", true));
            this.on_OrderTextBox.Location = new System.Drawing.Point(138, 168);
            this.on_OrderTextBox.Name = "on_OrderTextBox";
            this.on_OrderTextBox.Size = new System.Drawing.Size(100, 20);
            this.on_OrderTextBox.TabIndex = 10;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsTableBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(138, 203);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 12;
            // 
            // vehicles_Part_Works_onTextBox
            // 
            this.vehicles_Part_Works_onTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsTableBindingSource, "Vehicles Part Works on", true));
            this.vehicles_Part_Works_onTextBox.Location = new System.Drawing.Point(138, 241);
            this.vehicles_Part_Works_onTextBox.Name = "vehicles_Part_Works_onTextBox";
            this.vehicles_Part_Works_onTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicles_Part_Works_onTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(393, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(part_NameLabel);
            this.Controls.Add(this.part_NameTextBox);
            this.Controls.Add(in_StockLabel);
            this.Controls.Add(this.in_StockTextBox);
            this.Controls.Add(on_OrderLabel);
            this.Controls.Add(this.on_OrderTextBox);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(vehicles_Part_Works_onLabel);
            this.Controls.Add(this.vehicles_Part_Works_onTextBox);
            this.Controls.Add(this.partsTableBindingNavigator);
            this.Controls.Add(this.vehiclePartbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Parts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingNavigator)).EndInit();
            this.partsTableBindingNavigator.ResumeLayout(false);
            this.partsTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button vehiclePartbtn;
        private CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource partsTableBindingSource;
        private CRMDataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter;
        private CRMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partsTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partsTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox part_NameTextBox;
        private System.Windows.Forms.TextBox in_StockTextBox;
        private System.Windows.Forms.TextBox on_OrderTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox vehicles_Part_Works_onTextBox;
        private System.Windows.Forms.Button button1;
    }
}