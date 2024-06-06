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
    public partial class FormFacturarR : Form
    {
        private List<csCliente> clientes;
        private List<csProducto> productos;
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
    }
}
