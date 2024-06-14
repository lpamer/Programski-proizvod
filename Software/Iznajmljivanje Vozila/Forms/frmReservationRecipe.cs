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
    public partial class frmReservationRecipe : MaterialForm
    {
        private ReservationService services = new ReservationService();

        Reservation reservation;
        public frmReservationRecipe(Reservation selectedReservation)
        {
            reservation = selectedReservation;
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void frmReservationRecipe_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
