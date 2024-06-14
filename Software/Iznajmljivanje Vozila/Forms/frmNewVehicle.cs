using BusinessLogicLayer;
using EntitiesLayer.Entities;
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
    public partial class frmNewVehicle : MaterialForm
    {
        public frmNewVehicle()
        {
            InitializeComponent();
        }

        private void frmNewVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveNewVehicle_Click(object sender, EventArgs e)
        {
            var vehicle = new Vehicle()
            {
                //id = int.Parse(txtId.Text),
                model = txtModel.Text,
                mark = txtMark.Text,
                year = int.Parse(txtYear.Text),
                registrationPlate = txtRegistrationPlate.Text,
                currentMileage = int.Parse(txtMileage.Text),
            };

            if (vehicle.model != "")
            {
                var prodServices = new VehicleService();
                prodServices.AddVehicle(vehicle);
                Close();
            }
            else
            {
                MessageBox.Show("Nije dobar unos!");
            }
        }
    }
}
