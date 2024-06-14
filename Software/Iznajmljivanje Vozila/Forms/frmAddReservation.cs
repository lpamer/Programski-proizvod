using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmAddReservation : MaterialForm
    {
        private FrmReservation frmReservation;
        public FrmAddReservation(FrmReservation frmReservation)
        {
            InitializeComponent();
            this.frmReservation = frmReservation;
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void FrmAddReservation_Load(object sender, EventArgs e)
        {
            LoadVehicleList();

            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            
        }

        private void LoadVehicleList()
        {
            var vehicleService = new VehicleService();
            var vehicles = vehicleService.GetVehicles();

            Debug.WriteLine(vehicles.ToString());

            var displayItems = vehicles.Select(v => new
            {
                Id = v.id,
                DisplayText = $"{v.mark} {v.model}"
            }).ToList();

            cboVehicle.DisplayMember = "DisplayText";
            cboVehicle.ValueMember = "Id";

            
            cboVehicle.DataSource = displayItems;
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedVehicle = cboVehicle.SelectedItem as dynamic;

            var customerId = txtCustomerId.Text;
            var vehicleId = selectedVehicle.Id;
            var pickupDate = txtPickupDate.Text;
            var returnDate = txtReturnDate.Text;
            var pickupLocation = txtPickupLocation.Text;
            var returnLocation = txtReturnLocation.Text;

            string[] data = { 
                customerId,
                vehicleId.ToString(),
                pickupDate,
                returnDate,
                pickupDate,
                pickupLocation,
                returnLocation };

            foreach( var item in data )
            {
                if(item == string.Empty)
                {
                    MessageBox.Show("Unesite sve podatke!");
                    return;
                }
            }


            Reservation newReservation = new Reservation
            {
                customerID = int.Parse(customerId),
                vehicleID = vehicleId,
                pickupDate = DateTime.Parse(pickupDate),
                returnDate = DateTime.Parse(returnDate),
                pickupLocation = pickupLocation,
                returnLocation = returnLocation,
                creationDate = DateTime.Now
            };

            var reservationService = new ReservationService();
            reservationService.AddReservation(newReservation);
            MessageBox.Show("Dodavanje rezervacije uspješno.");
            ClearForm();


            this.frmReservation.LoadReservations();



        }

        private void ClearForm()
        {
            txtCustomerId.Text = string.Empty;
            txtPickupDate.Text = string.Empty;
            txtReturnDate.Text = string.Empty;
            txtPickupLocation.Text = string.Empty;
            txtReturnLocation.Text = string.Empty;
        }
    }
}
