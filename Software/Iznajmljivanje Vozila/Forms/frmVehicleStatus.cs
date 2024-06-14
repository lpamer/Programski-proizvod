using BusinessLogicLayer;
using EntitiesLayer.Entities;
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

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmVehicleStatus : MaterialForm
    {
        private int vehicleId;
        public FrmVehicleStatus()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void FrmVehicleStatus_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            LoadVehicles();
            LoadFilterTypes();
        }

        private void LoadVehicles()
        {
            var vehicleService = new VehicleService();

            List<Vehicle> vehicles = vehicleService.GetVehicles();

            dgvVehicles.DataSource = vehicles;
            dgvVehicles.Columns["Reservations"].Visible = false;
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            LoadVehicleHistory();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadVehicleHistory();
            txtFilter.Text = string.Empty;
        }

        private void LoadVehicleHistory()
        {
            var selectedCell = dgvVehicles.SelectedCells[0];

            if (selectedCell != null)
            {
                Vehicle selectedVehicle = (Vehicle)dgvVehicles.Rows[selectedCell.RowIndex].DataBoundItem;


                var reservationService = new ReservationService();
                var reservations = reservationService.GetReservationByVehicle(selectedVehicle.id);

                dgvReservationHistory.DataSource = reservations;
                dgvReservationHistory.Columns["Customer"].Visible = false;
                dgvReservationHistory.Columns["Vehicle"].Visible = false;
                this.vehicleId = reservations[0].id;

            }
            else
            {
                dgvReservationHistory.DataSource = new Reservation();
                this.vehicleId = -1;
            }
        }

        private void LoadFilterTypes()
        {
            var filterTypes = new List<object>
            {
                new { DisplayText = "ID korisnika", Value = "customerId" },
                new { DisplayText = "Datum preuzimanja", Value = "pickupDate" },
                new { DisplayText = "Datum vraćanja", Value = "returnDate" },
                new { DisplayText = "Lokacija preuzimanja", Value = "pickupLocation" },
                new { DisplayText = "Lokacija vraćanja", Value = "returnLocation" },
                new { DisplayText = "Ukupan iznos do", Value = "totalCost" },
                new { DisplayText = "Datum kreiranja", Value = "creationDate" },
                new { DisplayText = "Status", Value = "status" },
            };

            cboFilterType.DisplayMember = "DisplayText";
            cboFilterType.ValueMember = "Value";

            cboFilterType.DataSource = filterTypes;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            var selectedFilterType = cboFilterType.SelectedItem as dynamic;
            var selectedFilterTypeValue = selectedFilterType.Value;
            var filterValue = txtFilter.Text;
            
            var reservationService = new ReservationService();

            var filteredReservations = reservationService.GetFilteredReservations(selectedFilterTypeValue, filterValue, this.vehicleId );

            dgvReservationHistory.DataSource = filteredReservations;
            dgvReservationHistory.Columns["Customer"].Visible = false;
            dgvReservationHistory.Columns["Vehicle"].Visible = false;

        }
    }
}
