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
using static SGFactuacion.Clases.csEmpleados;

namespace SGFactuacion.Formularios
{
    public partial class FrmEditarE : Form
    {
        private List<csEmpleados> empleados;
        private BindingSource bindingSource;
        private long idEmpleadoSeleccionado;

        public FrmEditarE()
        {
            InitializeComponent();
            try
            {
                CargarEmpleados();
                dgvListadoEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                bindingSource = new BindingSource();
                bindingSource.DataSource = empleados;
                dgvListadoEmpleado.DataSource = bindingSource;
                dgvListadoEmpleado.Columns["Contraseña"].Visible = false;
                txtcedulaE.KeyPress += txtcedulaE_KeyPress;
                dgvListadoEmpleado.CellClick += dgvListadoEmpleado_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarEmpleados()
        {
            try
            {
                empleados = csEmpleados.ListarEmpleados();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcedulaE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtcedulaE.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void dgvListadoEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvListadoEmpleado.Rows[e.RowIndex];
                    idEmpleadoSeleccionado = long.Parse(row.Cells["IdEmpleado"].Value.ToString());
                    txtcedulaE.Text = row.Cells["Cedula"].Value.ToString();
                    txtNombreE.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellidoE.Text = row.Cells["Apellido"].Value.ToString();
                    dtFechaE.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                    txtEmailE.Text = row.Cells["Email"].Value.ToString();
                    txtUser.Text = row.Cells["Usuario"].Value.ToString();
                    txtPassword.Text = row.Cells["Contraseña"].Value.ToString();
                    Apagar_Prender(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar un empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool EsCorreoValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void Apagar_Prender(bool habilitar)
        {
            txtNombreE.Enabled = habilitar;
            txtApellidoE.Enabled = habilitar;
            txtcedulaE.Enabled = habilitar;
            dtFechaE.Enabled = habilitar;
            txtEmailE.Enabled = habilitar;
            txtUser.Enabled = habilitar;
            txtPassword.Enabled = habilitar;
        }
        private void BTEditarE_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se ha seleccionado un empleado
                if (idEmpleadoSeleccionado == 0) // o cualquier valor que represente "ningún empleado seleccionado"
                {
                    MessageBox.Show("No has seleccionado ningún empleado. Por favor, selecciona un empleado antes de editar.",
                                    "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cedula = txtcedulaE.Text;
                string nombre = txtNombreE.Text;
                string apellido = txtApellidoE.Text;
                DateTime fechaNacimiento = dtFechaE.Value;
                string email = txtEmailE.Text;
                string usuario = txtUser.Text;
                string contraseña = txtPassword.Text;

               
                if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!EsCorreoValido(txtEmailE.Text))
                {
                    MessageBox.Show("El correo electrónico ingresado no es válido.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar este empleado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                   
                    csCredenciales credenciales = new csCredenciales(usuario, contraseña);
                    csEmpleados empleado = new csEmpleados(idEmpleadoSeleccionado, cedula, nombre, apellido, fechaNacimiento, email);

                   
                    if (empleado.EditarEmpleado(credenciales))
                    {
                        MessageBox.Show("Empleado editado exitosamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        CargarEmpleados();
                        Apagar_Prender(false);
                        bindingSource.DataSource = empleados;
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al editar el empleado", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al editar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            txtcedulaE.Text = string.Empty;
            txtNombreE.Text = string.Empty;
            txtApellidoE.Text = string.Empty;
            dtFechaE.Value = new DateTime(2000, 9, 1);
            txtEmailE.Text = string.Empty;
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void txtBuscarE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscarE.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = empleados;
                }
                else
                {
                    bindingSource.DataSource = csEmpleados.BuscarEmpleados(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEditarE_Load(object sender, EventArgs e)
        {
            DateTime fechaLimite = DateTime.Now.AddYears(-18);
            dtFechaE.MaxDate = fechaLimite;
        }
    }
}
