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
using static SGFactuacion.Clases.csEmpleados;

namespace SGFactuacion
{
    public partial class FrmReporte : Form
    {
        private List<csCliente> clientes;
        private BindingSource bindingSource;
        private bool ProductoOCliente = true; //Si esta true entonces el dgv tiene datos de cliente
        private string nombres;
        private long idcliente;


        public FrmReporte()
        {
            InitializeComponent();
            //this.idEmpleado = csCredenciales.IdEmpleadoLogueado;
            textBox1.Visible = false;
            dgvDatosBuscados.Visible = false;
            cbData2.Enabled = false;

            try
            {
                CargarCliente();
                bindingSource = new BindingSource();
                bindingSource.DataSource = clientes;
                dgvDatosBuscados.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarCliente()
        {
            try
            {
                clientes = csCliente.ListarClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void FrmReporte_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        //si ecogo un clinete, se desbloquea el otro cbdata2
   
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cbData2.Text))
                {
                   // long selectedClientId = Convert.ToInt64(cbData1.SelectedValue);
                    DateTime selectedDate = (DateTime)cbData2.SelectedValue;
                    long facturaId = csCliente.GetFacturaIDByClienteIDAndFecha(idcliente, selectedDate);
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

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscarCliente.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = clientes;
                }
                else
                {
                    bindingSource.DataSource = csCliente.BuscarClientes(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            bindingSource.DataSource = clientes;
            dgvDatosBuscados.Visible = true;
            textBox1.Visible = false;
            ProductoOCliente = true; btnCerrarDGV.Enabled = true;
            cbData2.Enabled = false;

        }



        private void dgvDatosBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductoOCliente)
            {
                //Jalo datos de clientes del dgv
                // Asegúrate de que el índice de la fila sea válido
                if (e.RowIndex >= 0)
                {
                    // Pregunta al usuario si está seguro de elegir este cliente y verifica la respuesta
                    if (MessageBox.Show("¿Está seguro de elegir este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Obtén la fila seleccionada
                        DataGridViewRow selectedRow = dgvDatosBuscados.Rows[e.RowIndex];

                        // Obtén los datos de las columnas necesarias
                        idcliente = Convert.ToInt64(selectedRow.Cells["IdCliente"].Value);
                        string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                        string apellido = selectedRow.Cells["Apellido"].Value.ToString();

                        // Combina el nombre y el apellido
                        nombres = nombre + " " + apellido;

                        dgvDatosBuscados.Visible = false;
                        btnCerrarDGV.Enabled = false;
                        textBox1.Visible = true;
                        textBox1.Text = nombres;
                        //Se desbloquea el cbdata2
                        GenerarFechasFacturasCliente(idcliente);
                        cbData2.Enabled = true;
                    }
                    else
                    {
                        panel1.Visible = false;
                        btnCerrarDGV.Enabled = false;
                    }
                }

            }
            else
            {
                //Jalo datos de productos del dgv
                // Asegúrate de que el índice de la fila sea válido
                if (e.RowIndex >= 0)
                {
                    // Pregunta al usuario si está seguro de elegir este cliente y verifica la respuesta
                    if (MessageBox.Show("¿Está seguro de elegir este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Obtén la fila seleccionada
                        DataGridViewRow selectedRow = dgvDatosBuscados.Rows[e.RowIndex];

                        // Obtén los datos de las columnas necesarias
           
                        panel1.Visible = false;
                        btnCerrarDGV.Enabled = false;

                    }
                    else
                    {
                        panel1.Visible = false;
                        btnCerrarDGV.Enabled = false;
                    }

                }
            }
        }

        private void dgvDatosBuscados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
