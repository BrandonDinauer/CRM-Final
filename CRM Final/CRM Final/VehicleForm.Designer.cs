namespace CRM_Final
{
    partial class VehicleForm
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
            System.Windows.Forms.Label vehicle_IDLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label mileageLabel;
            System.Windows.Forms.Label date_ReceivedLabel;
            System.Windows.Forms.Label date_ReturnedLabel;
            System.Windows.Forms.Label owner_First_NameLabel;
            System.Windows.Forms.Label owner_Last_NameLabel;
            System.Windows.Forms.Label invoicesLabel;
            System.Windows.Forms.Label parts_AvailableLabel;
            System.Windows.Forms.Label notesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleForm));
            this.cRMDataSet = new CRM_Final.CRMDataSet();
            this.vehicleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableTableAdapter = new CRM_Final.CRMDataSetTableAdapters.VehicleTableTableAdapter();
            this.tableAdapterManager = new CRM_Final.CRMDataSetTableAdapters.TableAdapterManager();
            this.vehicleTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vehicleTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicle_IDTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.date_ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.date_ReturnedTextBox = new System.Windows.Forms.TextBox();
            this.owner_First_NameTextBox = new System.Windows.Forms.TextBox();
            this.owner_Last_NameTextBox = new System.Windows.Forms.TextBox();
            this.invoicesTextBox = new System.Windows.Forms.TextBox();
            this.parts_AvailableTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ownerVehicleBtn = new System.Windows.Forms.Button();
            this.partsVehicleBtn = new System.Windows.Forms.Button();
            this.invoicesVehicleBtn = new System.Windows.Forms.Button();
            this.vehicleExitBtn = new System.Windows.Forms.Button();
            vehicle_IDLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            mileageLabel = new System.Windows.Forms.Label();
            date_ReceivedLabel = new System.Windows.Forms.Label();
            date_ReturnedLabel = new System.Windows.Forms.Label();
            owner_First_NameLabel = new System.Windows.Forms.Label();
            owner_Last_NameLabel = new System.Windows.Forms.Label();
            invoicesLabel = new System.Windows.Forms.Label();
            parts_AvailableLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingNavigator)).BeginInit();
            this.vehicleTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicle_IDLabel
            // 
            vehicle_IDLabel.AutoSize = true;
            vehicle_IDLabel.Location = new System.Drawing.Point(42, 57);
            vehicle_IDLabel.Name = "vehicle_IDLabel";
            vehicle_IDLabel.Size = new System.Drawing.Size(59, 13);
            vehicle_IDLabel.TabIndex = 1;
            vehicle_IDLabel.Text = "Vehicle ID:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(42, 97);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(42, 136);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 5;
            modelLabel.Text = "Model:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(42, 175);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 7;
            yearLabel.Text = "Year:";
            // 
            // mileageLabel
            // 
            mileageLabel.AutoSize = true;
            mileageLabel.Location = new System.Drawing.Point(42, 214);
            mileageLabel.Name = "mileageLabel";
            mileageLabel.Size = new System.Drawing.Size(47, 13);
            mileageLabel.TabIndex = 9;
            mileageLabel.Text = "Mileage:";
            // 
            // date_ReceivedLabel
            // 
            date_ReceivedLabel.AutoSize = true;
            date_ReceivedLabel.Location = new System.Drawing.Point(42, 255);
            date_ReceivedLabel.Name = "date_ReceivedLabel";
            date_ReceivedLabel.Size = new System.Drawing.Size(82, 13);
            date_ReceivedLabel.TabIndex = 11;
            date_ReceivedLabel.Text = "Date Received:";
            // 
            // date_ReturnedLabel
            // 
            date_ReturnedLabel.AutoSize = true;
            date_ReturnedLabel.Location = new System.Drawing.Point(42, 297);
            date_ReturnedLabel.Name = "date_ReturnedLabel";
            date_ReturnedLabel.Size = new System.Drawing.Size(80, 13);
            date_ReturnedLabel.TabIndex = 13;
            date_ReturnedLabel.Text = "Date Returned:";
            // 
            // owner_First_NameLabel
            // 
            owner_First_NameLabel.AutoSize = true;
            owner_First_NameLabel.Location = new System.Drawing.Point(12, 371);
            owner_First_NameLabel.Name = "owner_First_NameLabel";
            owner_First_NameLabel.Size = new System.Drawing.Size(94, 13);
            owner_First_NameLabel.TabIndex = 15;
            owner_First_NameLabel.Text = "Owner First Name:";
            // 
            // owner_Last_NameLabel
            // 
            owner_Last_NameLabel.AutoSize = true;
            owner_Last_NameLabel.Location = new System.Drawing.Point(12, 407);
            owner_Last_NameLabel.Name = "owner_Last_NameLabel";
            owner_Last_NameLabel.Size = new System.Drawing.Size(95, 13);
            owner_Last_NameLabel.TabIndex = 17;
            owner_Last_NameLabel.Text = "Owner Last Name:";
            // 
            // invoicesLabel
            // 
            invoicesLabel.AutoSize = true;
            invoicesLabel.Location = new System.Drawing.Point(440, 371);
            invoicesLabel.Name = "invoicesLabel";
            invoicesLabel.Size = new System.Drawing.Size(50, 13);
            invoicesLabel.TabIndex = 19;
            invoicesLabel.Text = "Invoices:";
            // 
            // parts_AvailableLabel
            // 
            parts_AvailableLabel.AutoSize = true;
            parts_AvailableLabel.Location = new System.Drawing.Point(234, 371);
            parts_AvailableLabel.Name = "parts_AvailableLabel";
            parts_AvailableLabel.Size = new System.Drawing.Size(80, 13);
            parts_AvailableLabel.TabIndex = 21;
            parts_AvailableLabel.Text = "Parts Available:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(382, 281);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "Notes:";
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTableBindingSource
            // 
            this.vehicleTableBindingSource.DataMember = "VehicleTable";
            this.vehicleTableBindingSource.DataSource = this.cRMDataSet;
            // 
            // vehicleTableTableAdapter
            // 
            this.vehicleTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableTableAdapter = null;
            this.tableAdapterManager.InvoicesTableTableAdapter = null;
            this.tableAdapterManager.PartsTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRM_Final.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableTableAdapter = this.vehicleTableTableAdapter;
            // 
            // vehicleTableBindingNavigator
            // 
            this.vehicleTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehicleTableBindingNavigator.BindingSource = this.vehicleTableBindingSource;
            this.vehicleTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehicleTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehicleTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vehicleTableBindingNavigatorSaveItem});
            this.vehicleTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehicleTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehicleTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehicleTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehicleTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehicleTableBindingNavigator.Name = "vehicleTableBindingNavigator";
            this.vehicleTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehicleTableBindingNavigator.Size = new System.Drawing.Size(698, 25);
            this.vehicleTableBindingNavigator.TabIndex = 0;
            this.vehicleTableBindingNavigator.Text = "bindingNavigator1";
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
            // vehicleTableBindingNavigatorSaveItem
            // 
            this.vehicleTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehicleTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehicleTableBindingNavigatorSaveItem.Image")));
            this.vehicleTableBindingNavigatorSaveItem.Name = "vehicleTableBindingNavigatorSaveItem";
            this.vehicleTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vehicleTableBindingNavigatorSaveItem.Text = "Save Data";
            this.vehicleTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehicleTableBindingNavigatorSaveItem_Click);
            // 
            // vehicle_IDTextBox
            // 
            this.vehicle_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Vehicle ID", true));
            this.vehicle_IDTextBox.Location = new System.Drawing.Point(143, 54);
            this.vehicle_IDTextBox.Name = "vehicle_IDTextBox";
            this.vehicle_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicle_IDTextBox.TabIndex = 2;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(143, 94);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 20);
            this.makeTextBox.TabIndex = 4;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(143, 133);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(143, 172);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Mileage", true));
            this.mileageTextBox.Location = new System.Drawing.Point(143, 211);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(100, 20);
            this.mileageTextBox.TabIndex = 10;
            // 
            // date_ReceivedTextBox
            // 
            this.date_ReceivedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Date Received", true));
            this.date_ReceivedTextBox.Location = new System.Drawing.Point(143, 252);
            this.date_ReceivedTextBox.Name = "date_ReceivedTextBox";
            this.date_ReceivedTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_ReceivedTextBox.TabIndex = 12;
            // 
            // date_ReturnedTextBox
            // 
            this.date_ReturnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Date Returned", true));
            this.date_ReturnedTextBox.Location = new System.Drawing.Point(143, 294);
            this.date_ReturnedTextBox.Name = "date_ReturnedTextBox";
            this.date_ReturnedTextBox.Size = new System.Drawing.Size(100, 20);
            this.date_ReturnedTextBox.TabIndex = 14;
            // 
            // owner_First_NameTextBox
            // 
            this.owner_First_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Owner First Name", true));
            this.owner_First_NameTextBox.Location = new System.Drawing.Point(113, 368);
            this.owner_First_NameTextBox.Name = "owner_First_NameTextBox";
            this.owner_First_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.owner_First_NameTextBox.TabIndex = 16;
            // 
            // owner_Last_NameTextBox
            // 
            this.owner_Last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Owner Last Name", true));
            this.owner_Last_NameTextBox.Location = new System.Drawing.Point(113, 404);
            this.owner_Last_NameTextBox.Name = "owner_Last_NameTextBox";
            this.owner_Last_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.owner_Last_NameTextBox.TabIndex = 18;
            // 
            // invoicesTextBox
            // 
            this.invoicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Invoices", true));
            this.invoicesTextBox.Location = new System.Drawing.Point(496, 368);
            this.invoicesTextBox.Name = "invoicesTextBox";
            this.invoicesTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoicesTextBox.TabIndex = 20;
            // 
            // parts_AvailableTextBox
            // 
            this.parts_AvailableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Parts Available", true));
            this.parts_AvailableTextBox.Location = new System.Drawing.Point(320, 368);
            this.parts_AvailableTextBox.Name = "parts_AvailableTextBox";
            this.parts_AvailableTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_AvailableTextBox.TabIndex = 22;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleTableBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(426, 278);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(100, 20);
            this.notesTextBox.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(417, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 185);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ownerVehicleBtn
            // 
            this.ownerVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerVehicleBtn.Location = new System.Drawing.Point(83, 430);
            this.ownerVehicleBtn.Name = "ownerVehicleBtn";
            this.ownerVehicleBtn.Size = new System.Drawing.Size(91, 35);
            this.ownerVehicleBtn.TabIndex = 26;
            this.ownerVehicleBtn.Text = "Owner";
            this.ownerVehicleBtn.UseVisualStyleBackColor = true;
            this.ownerVehicleBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // partsVehicleBtn
            // 
            this.partsVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsVehicleBtn.Location = new System.Drawing.Point(292, 430);
            this.partsVehicleBtn.Name = "partsVehicleBtn";
            this.partsVehicleBtn.Size = new System.Drawing.Size(84, 35);
            this.partsVehicleBtn.TabIndex = 27;
            this.partsVehicleBtn.Text = "Parts";
            this.partsVehicleBtn.UseVisualStyleBackColor = true;
            this.partsVehicleBtn.Click += new System.EventHandler(this.partsVehicleBtn_Click);
            // 
            // invoicesVehicleBtn
            // 
            this.invoicesVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicesVehicleBtn.Location = new System.Drawing.Point(484, 430);
            this.invoicesVehicleBtn.Name = "invoicesVehicleBtn";
            this.invoicesVehicleBtn.Size = new System.Drawing.Size(85, 35);
            this.invoicesVehicleBtn.TabIndex = 28;
            this.invoicesVehicleBtn.Text = "Invoices";
            this.invoicesVehicleBtn.UseVisualStyleBackColor = true;
            this.invoicesVehicleBtn.Click += new System.EventHandler(this.invoicesVehicleBtn_Click);
            // 
            // vehicleExitBtn
            // 
            this.vehicleExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleExitBtn.Location = new System.Drawing.Point(611, 455);
            this.vehicleExitBtn.Name = "vehicleExitBtn";
            this.vehicleExitBtn.Size = new System.Drawing.Size(75, 33);
            this.vehicleExitBtn.TabIndex = 29;
            this.vehicleExitBtn.Text = "Exit";
            this.vehicleExitBtn.UseVisualStyleBackColor = true;
            this.vehicleExitBtn.Click += new System.EventHandler(this.vehicleExitBtn_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 500);
            this.Controls.Add(this.vehicleExitBtn);
            this.Controls.Add(this.invoicesVehicleBtn);
            this.Controls.Add(this.partsVehicleBtn);
            this.Controls.Add(this.ownerVehicleBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(vehicle_IDLabel);
            this.Controls.Add(this.vehicle_IDTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(mileageLabel);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(date_ReceivedLabel);
            this.Controls.Add(this.date_ReceivedTextBox);
            this.Controls.Add(date_ReturnedLabel);
            this.Controls.Add(this.date_ReturnedTextBox);
            this.Controls.Add(owner_First_NameLabel);
            this.Controls.Add(this.owner_First_NameTextBox);
            this.Controls.Add(owner_Last_NameLabel);
            this.Controls.Add(this.owner_Last_NameTextBox);
            this.Controls.Add(invoicesLabel);
            this.Controls.Add(this.invoicesTextBox);
            this.Controls.Add(parts_AvailableLabel);
            this.Controls.Add(this.parts_AvailableTextBox);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.vehicleTableBindingNavigator);
            this.Name = "VehicleForm";
            this.Text = "VehicleForm";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingNavigator)).EndInit();
            this.vehicleTableBindingNavigator.ResumeLayout(false);
            this.vehicleTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource vehicleTableBindingSource;
        private CRMDataSetTableAdapters.VehicleTableTableAdapter vehicleTableTableAdapter;
        private CRMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehicleTableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vehicleTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehicle_IDTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox date_ReceivedTextBox;
        private System.Windows.Forms.TextBox date_ReturnedTextBox;
        private System.Windows.Forms.TextBox owner_First_NameTextBox;
        private System.Windows.Forms.TextBox owner_Last_NameTextBox;
        private System.Windows.Forms.TextBox invoicesTextBox;
        private System.Windows.Forms.TextBox parts_AvailableTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ownerVehicleBtn;
        private System.Windows.Forms.Button partsVehicleBtn;
        private System.Windows.Forms.Button invoicesVehicleBtn;
        private System.Windows.Forms.Button vehicleExitBtn;
    }
}