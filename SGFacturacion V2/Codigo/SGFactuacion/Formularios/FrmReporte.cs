using Microsoft.Reporting.WinForms;
using SGFactuacion.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    public partial class FrmReporte : Form
    {
        private List<csCliente> clientes;
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarCliente()
        {
            try
            {
                clientes = csCliente.ListarClientes();
                cbData1.DataSource = clientes;
                cbData1.DisplayMember = "NombreCompleto";
                cbData1.ValueMember = "IdCliente";

                cbData1.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbData1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbData1.AutoCompleteCustomSource = csCliente.Autocompletado();

                cbData1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GenerarFechasFacturasCliente(long id)
        {
            try
            {
                List<csFactura> facturasConFecha = csFactura.FechaFacturaCliente(id);

                cbData2.DataSource = facturasConFecha;
                cbData2.DisplayMember = "FechaFactura";
                cbData2.ValueMember = "FechaFactura";

                cbData2.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar las fechas de las facturas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbTipoReporte.SelectedItem.ToString())
                {
                    case "Detalle de factura":

                        CargarCliente();
                        cbData1.Enabled = true;
                        cbData2.Enabled = false;
                        break;
                  
                    default:
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar los tipos de reporte {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

       

        
        public void GenerarReporte(long id)
        {
            try
            {
                
                this.sp_GetFacturaDetallesTableAdapter.Fill(this.dSFacturadetalle.sp_GetFacturaDetalles, id);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cbData1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbData1.SelectedIndex != -1 && cbData1.SelectedValue != null)
                {

                    csCliente selectedCliente = (csCliente)cbData1.SelectedItem;
                    GenerarFechasFacturasCliente(selectedCliente.IdCliente);
                    cbData2.Enabled = true;
                }
            }
            catch (Exception f)
            {

                MessageBox.Show("Error: "+f.Message);
            }
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbData1.Text) && !string.IsNullOrEmpty(cbData2.Text))
                {
                    long selectedClientId = Convert.ToInt64(cbData1.SelectedValue);
                    DateTime selectedDate = (DateTime)cbData2.SelectedValue;
                    long facturaId = csCliente.GetFacturaIDByClienteIDAndFecha(selectedClientId, selectedDate);
                    GenerarReporte(facturaId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
         
            }
            
        }

        private void cbData2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }
    }
}
