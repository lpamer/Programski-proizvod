using System.Drawing;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila
{
    partial class FrmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnClear = new MaterialSkin.Controls.MaterialButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnTurnOnCamera = new MaterialSkin.Controls.MaterialButton();
            this.btnTakePicture = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(30, 110);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(40, 244);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(81, 36);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClear.Depth = 0;
            this.btnClear.HighEmphasis = true;
            this.btnClear.Icon = null;
            this.btnClear.Location = new System.Drawing.Point(40, 297);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClear.Size = new System.Drawing.Size(67, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Obriši";
            this.btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClear.UseAccentColor = false;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(179, 92);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(180, 117);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btnTurnOnCamera
            // 
            this.btnTurnOnCamera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTurnOnCamera.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTurnOnCamera.Depth = 0;
            this.btnTurnOnCamera.HighEmphasis = true;
            this.btnTurnOnCamera.Icon = null;
            this.btnTurnOnCamera.Location = new System.Drawing.Point(194, 244);
            this.btnTurnOnCamera.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTurnOnCamera.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTurnOnCamera.Name = "btnTurnOnCamera";
            this.btnTurnOnCamera.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTurnOnCamera.Size = new System.Drawing.Size(146, 36);
            this.btnTurnOnCamera.TabIndex = 5;
            this.btnTurnOnCamera.Text = "Uključi kameru:";
            this.btnTurnOnCamera.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTurnOnCamera.UseAccentColor = false;
            this.btnTurnOnCamera.UseVisualStyleBackColor = true;
            this.btnTurnOnCamera.Click += new System.EventHandler(this.btnTurnOnCamera_Click);
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTakePicture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTakePicture.Depth = 0;
            this.btnTakePicture.HighEmphasis = true;
            this.btnTakePicture.Icon = null;
            this.btnTakePicture.Location = new System.Drawing.Point(223, 297);
            this.btnTakePicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTakePicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTakePicture.Size = new System.Drawing.Size(89, 36);
            this.btnTakePicture.TabIndex = 6;
            this.btnTakePicture.Text = "Poslikaj";
            this.btnTakePicture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTakePicture.UseAccentColor = false;
            this.btnTakePicture.UseVisualStyleBackColor = true;
            this.btnTakePicture.Click += new System.EventHandler(this.btnTakePicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lozinka:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakePicture);
            this.Controls.Add(this.btnTurnOnCamera);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private PictureBox pbImage;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnTurnOnCamera;
        private MaterialSkin.Controls.MaterialButton btnTakePicture;
    }
}

