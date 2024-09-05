using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using SGFactuacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion.Formularios
{
    public partial class FrmEditarProvee : Form
    {

        private BindingSource bindingSource = new BindingSource();
        public FrmEditarProvee()
        {
            InitializeComponent();
           
        }

        private void txtRUCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtRUCE.Text.Length >= 13)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void txtTelfE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtTelfE.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }
       
        long idProveedorSeleccionado;
        private void dgvListadoProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvListadoProveedor.Rows[e.RowIndex];

                    idProveedorSeleccionado = long.Parse(row.Cells["ID_Proveedor"].Value.ToString());
                    txtRUCE.Text = row.Cells["RUC"].Value.ToString();
                    txtRazonE.Text = row.Cells["RazonComercial"].Value.ToString();
                    txtTelfE.Text = row.Cells["Telefono"].Value.ToString();
                    txtDireccionE.Text = row.Cells["Direccion"].Value.ToString();
                    txtCorreoE.Text = row.Cells["Email"].Value.ToString();
                    
              
                    Apagar_Prender();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar un producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Apagar_Prender()
        {
            txtRazonE.Enabled = txtRazonE.Enabled ? false:true;
            txtRUCE.Enabled = txtRUCE.Enabled ? false : true;
            txtTelfE.Enabled = txtTelfE.Enabled ? false : true;
            txtDireccionE.Enabled = txtDireccionE.Enabled ? false : true;
            txtCorreoE.Enabled = txtCorreoE.Enabled ? false : true;
        }
        private void LimpiarControles()
        {
            txtRazonE.Clear();
            txtRUCE.Clear();
            txtTelfE.Clear();
            txtDireccionE.Clear();
            txtCorreoE.Clear();
            txtBuscarE.Clear();
        }
        private bool EsCorreoValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }
        private void FrmEditarProvee_Load(object sender, EventArgs e)
        {

        }

        private void BtnEditarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRUCE.Text) || string.IsNullOrEmpty(txtRazonE.Text) || string.IsNullOrEmpty(txtTelfE.Text) || string.IsNullOrEmpty(txtDireccionE.Text) || string.IsNullOrEmpty(txtCorreoE.Text))
                {
                    MessageBox.Show("Ingrese todos los campos", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!EsCorreoValido(txtCorreoE.Text))
                {
                    MessageBox.Show("El correo electrónico ingresado no es válido.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar a este proveedor?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    CsProveedor proveedor = new CsProveedor(idProveedorSeleccionado,txtRUCE.Text,txtRazonE.Text,txtTelfE.Text,txtDireccionE.Text,txtCorreoE.Text);
                    if (proveedor.EditarProveedor())
                    {
                        MessageBox.Show("Proveedor editado con éxito", "Editar de proveedor", MessageBoxButtons.OK);
                        LimpiarControles();
                        Apagar_Prender(); 
        
                    }
                    else
                    {
                        MessageBox.Show("No se pudo lograr la edición", "Editar de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarE.Text))
                {
                    bindingSource.DataSource = CsProveedor.ListarProveedores();
                }
                else
                {
                    bindingSource.DataSource = CsProveedor.BuscarProveedor(txtBuscarE.Text);
                }
                dgvListadoProveedor.DataSource = bindingSource;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
