namespace Iznajmljivanje_Vozila.Forms
{
    partial class frmTransactionHistory
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
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.btnCreateReceipe = new MaterialSkin.Controls.MaterialButton();
            this.btnCreateReport = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnSort = new MaterialSkin.Controls.MaterialButton();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionHistory.Location = new System.Drawing.Point(30, 130);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.Size = new System.Drawing.Size(740, 260);
            this.dgvTransactionHistory.TabIndex = 0;
            // 
            // btnCreateReceipe
            // 
            this.btnCreateReceipe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReceipe.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateReceipe.Depth = 0;
            this.btnCreateReceipe.HighEmphasis = true;
            this.btnCreateReceipe.Icon = null;
            this.btnCreateReceipe.Location = new System.Drawing.Point(638, 399);
            this.btnCreateReceipe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateReceipe.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateReceipe.Name = "btnCreateReceipe";
            this.btnCreateReceipe.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateReceipe.Size = new System.Drawing.Size(132, 36);
            this.btnCreateReceipe.TabIndex = 1;
            this.btnCreateReceipe.Text = "Kreiraj račun";
            this.btnCreateReceipe.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateReceipe.UseAccentColor = false;
            this.btnCreateReceipe.UseVisualStyleBackColor = true;
            this.btnCreateReceipe.Click += new System.EventHandler(this.btnCreateReceipe_Click);
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCreateReport.Depth = 0;
            this.btnCreateReport.HighEmphasis = true;
            this.btnCreateReport.Icon = null;
            this.btnCreateReport.Location = new System.Drawing.Point(472, 399);
            this.btnCreateReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCreateReport.Size = new System.Drawing.Size(158, 36);
            this.btnCreateReport.TabIndex = 2;
            this.btnCreateReport.Text = "Kreiraj izvještaj";
            this.btnCreateReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCreateReport.UseAccentColor = false;
            this.btnCreateReport.UseVisualStyleBackColor = true;
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
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Osvježi prikaz";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSort
            // 
            this.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSort.Depth = 0;
            this.btnSort.HighEmphasis = true;
            this.btnSort.Icon = null;
            this.btnSort.Location = new System.Drawing.Point(680, 85);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSort.Name = "btnSort";
            this.btnSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSort.Size = new System.Drawing.Size(90, 36);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSort.UseAccentColor = false;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(552, 94);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbSortBy.TabIndex = 5;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Depth = 0;
            this.lblSortBy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSortBy.Location = new System.Drawing.Point(441, 95);
            this.lblSortBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(105, 19);
            this.lblSortBy.TabIndex = 6;
            this.lblSortBy.Text = "Soritraj prema:";
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreateReport);
            this.Controls.Add(this.btnCreateReceipe);
            this.Controls.Add(this.dgvTransactionHistory);
            this.Name = "frmTransactionHistory";
            this.Text = "Povijest transakcija";
            this.Load += new System.EventHandler(this.frmTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private MaterialSkin.Controls.MaterialButton btnCreateReceipe;
        private MaterialSkin.Controls.MaterialButton btnCreateReport;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnSort;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private MaterialSkin.Controls.MaterialLabel lblSortBy;
    }
}