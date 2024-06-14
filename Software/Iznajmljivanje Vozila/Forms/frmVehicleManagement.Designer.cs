namespace Iznajmljivanje_Vozila.Forms
{
    partial class frmVehicleManagement
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
            this.rPP2324_T13_DBDataSet = new Iznajmljivanje_Vozila.RPP2324_T13_DBDataSet();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new Iznajmljivanje_Vozila.RPP2324_T13_DBDataSetTableAdapters.VehicleTableAdapter();
            this.tableAdapterManager = new Iznajmljivanje_Vozila.RPP2324_T13_DBDataSetTableAdapters.TableAdapterManager();
            this.btnNewVehicle = new MaterialSkin.Controls.MaterialButton();
            this.dgvVehicleList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnPdf = new MaterialSkin.Controls.MaterialButton();
            this.fKReservationVehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new Iznajmljivanje_Vozila.RPP2324_T13_DBDataSetTableAdapters.ReservationTableAdapter();
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rPP2324_T13_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservationVehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rPP2324_T13_DBDataSet
            // 
            this.rPP2324_T13_DBDataSet.DataSetName = "RPP2324_T13_DBDataSet";
            this.rPP2324_T13_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.rPP2324_T13_DBDataSet;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ReservationTableAdapter = null;
            this.tableAdapterManager.SupportTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Iznajmljivanje_Vozila.RPP2324_T13_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // btnNewVehicle
            // 
            this.btnNewVehicle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewVehicle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewVehicle.Depth = 0;
            this.btnNewVehicle.HighEmphasis = true;
            this.btnNewVehicle.Icon = null;
            this.btnNewVehicle.Location = new System.Drawing.Point(448, 410);
            this.btnNewVehicle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewVehicle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewVehicle.Name = "btnNewVehicle";
            this.btnNewVehicle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewVehicle.Size = new System.Drawing.Size(123, 36);
            this.btnNewVehicle.TabIndex = 2;
            this.btnNewVehicle.Text = "Dodaj vozilo";
            this.btnNewVehicle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewVehicle.UseAccentColor = false;
            this.btnNewVehicle.UseVisualStyleBackColor = true;
            this.btnNewVehicle.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dgvVehicleList
            // 
            this.dgvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleList.Location = new System.Drawing.Point(30, 89);
            this.dgvVehicleList.Name = "dgvVehicleList";
            this.dgvVehicleList.Size = new System.Drawing.Size(743, 293);
            this.dgvVehicleList.TabIndex = 3;
            this.dgvVehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(579, 410);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(122, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Obriši vozilo";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPdf.Depth = 0;
            this.btnPdf.HighEmphasis = true;
            this.btnPdf.Icon = null;
            this.btnPdf.Location = new System.Drawing.Point(709, 410);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPdf.Size = new System.Drawing.Size(64, 36);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "PDF";
            this.btnPdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPdf.UseAccentColor = false;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // fKReservationVehicleBindingSource
            // 
            this.fKReservationVehicleBindingSource.DataMember = "FK_Reservation_Vehicle";
            this.fKReservationVehicleBindingSource.DataSource = this.vehicleBindingSource;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataMember = "Vehicle";
            this.vehicleBindingSource1.DataSource = this.rPP2324_T13_DBDataSet;
            // 
            // frmVehicleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 471);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvVehicleList);
            this.Controls.Add(this.btnNewVehicle);
            this.Name = "frmVehicleManagement";
            this.Text = "Upravljanje flotom vozila";
            this.Load += new System.EventHandler(this.frmVehicleManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPP2324_T13_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKReservationVehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RPP2324_T13_DBDataSet rPP2324_T13_DBDataSet;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private RPP2324_T13_DBDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private RPP2324_T13_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MaterialSkin.Controls.MaterialButton btnNewVehicle;
        private System.Windows.Forms.DataGridView dgvVehicleList;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnPdf;
        private System.Windows.Forms.BindingSource fKReservationVehicleBindingSource;
        private RPP2324_T13_DBDataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
    }
}