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
            CargarCliente();
            CargarProductos();
            this.Activated += new EventHandler(FormFacturarR_Activated);

        }
        private void CargarCliente()
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
        private void CargarProductos()
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

        private void FormFacturarR_Activated(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void cbBuscarProducto_SelectedIndexChanged(object sender, EventArgs e)
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
        private void LimpiarCamposProducto()
        {
            cbBuscarProducto.SelectedIndex = -1;
            txtCantidad.Clear();
            lblNombreProducto.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblStock.Text = string.Empty;
        }

        private void btnAgregarProductoToDGV_Click(object sender, EventArgs e)
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
            dgvListaProductos.Rows.Add(productoSeleccionado.IdProducto, productoSeleccionado.Nombre, productoSeleccionado.PrecioUnitario, cantidad);
            LimpiarCamposProducto();
        }

        private void btnQuitarProductoToDGV_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para eliminar.", "Producto no Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvListaProductos.Rows.RemoveAt(dgvListaProductos.SelectedRows[0].Index);

        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNRegistrarFactura_Click(object sender, EventArgs e)
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
                    IVA = 0.15m, 
                };
                detallesFactura.Add(detalle);
            }
            csFactura facturaManager = new csFactura();

            DateTime fechaActual = DateTime.Now;

            if (facturaManager.RegistrarFactura(idCliente, fechaActual, detallesFactura))
            {
                MessageBox.Show("La factura se ha registrado correctamente.", "Factura Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListaProductos.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al registrar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
