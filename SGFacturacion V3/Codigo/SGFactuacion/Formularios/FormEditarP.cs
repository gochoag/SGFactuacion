using SGFactuacion.Clases;
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
    
        private BindingSource bindingSource = new BindingSource();
        private BindingSource bindingSource2 = new BindingSource();
        public FormEditarP()
        {
            InitializeComponent();
            bindingSource2.DataSource = CsProveedor.ListarProveedores();
            cbRazoncomercial.DataSource = bindingSource2;
            cbRazoncomercial.DisplayMember = "RazonComercial";
            cbRazoncomercial.ValueMember = "ID_Proveedor";
            cbRazoncomercial.SelectedIndex = -1;

        }
        
        public void LimpiarCampos()
        {
            TBNombreP.Text = string.Empty;
            TBPrecioP.Text = string.Empty;
            TBStockP.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            cbRazoncomercial.SelectedIndex = -1;
        }
        private void Apagar_Prender()
        {
            TBNombreP.Enabled = TBNombreP.Enabled ? false : true;
            TBPrecioP.Enabled = TBPrecioP.Enabled ? false : true;
            TBStockP.Enabled = TBStockP.Enabled ? false : true;
            cbRazoncomercial.Enabled = cbRazoncomercial.Enabled ? false : true;
 
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
                    bindingSource.DataSource  = csProducto.ListarProductos();
                }
                else
                {
                    bindingSource.DataSource = csProducto.BuscarProductoPorNombre(filterText);
                }
                dgvEditProdu.DataSource = bindingSource;

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
                    cbRazoncomercial.Text = (row.Cells["RazonComercial"].Value.ToString()); Apagar_Prender();
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
                    csProducto product = new csProducto(idProducto,(long)cbRazoncomercial.SelectedValue, nombre, preciouni, stock);
                    if (product.EditarProducto())
                    {
                        MessageBox.Show("El producto ha sido editado con éxito", "Modificación de producto", MessageBoxButtons.OK);
                        LimpiarCampos();
                        Apagar_Prender();
                        bindingSource.DataSource = csProducto.ListarProductos();
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
            // Permitir teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo números
            if (char.IsDigit(e.KeyChar))
            {
                // Verificar si ya hay un punto decimal en el texto
                if (TBStockP.Text.Contains("."))
                {
                    // Si ya hay un punto, restringir a 4 decimales
                    string[] partes = TBStockP.Text.Split('.');
                    if (partes.Length > 1 && partes[1].Length >= 4)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                // Verificar que el número total de dígitos no exceda 10 (incluyendo decimales)
                if (TBStockP.Text.Length >= 10 && !TBStockP.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.' && !TBStockP.Text.Contains("."))
            {
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void TBPrecioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo números
            if (char.IsDigit(e.KeyChar))
            {
                // Verificar si ya hay un punto decimal en el texto
                if (TBPrecioP.Text.Contains("."))
                {
                    // Si ya hay un punto, restringir a 4 decimales
                    string[] partes = TBPrecioP.Text.Split('.');
                    if (partes.Length > 1 && partes[1].Length >= 4)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                // Verificar que el número total de dígitos no exceda 10 (incluyendo decimales)
                if (TBPrecioP.Text.Length >= 10 && !TBPrecioP.Text.Contains("."))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Permitir un solo punto decimal
            if (e.KeyChar == '.' && !TBPrecioP.Text.Contains("."))
            {
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        private void TBPrecioP_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRazoncomercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBStockP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
