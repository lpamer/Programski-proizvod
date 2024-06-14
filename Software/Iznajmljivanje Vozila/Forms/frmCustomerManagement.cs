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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class frmCustomerManagement : MaterialForm
    {
        private CustomerServices services = new CustomerServices();

        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        MaterialSkinManager TManager = MaterialSkinManager.Instance;

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;
            ShowAllCustomers();

            cmbGetData.Enabled = false;
        }

        private void ShowAllCustomers()
        {
            var allCustomers = services.GetCustomers();
            EditDataGridView(allCustomers);
        }


        private void EditDataGridView(List<Customer> customers)
        {
            dgvCustomers.DataSource = customers;

            dgvCustomers.Columns["id"].Visible = false;
            dgvCustomers.Columns["Reservations"].Visible = false;
            dgvCustomers.Columns["Supports"].Visible = false;

            dgvCustomers.Columns["firstName"].HeaderText = "Ime";
            dgvCustomers.Columns["lastName"].HeaderText = "Prezime";
            dgvCustomers.Columns["phone"].HeaderText = "Mobitel";
            dgvCustomers.Columns["email"].HeaderText = "Email";
            dgvCustomers.Columns["adress"].HeaderText = "Adresa";
            dgvCustomers.Columns["blocked"].HeaderText = "Blokiran";
            dgvCustomers.Columns["blocked"].ReadOnly = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var form = new fmrAddNewCustomer();
            form.ShowDialog();

            ShowAllCustomers();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = dgvCustomers.CurrentRow.DataBoundItem as Customer;

            var services = new CustomerServices();
            services.RemoveCustomer(customer);

            ShowAllCustomers();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Customer customer = dgvCustomers.CurrentRow.DataBoundItem as Customer;

            var services = new CustomerServices();
            services.BlockCustomer(customer);

            ShowAllCustomers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowAllCustomers();
        }

        private void btnSortBy_Click(object sender, EventArgs e)
        {
            if (cmbSortBy.Text == "Prezimenu")
            {
                SortByLastName();
            } else
            {
                SortByBlocked();
            }

        }

        private void SortByBlocked()
        {
            bool blocked;
            if(cmbGetData.Text == "Blokiran")
            {
                blocked = true;
            } else
            {
                blocked = false;
            }
            var sortedCustomers = services.GetBlocked(blocked);
            EditDataGridView(sortedCustomers);
        }

        private void SortByLastName()
        {
            var lastName = cmbGetData.Text;
            var sortedCustomers = services.GetCustomersByLastName(lastName);
            EditDataGridView(sortedCustomers);
        }

        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGetData.Enabled = true;
            if (cmbSortBy.Text == "Prezimenu")
            {
                cmbGetData.DropDownStyle = ComboBoxStyle.Simple;
                cmbGetData.Items.Clear();
                cmbGetData.Text = "";
            } else
            {
                cmbGetData.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbGetData.Items.Clear();
                cmbGetData.Items.Add("Blokiran");
                cmbGetData.Items.Add("Ne blokiran");
            }
        }
    }
}
