using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    public partial class FormEditarP : Form
    {
        private List<csProducto> producto;
        private BindingSource bindingSource;
        public FormEditarP()
        {
            InitializeComponent();
            CargarProductos();
            bindingSource=new BindingSource();
            bindingSource.DataSource= producto;
            dgvEditProdu.DataSource=bindingSource;

        }
        private void CargarProductos()
        {
            producto = csProducto.ListarProductos();
        }
        public void LimpiarCampos()
        {
            TBNombreP.Text = string.Empty;
            TBPrecioP.Text = string.Empty;
            TBStockP.Text = string.Empty;
            txtBuscar.Text = string.Empty;
        }

        private void FormEditarP_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBuscar.Text;
            if (string.IsNullOrWhiteSpace(filterText))
            {
                bindingSource.DataSource = producto;
            }
            else
            {
                bindingSource.DataSource = csProducto.BuscarProductoPorNombre(filterText);
            }
        }
        long idProducto;

        private void dgvEditProdu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dgvEditProdu.Rows[e.RowIndex];
                idProducto = long.Parse(row.Cells["IdProducto"].Value.ToString());
                TBNombreP.Text = row.Cells["Nombre"].Value.ToString();
                TBPrecioP.Text = row.Cells["PrecioUnitario"].Value.ToString();
                TBStockP.Text = row.Cells["Stock"].Value.ToString();
            }

        }

        private void BTEditarP_Click(object sender, EventArgs e)
        {
            string nombre = TBNombreP.Text;
            decimal preciouni = Decimal.Parse(TBPrecioP.Text, CultureInfo.InvariantCulture);
            int stock = int.Parse(TBStockP.Text);
            csProducto product = new csProducto(idProducto, nombre, preciouni, stock);
            if (product.EditarProducto())
            {
                MessageBox.Show("El producto ha sido editado con exito","Modificacion de producto", MessageBoxButtons.OK);
                LimpiarCampos();
                CargarProductos();
                bindingSource.DataSource = producto;
            }
            else MessageBox.Show("Ha ocurrido un error al editar el producto","Error de edicion", MessageBoxButtons.OK);
        }
    }
}
