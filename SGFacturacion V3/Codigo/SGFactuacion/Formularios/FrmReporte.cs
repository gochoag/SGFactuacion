using Microsoft.Reporting.WinForms;
using SGFactuacion.Clases;
using SGFactuacion.Formularios;
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
        private List<csPersona> clientes;
        private List<csEmpleados> empleados;
        private BindingSource bindingSource;
        private string nombres;
        private long idpersona;
        private long idEmpleado;
        private bool EmpleadoOCliente = true;
        private Form activeForm = null;

        public FrmReporte()
        {
            InitializeComponent();
            //this.idEmpleado = csCredenciales.IdEmpleadoLogueado;
            textBox1.Visible = false;
            paneldeDAtos.Visible = false;
            cbData2.Enabled = false;
            btnGenerar.Enabled = false;
            txtBuscarCliente.Visible = false;
            txtBuscarEmpleado.Visible = false;
            try
            {
                CargarCliente();
                CargarEmpelado();
                bindingSource = new BindingSource();
                bindingSource.DataSource = clientes;
                dgvDatosBuscados.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void CargarEmpelado()
        {
            try
            {
                empleados = csEmpleados.ListarEmpleados();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los Empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCliente()
        {
            try
            {
                clientes = csPersona.ListarPersona();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                        txtBuscarCliente.Visible = true;
                        txtBuscarEmpleado.Visible = false;
                        label1.Text = "Buscar Cliente:";
                        lblDatos.Text = "Cliente: ";
                        reportViewer1.Visible = true;
                        pnlreportes.Visible = false;
                        textBox1.Text = string.Empty;
                        label1.Visible = true;
                        lblDatos2.Visible = true;
                        lblDatos.Visible = true;
                        break;
                    case "Total de venta de empleados":
                        CargarEmpelado();
                        cbData2.Visible = false;
                        txtBuscarEmpleado.Visible = true;
                        txtBuscarCliente.Visible = false;
                        label1.Text = "Buscar Empleado:";
                        lblDatos.Text = "Empleado: ";
                        reportViewer1.Visible = false;
                        pnlreportes.Visible = true;
                        textBox1.Text = string.Empty;
                        label1.Visible = true;
                        lblDatos2.Visible = false;
                        lblDatos.Visible = true;
                        break;
                    case "Top 5 de produtos vendidos":
                        cbData2.Visible= false;
                        txtBuscarEmpleado.Visible = false;
                        txtBuscarCliente.Visible = false;
                        label1.Visible=false;
                        lblDatos.Visible=false;
                        lblDatos2.Visible = false;
                        btnGenerar.Enabled = true;
                        reportViewer1.Visible = false;
                        textBox1.Visible= false;
                        textBox1.Text = string.Empty;
                        break;
                    case "Top 5 de factura con mas listado":
                        cbData2.Visible = false;
                        txtBuscarEmpleado.Visible = false;
                        txtBuscarCliente.Visible = false;
                        label1.Visible = false;
                        lblDatos.Visible = false;
                        lblDatos2.Visible = false;
                        btnGenerar.Enabled = true;
                        reportViewer1.Visible = false;
                        textBox1.Visible = false;
                        textBox1.Text = string.Empty;
                        break;
                    case "Top 5 de Clientes":
                        cbData2.Visible = false;
                        txtBuscarEmpleado.Visible = false;
                        txtBuscarCliente.Visible = false;
                        label1.Visible = false;
                        lblDatos.Visible = false;
                        lblDatos2.Visible = false;
                        btnGenerar.Enabled = true;
                        reportViewer1.Visible = false;
                        textBox1.Visible = false;
                        textBox1.Text = string.Empty;
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

        

        public void GenerarReporte1( long id)
        {
            csFactura f=new csFactura();
            try
            {
                //this.sp_GetFacturaDetallesTableAdapter.Fill(this.dSFacturadetalle.sp_GetFacturaDetalles, id);
                f.CargarReportesp_GetFacturaDetalles(this.reportViewer1,id);
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
        private void MostrarFormularioHijo(object hijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            if (this.pnlreportes.Controls.Count > 0)
            {
                this.pnlreportes.Controls.RemoveAt(0);
            }
            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlreportes.Controls.Add(fh);
            this.pnlreportes.Tag = fh;
            fh.Show();
        }
        //si ecogo un clinete, se desbloquea el otro cbdata2

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(cbData2.Text) && EmpleadoOCliente)
                {
                   
                    DateTime selectedDate = (DateTime)cbData2.SelectedValue;
                    long facturaId = csPersona.GetFacturaIDByClienteIDAndFecha(idpersona, selectedDate);
                    GenerarReporte1( facturaId);
                }
                else if (!string.IsNullOrEmpty(textBox1.Text)&& !EmpleadoOCliente)
                {
                    FrmReporteEmpelado frmReporteVentaEmpleado = new FrmReporteEmpelado();
                    frmReporteVentaEmpleado.GenerarReporte(idEmpleado);
                    MostrarFormularioHijo(frmReporteVentaEmpleado);
                }
                else if(cbTipoReporte.Text== "Top 5 de produtos vendidos"&& string.IsNullOrEmpty(textBox1.Text))
                {
                    MostrarFormularioHijo(new FrmReporteproducto());
                }
                else if (cbTipoReporte.Text == "Top 5 de factura con mas listado"&& string.IsNullOrEmpty(textBox1.Text))
                {
                    MostrarFormularioHijo(new FrmReporteFacturalistado());
                }
                else if (cbTipoReporte.Text == "Top 5 de Clientes" && string.IsNullOrEmpty(textBox1.Text))
                {
                    MostrarFormularioHijo(new FrmReportetopcliente());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
         
            }
            
        }

        private void cbData2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbData2.SelectedIndex!=-1)
            btnGenerar.Enabled = true;
            else
            btnGenerar.Enabled = false;

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
                    bindingSource.DataSource = csPersona.BuscarPersona(filterText);
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
            paneldeDAtos.Visible = true;
            EmpleadoOCliente = true;
            btnCerrarDGV.Enabled = true;
            cbData2.Enabled = false;

        }



        private void dgvDatosBuscados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmpleadoOCliente)
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
                        idpersona = Convert.ToInt64(selectedRow.Cells["IdPersona"].Value);
                        string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                        string apellido = selectedRow.Cells["Apellido"].Value.ToString();

                        // Combina el nombre y el apellido
                        nombres = nombre + " " + apellido;

                        paneldeDAtos.Visible = false;
                        btnCerrarDGV.Enabled = false;
                        textBox1.Visible = true;
                        textBox1.Text = nombres;
                        lblDatos2.Visible = true;
                        //Se desbloquea el cbdata2
                        GenerarFechasFacturasCliente(idpersona);
                        cbData2.Visible = true;
                        cbData2.Enabled = true;
                    }
                    else
                    {
                        paneldeDAtos.Visible = false;
                        btnCerrarDGV.Enabled = false;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de elegir este Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow selectedRow = dgvDatosBuscados.Rows[e.RowIndex];

                    // Obtén los datos de las columnas necesarias
                    idEmpleado = Convert.ToInt64(selectedRow.Cells["IdEmpleado"].Value);
                    string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                    string apellido = selectedRow.Cells["Apellido"].Value.ToString();

                    // Combina el nombre y el apellido
                    nombres = nombre + " " + apellido;

                    paneldeDAtos.Visible = false;
                    btnCerrarDGV.Enabled = false;
                    textBox1.Visible = true;
                    textBox1.Text = nombres;
                    lblDatos2.Visible= false;
                    cbData2.Visible = false;
                }
                else
                {
                    paneldeDAtos.Visible = false;
                    btnCerrarDGV.Enabled = false;
                }

            }

            
        }

        private void dgvDatosBuscados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarDGV_Click(object sender, EventArgs e)
        {
            paneldeDAtos.Visible = false;
            btnCerrarDGV.Enabled = false;
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string filterText = txtBuscarCliente.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = empleados;
                }
                else
                {
                    bindingSource.DataSource = csEmpleados.BuscarEmpleados(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar Empelado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBuscarEmpleado_Enter(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            bindingSource.DataSource = empleados;
            paneldeDAtos.Visible = true;
            EmpleadoOCliente = false;
            btnCerrarDGV.Enabled = true;
            cbData2.Enabled = false;
            btnGenerar.Enabled = true;
           

        }

       
    }
}
