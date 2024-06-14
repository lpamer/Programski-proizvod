using BusinessLogicLayer;
using EntitiesLayer.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class fmrAddNewCustomer : MaterialForm
    {
        private CustomerServices services = new CustomerServices();
        public fmrAddNewCustomer()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void fmrAddNewCustomer_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                email = txtEmail.Text,
                phone = txtPhone.Text,
                adress = txtAdress.Text
            };

            var services = new CustomerServices();
            services.AddCustomer(customer);
            Close();
        }
    }
}
