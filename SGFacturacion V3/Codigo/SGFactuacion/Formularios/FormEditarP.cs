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
            try
            {
                CargarProductos();
                bindingSource = new BindingSource();
                bindingSource.DataSource = producto;
                dgvEditProdu.DataSource = bindingSource;
                TBPrecioP.KeyPress += TBPrecioP_KeyPress;
                TBStockP.KeyPress += TBStockP_KeyPress;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarProductos()
        {
            try
            {
                producto = csProducto.ListarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        long idProducto;

        private void dgvEditProdu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvEditProdu.Rows[e.RowIndex];
                    idProducto = long.Parse(row.Cells["IdProducto"].Value.ToString());
                    TBNombreP.Text = row.Cells["Nombre"].Value.ToString();
                    TBPrecioP.Text = row.Cells["PrecioUnitario"].Value.ToString();
                    TBStockP.Text = row.Cells["Stock"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar un producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTEditarP_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TBNombreP.Text;
                string precioTexto = TBPrecioP.Text;
                string stockTexto = TBStockP.Text;
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(precioTexto) || string.IsNullOrWhiteSpace(stockTexto))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                decimal preciouni;
                decimal stock;
                if (!decimal.TryParse(precioTexto.Replace('.', ','), out preciouni) ||
                    !decimal.TryParse(stockTexto.Replace('.', ','), out stock))
                {
                    MessageBox.Show("Por favor, introduce valores válidos en los campos de precio y stock.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar este producto?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    csProducto product = new csProducto(idProducto, nombre, preciouni, stock);
                    if (product.EditarProducto())
                    {
                        MessageBox.Show("El producto ha sido editado con éxito", "Modificación de producto", MessageBoxButtons.OK);
                        LimpiarCampos();
                        CargarProductos();
                        bindingSource.DataSource = producto;
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al editar el producto", "Error de edición", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar la entrada de stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void TBStockP_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBPrecioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !TBPrecioP.Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }

        private void TBPrecioP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
