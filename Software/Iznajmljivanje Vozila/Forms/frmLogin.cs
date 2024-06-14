using AForge.Video.DirectShow;
using AForge.Video;
using BusinessLogicLayer.Services;
using Iznajmljivanje_Vozila.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Iznajmljivanje_Vozila
{
    public partial class FrmLogin : MaterialForm
    {
        private VideoCaptureDevice videoSource;
        public FrmLogin()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        private void InitializeWebcam()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            System.Drawing.Image frame = (System.Drawing.Image)eventArgs.Frame.Clone();

            ResizeImageToFitPictureBox(frame, pbImage);

            pbImage.Image = frame;
        }

        private void ResizeImageToFitPictureBox(System.Drawing.Image image, PictureBox pictureBox)
        {
            if (image != null)
            {
                double aspectRatio = (double)image.Width / image.Height;

                int newWidth = pictureBox.Width;
                int newHeight = (int)(newWidth / aspectRatio);

                if (newHeight > pictureBox.Height)
                {
                    newHeight = pictureBox.Height;
                    newWidth = (int)(newHeight * aspectRatio);
                }

                pictureBox.Image = new Bitmap(image, newWidth, newHeight);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "Prijava")
            {
                PerformLoginUsernamePassword();
            }else if(btnLogin.Text == "Prijava s FR")
            {
                PerformLoginFaceRecognition();
            }
            
        }

        private void PerformLoginUsernamePassword()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var loginService = new LoginService();

            var login = loginService.LoginUsernamePassword(username, password);

            if (login)
            {
                //MessageBox.Show("Uspješna prijava");
                this.Hide();
                FrmVehicleStatus frmVehicleStatus = new FrmVehicleStatus();
                frmVehicleStatus.Closed += (s, args) => this.Close(); 
                frmVehicleStatus.Show();
                
            }
            else
            {
                MessageBox.Show("Neuspješna prijava");
            }
        }

        private void btnTurnOnCamera_Click(object sender, EventArgs e)
        {
            if (videoSource == null || !videoSource.IsRunning)
            {
                InitializeWebcam();
                btnTurnOnCamera.Text = "Isključi kameru:";
                btnLogin.Text = "Prijava s FR";
            }
            else
            {
                
                videoSource.Stop();
                pbImage.Image = null;
                btnTurnOnCamera.Text = "Uključi kameru:";
                btnLogin.Text = "Prijava";
            }
            
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();

                pbImage.Image = (System.Drawing.Image)pbImage.Image.Clone();

                videoSource.Stop();
            }
        }

        private void PerformLoginFaceRecognition()
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var image = pbImage.Image;
            byte[] imageBytes;

            if(image != null)
            {
                imageBytes = ImageToByteArray(image);
            }
            else
            {
                MessageBox.Show("Slika ne postoji!");
                return;
            }

            if(username != string.Empty)
            {
                var employeeService = new EmployeeService();
                var employee = employeeService.GetEmployee(username);

                if(employee != null)
                {
                    var loginService = new LoginService();

                    if (employee.image == null) {
                        DialogResult result = MessageBox.Show("Želite li dodati sliku u bazu?", "Odabir:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if(password == string.Empty)
                            {
                                MessageBox.Show("Unesite lozinku i probajte ponovno.");
                                return;
                            }
                            else
                            {
                                
                                var addedToDatabase = loginService.AddImageToDatabase(username, password, imageBytes);

                                if (addedToDatabase)
                                {
                                    MessageBox.Show("Slika uspješno dodana u bazu. Probajte se prijaviti.");
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Slika neuspješno dodana u bazu. Pokušajte ponovno kasnije.");
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        var login = loginService.LoginFaceRecognition(username, imageBytes);
                        if (login)
                        {
                            this.Hide();
                            frmVehicleStatus frmVehicleStatus = new frmVehicleStatus();
                            frmVehicleStatus.Closed += (s, args) => this.Close();
                            frmVehicleStatus.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nespješna prijava");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Unesite korisničko ime.");
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
