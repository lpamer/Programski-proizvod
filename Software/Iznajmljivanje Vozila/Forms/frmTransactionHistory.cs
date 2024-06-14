using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Org.BouncyCastle.Ocsp;
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
    public partial class frmTransactionHistory : MaterialForm
    {
        private ReservationService services = new ReservationService();
        public frmTransactionHistory()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            FillCmbSortByData();
            ShowAllReservations();
        }

        private void ShowAllReservations()
        {
            var allReservations = services.GetReservations();
            FillDataGridViewData(allReservations);
        }

        private void FillDataGridViewData(List<Reservation> reservation)
        {
            dgvTransactionHistory.DataSource = reservation;

            dgvTransactionHistory.Columns["id"].Visible = false;
            dgvTransactionHistory.Columns["customerId"].Visible = false;
            dgvTransactionHistory.Columns["vehicleId"].Visible = false;
            dgvTransactionHistory.Columns["pickupDate"].Visible = false;
            dgvTransactionHistory.Columns["returnDate"].Visible = false;
            dgvTransactionHistory.Columns["pickupLocation"].Visible = false;
            dgvTransactionHistory.Columns["returnLocation"].Visible = false;

            dgvTransactionHistory.Columns["totalCost"].HeaderText = "Ukupna cijena";
            dgvTransactionHistory.Columns["creationDate"].HeaderText = "Datum kreiranja";
            dgvTransactionHistory.Columns["status"].HeaderText = "Status";
            dgvTransactionHistory.Columns["Customer"].HeaderText = "Korisnik";
            dgvTransactionHistory.Columns["Vehicle"].HeaderText = "Vozilo";
        }

        private void FillCmbSortByData()
        {
            cmbSortBy.Items.Add("Korisniku");
            cmbSortBy.Items.Add("Vozilu");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cmbSortBy.Text == "Korisniku") {
                SortByCustomer();
            } else {
                SortByVehicle();
            }
        }

        private void SortByVehicle()
        {
            try
            {
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var sortedCustomers = services.GetReservationByVehicle(reservation.Vehicle.id);
                FillDataGridViewData(sortedCustomers);
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void SortByCustomer()
        {
            try { 
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var sortedCustomers = services.GetReservationByVehicle(reservation.Customer.id);
                FillDataGridViewData(sortedCustomers);
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowAllReservations();
        }

        private void btnCreateReceipe_Click(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = dgvTransactionHistory.CurrentRow.DataBoundItem as Reservation;
                var form = new frmReservationRecipe(reservation);
                form.ShowDialog();
            } catch
            {
                MessageBox.Show("Odaberite red");
            }
        }
    }
}
