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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormResgistrarP : Form
    {
        BindingSource bindingsource = new BindingSource();
        public FormResgistrarP()
        {
            InitializeComponent();

            bindingsource.DataSource = CsProveedor.ListarProveedores();
            cbRazoncomercial.DataSource = bindingsource;
            cbRazoncomercial.DisplayMember = "RazonComercial";
            cbRazoncomercial.ValueMember = "ID_Proveedor";
        }
        public void LimpiarCampos()
        {
            TBNombreP.Text = string.Empty;
            TBPrecioP.Text = string.Empty;
            TBStockP.Text= string.Empty;
        }

        private void FormResgistrarP_Load(object sender, EventArgs e)
        {

        }

        private void BTRegistrarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBNombreP.Text != string.Empty && TBPrecioP.Text != string.Empty && TBStockP.Text != string.Empty)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea registrar el producto?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        csProducto regisprodu = new csProducto((long)cbRazoncomercial.SelectedValue,TBNombreP.Text, decimal.Parse(TBPrecioP.Text, CultureInfo.InvariantCulture), int.Parse(TBStockP.Text));
                        if (regisprodu.RegistrarProducto())
                        {
                            MessageBox.Show("El producto se ha registrado con éxito", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo lograr el registro del producto", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El registro del producto ha sido cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos necesarios para el registro del producto", "Alerta campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbRazoncomercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
