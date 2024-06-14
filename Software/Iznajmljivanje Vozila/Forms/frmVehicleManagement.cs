using BusinessLogicLayer;
using EntitiesLayer.Entities;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class frmVehicleManagement : MaterialForm
    {

        private VehicleService services = new VehicleService();

        public frmVehicleManagement()
        {
            InitializeComponent();
        }
        MaterialSkinManager TManager = MaterialSkinManager.Instance;
        private void frmVehicleManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rPP2324_T13_DBDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.rPP2324_T13_DBDataSet.Reservation);
            if (Properties.Settings.Default.Theme == true)
                TManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                TManager.Theme = MaterialSkinManager.Themes.DARK;

            DataGridView dataGridView = new DataGridView();

            ShowAllVehicles();


        }

        private void ShowAllVehicles()
        {
            var allVehicles = services.GetVehicles();
            dgvVehicleList.DataSource = allVehicles;
            string columnNameToRemove = "Reservations";
            dgvVehicleList.Columns.Remove(columnNameToRemove);
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rPP2324_T13_DBDataSet);

        }

        private void vehicleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            frmNewVehicle forma = new frmNewVehicle();
            forma.ShowDialog();
            ShowAllVehicles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedVehicle = dgvVehicleList.CurrentRow.DataBoundItem as Vehicle;
            if (selectedVehicle != null)
            {
                services.RemoveVehicle(selectedVehicle);
                ShowAllVehicles();
            }
            else
            {

            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if(dgvVehicleList.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Results.pdf";
                bool ErrorMessage = false;
                if(save.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Nije moguće napraviti ispis!");
                        }
                    }
                    if(!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable ptable = new PdfPTable(dgvVehicleList.Columns.Count);
                            ptable.DefaultCell.Padding = 2;
                            ptable.WidthPercentage = 100;
                            ptable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in dgvVehicleList.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                ptable.AddCell(pCell);
                            }
                            foreach(DataGridViewRow viewRow in dgvVehicleList.Rows)
                            {
                               foreach(DataGridViewCell dCell in viewRow.Cells)
                                {
                                    ptable.AddCell(dCell.Value.ToString());
                                }
                            }

                            using(FileStream fileStream =  new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(ptable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Uspiješan ispis!");
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Nije moguće napraviti ispis!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nema podataka za ispis!");
            }

        }
    }
}
