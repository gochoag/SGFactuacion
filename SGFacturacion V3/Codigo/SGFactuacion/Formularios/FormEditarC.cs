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
        private List<csPersona> clientes;
        private BindingSource bindingSource;
        public FormEditarC()
        {
            InitializeComponent();
            try
            {
                CargarClientes();
                bindingSource = new BindingSource();
                bindingSource.DataSource = clientes;
                dgvListadoCliente.DataSource = bindingSource;
                txtcedulaC.KeyPress += txtcedulaC_KeyPress;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarClientes()
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
        private void FormEditarC_Load(object sender, EventArgs e)
        {
            DateTime fechaLimite = DateTime.Now.AddYears(-18);
            dtFechaC.MaxDate = fechaLimite;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscar.Text;
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
                    Apagar_Prender(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar un cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Apagar_Prender(bool habilitar)
        {
            txtNombreC.Enabled = habilitar;
            txtApellidoC.Enabled = habilitar;
            txtcedulaC.Enabled = habilitar;
            dtFechaC.Enabled = habilitar;
            txtEmailC.Enabled = habilitar;
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
                txtBuscar.Text = String.Empty;
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
                
                if (idPERSONA == 0) 
                {
                    MessageBox.Show("No has seleccionado ningún cliente. Por favor, selecciona un cliente antes de editar.",
                                    "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cedula = txtcedulaC.Text;
                string nombre = txtNombreC.Text;
                string apellido = txtApellidoC.Text;
                DateTime fechaNacimiento = dtFechaC.Value;
                string email = txtEmailC.Text;

                // Validar que los campos no estén vacíos
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
                        CargarClientes();
                        Apagar_Prender(false);
                        bindingSource.DataSource = clientes;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al editar el cliente", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
