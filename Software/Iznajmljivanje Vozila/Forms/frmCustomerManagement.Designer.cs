namespace Iznajmljivanje_Vozila.Forms
{
    partial class frmCustomerManagement
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btnBlock = new MaterialSkin.Controls.MaterialButton();
            this.btnSortBy = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.cmbGetData = new System.Windows.Forms.ComboBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(30, 130);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(740, 260);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddCustomer.Depth = 0;
            this.btnAddCustomer.HighEmphasis = true;
            this.btnAddCustomer.Icon = null;
            this.btnAddCustomer.Location = new System.Drawing.Point(569, 399);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddCustomer.Size = new System.Drawing.Size(202, 36);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Dodaj novog korisnika";
            this.btnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddCustomer.UseAccentColor = false;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveCustomer.Depth = 0;
            this.btnRemoveCustomer.HighEmphasis = true;
            this.btnRemoveCustomer.Icon = null;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(409, 399);
            this.btnRemoveCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveCustomer.Size = new System.Drawing.Size(152, 36);
            this.btnRemoveCustomer.TabIndex = 2;
            this.btnRemoveCustomer.Text = "Ukloni korisnika";
            this.btnRemoveCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveCustomer.UseAccentColor = false;
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBlock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBlock.Depth = 0;
            this.btnBlock.HighEmphasis = true;
            this.btnBlock.Icon = null;
            this.btnBlock.Location = new System.Drawing.Point(233, 399);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBlock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBlock.Size = new System.Drawing.Size(168, 36);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Blokiraj korisnika";
            this.btnBlock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBlock.UseAccentColor = false;
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnSortBy
            // 
            this.btnSortBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSortBy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSortBy.Depth = 0;
            this.btnSortBy.HighEmphasis = true;
            this.btnSortBy.Icon = null;
            this.btnSortBy.Location = new System.Drawing.Point(678, 85);
            this.btnSortBy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSortBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSortBy.Name = "btnSortBy";
            this.btnSortBy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSortBy.Size = new System.Drawing.Size(90, 36);
            this.btnSortBy.TabIndex = 4;
            this.btnSortBy.Text = "Sortiraj";
            this.btnSortBy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSortBy.UseAccentColor = false;
            this.btnSortBy.UseVisualStyleBackColor = true;
            this.btnSortBy.Click += new System.EventHandler(this.btnSortBy_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(30, 85);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(134, 36);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Osvježi prikaz";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbGetData
            // 
            this.cmbGetData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbGetData.DropDownWidth = 121;
            this.cmbGetData.FormattingEnabled = true;
            this.cmbGetData.IntegralHeight = false;
            this.cmbGetData.Location = new System.Drawing.Point(541, 94);
            this.cmbGetData.Name = "cmbGetData";
            this.cmbGetData.Size = new System.Drawing.Size(130, 21);
            this.cmbGetData.TabIndex = 6;
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Prezimenu",
            "Blokiranosti"});
            this.cmbSortBy.Location = new System.Drawing.Point(414, 94);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbSortBy.TabIndex = 7;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Depth = 0;
            this.lblSortBy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSortBy.Location = new System.Drawing.Point(303, 95);
            this.lblSortBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(105, 19);
            this.lblSortBy.TabIndex = 8;
            this.lblSortBy.Text = "Sortiraj prema:";
            // 
            // frmCustomerManagement
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.cmbGetData);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSortBy);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "frmCustomerManagement";
            this.Text = "Upravljanje korisnicima";
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private MaterialSkin.Controls.MaterialButton btnAddCustomer;
        private MaterialSkin.Controls.MaterialButton btnRemoveCustomer;
        private MaterialSkin.Controls.MaterialButton btnBlock;
        private MaterialSkin.Controls.MaterialButton btnSortBy;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private System.Windows.Forms.ComboBox cmbGetData;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private MaterialSkin.Controls.MaterialLabel lblSortBy;
    }
}