using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGFactuacion.csFactura;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormFacturarR : Form
    {
        private List<csCliente> clientes;
        private List<csProducto> productos;
        private List<FacturaDetalle> detallesFactura;
        public FormFacturarR()
        {
            InitializeComponent();
            try
            {
                CargarCliente();
                CargarProductos();
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
                cbBuscarCliente.DataSource = clientes;
                cbBuscarCliente.DisplayMember = "NombreCompleto";
                cbBuscarCliente.ValueMember = "IdCliente";

                cbBuscarCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbBuscarCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbBuscarCliente.AutoCompleteCustomSource = csCliente.Autocompletado();

                cbBuscarCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void CargarProductos()
        {
            try
            {
                productos = csProducto.ListarProductos();
                cbBuscarProducto.DataSource = productos;
                cbBuscarProducto.DisplayMember = "Nombre";
                cbBuscarProducto.ValueMember = "IdProducto";

                cbBuscarProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbBuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbBuscarProducto.AutoCompleteCustomSource = csProducto.Autocompletado();

                cbBuscarProducto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }
        private void FormFacturarR_Load(object sender, EventArgs e)
        {
            dgvListaProductos.ColumnCount = 4;
            dgvListaProductos.Columns[0].Name = "ID_Producto";
            dgvListaProductos.Columns[1].Name = "Nombre";
            dgvListaProductos.Columns[2].Name = "Precio";
            dgvListaProductos.Columns[3].Name = "Cantidad";
        }

        private void cbBuscarCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbBuscarCliente.SelectedItem != null && cbBuscarCliente.SelectedIndex != -1)
                {
                    csCliente selectedCliente = (csCliente)cbBuscarCliente.SelectedItem;
                    lblNombreCliente.Text = selectedCliente.NombreCompleto;
                }
                else
                {
                    lblNombreCliente.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormFacturarR_Activated(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void cbBuscarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbBuscarProducto.SelectedItem != null && cbBuscarProducto.SelectedIndex != -1)
                {
                    csProducto productoSeleccionado = (csProducto)cbBuscarProducto.SelectedItem;
                    lblNombreProducto.Text = productoSeleccionado.Nombre;
                    lblPrecio.Text = productoSeleccionado.PrecioUnitario.ToString("F2");
                    lblStock.Text = productoSeleccionado.Stock.ToString();
                }
                else
                {
                    lblNombreProducto.Text = string.Empty;
                    lblPrecio.Text = string.Empty;
                    lblStock.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void LimpiarCamposProducto()
        {
            cbBuscarProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            lblNombreProducto.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblStock.Text = string.Empty;
        }
        private void LimpiarCamposCliente()
        {
            cbBuscarCliente.SelectedIndex = -1;
            lblNombreCliente.Text = string.Empty;
        }

        private void btnAgregarProductoToDGV_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbBuscarCliente.SelectedItem == null || cbBuscarProducto.SelectedItem == null || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var productoSeleccionado = (csProducto)cbBuscarProducto.SelectedItem;
                int cantidad;
                if (!int.TryParse(txtCantidad.Text, out cantidad))
                {
                    MessageBox.Show("La cantidad ingresada no es válida.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cantidad > productoSeleccionado.Stock)
                {
                    MessageBox.Show("La cantidad ingresada excede el stock disponible.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    if (row.Cells["ID_Producto"].Value != null && (long)row.Cells["ID_Producto"].Value == productoSeleccionado.IdProducto)
                    {
                        MessageBox.Show("El producto ya está en la lista.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                dgvListaProductos.Rows.Add(productoSeleccionado.IdProducto, productoSeleccionado.Nombre, productoSeleccionado.PrecioUnitario, cantidad);

                //validar que tenga contenido el dgv
                BTNRegistrarFactura.Enabled = dgvListaProductos.Rows.Count > 0;


                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el producto a la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnQuitarProductoToDGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto de la lista para eliminar.", "Producto no Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvListaProductos.Rows.RemoveAt(dgvListaProductos.SelectedRows[0].Index);
                BTNRegistrarFactura.Enabled = dgvListaProductos.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al quitar el producto a la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GenerarReporte(long idFactura)
        {
            try
            {
                FrmReporte rp = new FrmReporte();
                rp.panel1.Visible = false;
                rp.FormBorderStyle=FormBorderStyle.SizableToolWindow;
                rp.StartPosition = FormStartPosition.CenterScreen;
                rp.Width = 630;
                rp.GenerarReporte(idFactura);

                rp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNRegistrarFactura_Click(object sender, EventArgs e)
        {
            try
            {

                long idCliente = (long)cbBuscarCliente.SelectedValue;
                List<FacturaDetalle> detallesFactura = new List<FacturaDetalle>();
                foreach (DataGridViewRow fila in dgvListaProductos.Rows)
                {
                    long idProducto = Convert.ToInt64(fila.Cells["ID_Producto"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    FacturaDetalle detalle = new FacturaDetalle
                    {
                        ID_Produc = idProducto,
                        Precio = precio,
                        Cantidad = cantidad,
                        IVA = decimal.Parse(txtIVA.Text)/100,
                    };
                    detallesFactura.Add(detalle);
                }
                csFactura facturaManager = new csFactura();

                DateTime fechaActual = DateTime.Now;

                DialogResult result = MessageBox.Show("¿Está seguro de que desea registrar la factura?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (facturaManager.RegistrarFactura(idCliente, fechaActual, detallesFactura))
                    {
                        MessageBox.Show("La factura se ha registrado correctamente.", "Factura Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvListaProductos.Rows.Clear();
                        LimpiarCamposCliente();
                        CargarProductos();
                        GenerarReporte(facturaManager.ObtenerUltimoIDFactura());
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al registrar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El registro de la factura ha sido cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("sdsdsd");

            }


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void lblNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (lblNombreCliente.Text != string.Empty)
            {
                cbBuscarProducto.Enabled = true;
                txtCantidad.Enabled=true;
                txtIVA.Enabled=true;
            }
            else
            {
                cbBuscarProducto.Enabled = false;
                txtCantidad.Enabled = false;
                txtIVA.Enabled=false;
            }

        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtIVA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIVA.Text))
            {
                txtIVA.Text = "15";
            }
        }

        private void txtIVA_Enter(object sender, EventArgs e)
        {
            if (txtIVA.Text == "15")
            {
                txtIVA.Text = "";
            }
        }

        private void dgvListaProductos_DataSourceChanged(object sender, EventArgs e)
        {
        }
    }
}
