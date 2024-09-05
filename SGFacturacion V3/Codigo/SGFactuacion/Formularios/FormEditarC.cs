using SGFactuacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormEditarC : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public FormEditarC()
        {
            InitializeComponent(); 
        }
       
        private void FormEditarC_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscar.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource  = csPersona.ListarPersona();
                }
                else
                {
                    bindingSource.DataSource = csPersona.BuscarPersona(filterText);
                }
                dgvListadoCliente.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        long idPERSONA;
        private void dgvListadoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvListadoCliente.Rows[e.RowIndex];
                    idPERSONA = long.Parse(row.Cells["IdPersona"].Value.ToString());
                    txtcedulaC.Text = row.Cells["Cedula"].Value.ToString();
                    txtNombreC.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellidoC.Text = row.Cells["Apellido"].Value.ToString();
                    dtFechaC.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                    txtEmailC.Text = row.Cells["Email"].Value.ToString();
                    Apagar_Prender();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar un cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Apagar_Prender()
        {
            txtApellidoC.Enabled = txtApellidoC.Enabled ? false : true;
            txtcedulaC.Enabled = txtcedulaC.Enabled ? false : true;
            txtEmailC.Enabled = txtEmailC.Enabled ? false : true;
            txtNombreC.Enabled = txtNombreC.Enabled ? false : true;
            dtFechaC.Enabled = dtFechaC.Enabled ? false : true;
        }
        public void LimpiarControles()
        {
            try
            {
                txtcedulaC.Text = string.Empty;
                txtApellidoC.Text = string.Empty;
                txtNombreC.Text = string.Empty;
                txtEmailC.Text = string.Empty;
                dtFechaC.Value = new DateTime(2000, 9, 1);
                txtBuscar.Text = string.Empty;
                txtEmailC.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al limpiar los controles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsCorreoValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }
        private void BTEditarC_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtcedulaC.Text;
                string nombre = txtNombreC.Text;
                string apellido = txtApellidoC.Text;
                DateTime fechaNacimiento = dtFechaC.Value;
                string email = txtEmailC.Text;

                if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!EsCorreoValido(txtEmailC.Text))
                {
                    MessageBox.Show("El correo electrónico ingresado no es válido.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    csPersona cliente = new csPersona(idPERSONA, cedula, nombre, apellido, fechaNacimiento, email);

                    if (cliente.EditarPersona())
                    {
                        MessageBox.Show("Cliente editado exitosamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        Apagar_Prender();
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al editar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvListadoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcedulaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtcedulaC.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void txtcedulaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaC_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
