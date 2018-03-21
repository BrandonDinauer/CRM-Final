namespace CRM_Final
{
    partial class VehicleSearchForm
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
            this.vehicleTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cRMDataSet = new CRM_Final.CRMDataSet();
            this.vehicleSearchBtn = new System.Windows.Forms.Button();
            this.vehicleSearchTxtBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new CRM_Final.CRMDataSetTableAdapters.TableAdapterManager();
            this.vehicleTableTableAdapter = new CRM_Final.CRMDataSetTableAdapters.VehicleTableTableAdapter();
            this.vehicleAddBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleTableDataGridView
            // 
            this.vehicleTableDataGridView.AutoGenerateColumns = false;
            this.vehicleTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.vehicleTableDataGridView.DataSource = this.vehicleTableBindingSource;
            this.vehicleTableDataGridView.Location = new System.Drawing.Point(-3, -1);
            this.vehicleTableDataGridView.Name = "vehicleTableDataGridView";
            this.vehicleTableDataGridView.Size = new System.Drawing.Size(661, 295);
            this.vehicleTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vehicle ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicle ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn2.HeaderText = "Make";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mileage";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date Received";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date Received";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date Returned";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date Returned";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Owner First Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Owner First Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Owner Last Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Owner Last Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Invoices";
            this.dataGridViewTextBoxColumn10.HeaderText = "Invoices";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Parts Available";
            this.dataGridViewTextBoxColumn11.HeaderText = "Parts Available";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn12.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // vehicleTableBindingSource
            // 
            this.vehicleTableBindingSource.DataMember = "VehicleTable";
            this.vehicleTableBindingSource.DataSource = this.cRMDataSet;
            // 
            // cRMDataSet
            // 
            this.cRMDataSet.DataSetName = "CRMDataSet";
            this.cRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleSearchBtn
            // 
            this.vehicleSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSearchBtn.Location = new System.Drawing.Point(236, 354);
            this.vehicleSearchBtn.Name = "vehicleSearchBtn";
            this.vehicleSearchBtn.Size = new System.Drawing.Size(80, 36);
            this.vehicleSearchBtn.TabIndex = 1;
            this.vehicleSearchBtn.Text = "Search";
            this.vehicleSearchBtn.UseVisualStyleBackColor = true;
            this.vehicleSearchBtn.Click += new System.EventHandler(this.vehicleSearchBtn_Click);
            // 
            // vehicleSearchTxtBox
            // 
            this.vehicleSearchTxtBox.Location = new System.Drawing.Point(255, 328);
            this.vehicleSearchTxtBox.Name = "vehicleSearchTxtBox";
            this.vehicleSearchTxtBox.Size = new System.Drawing.Size(130, 20);
            this.vehicleSearchTxtBox.TabIndex = 2;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableTableAdapter = null;
            this.tableAdapterManager.InvoicesTableTableAdapter = null;
            this.tableAdapterManager.PartsTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRM_Final.CRMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableTableAdapter = null;
            // 
            // vehicleTableTableAdapter
            // 
            this.vehicleTableTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleAddBtn
            // 
            this.vehicleAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleAddBtn.Location = new System.Drawing.Point(322, 354);
            this.vehicleAddBtn.Name = "vehicleAddBtn";
            this.vehicleAddBtn.Size = new System.Drawing.Size(80, 36);
            this.vehicleAddBtn.TabIndex = 3;
            this.vehicleAddBtn.Text = "Add";
            this.vehicleAddBtn.UseVisualStyleBackColor = true;
            this.vehicleAddBtn.Click += new System.EventHandler(this.vehicleAddBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(562, 358);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(81, 32);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By Owner Last Name";
            // 
            // VehicleSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.vehicleAddBtn);
            this.Controls.Add(this.vehicleSearchTxtBox);
            this.Controls.Add(this.vehicleSearchBtn);
            this.Controls.Add(this.vehicleTableDataGridView);
            this.Name = "VehicleSearchForm";
            this.Text = "VehicleSearchForm";
            this.Load += new System.EventHandler(this.VehicleSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CRMDataSet cRMDataSet;
        private System.Windows.Forms.BindingSource vehicleTableBindingSource;
        private CRMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CRMDataSetTableAdapters.VehicleTableTableAdapter vehicleTableTableAdapter;
        private System.Windows.Forms.DataGridView vehicleTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button vehicleSearchBtn;
        private System.Windows.Forms.TextBox vehicleSearchTxtBox;
        private System.Windows.Forms.Button vehicleAddBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
    }
}