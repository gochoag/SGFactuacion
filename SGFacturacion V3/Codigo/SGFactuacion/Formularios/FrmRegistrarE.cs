using SGFactuacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion.Formularios
{
    public partial class FrmRegistrarE : Form
    {
        public FrmRegistrarE()
        {
            InitializeComponent();
            txtcedulaE.KeyPress += txtcedulaE_KeyPress;
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

        private void LimpiarControles()
        {
            txtcedulaE.Clear();
            txtNombreE.Clear();
            txtApellidoE.Clear();
            txtEmailE.Clear();
            txtUser.Clear();
            txtPassword.Clear();
            dtFechaE.Value = DateTime.Now;
        }

        //AQUI TOCA HACER QUE MUESTRE EL ERROR EN CASO DE ENVIAR UNA CEDULA O UN USUARIO YA REGISTRADO
        private void BTNRegistrarE_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcedulaE.Text != string.Empty && txtNombreE.Text != string.Empty && txtApellidoE.Text != string.Empty && txtEmailE.Text != string.Empty && txtUser.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    if (!EsCorreoValido(txtEmailE.Text))
                    {
                        MessageBox.Show("El correo electrónico ingresado no es válido.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas registrar a este empleado?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        string cedula = txtcedulaE.Text;
                        string nombre = txtNombreE.Text;
                        string apellido = txtApellidoE.Text;
                        DateTime fechaNacimiento = dtFechaE.Value;
                        string correo = txtEmailE.Text;
                        string usuario = txtUser.Text;
                        string contraseña = txtPassword.Text;

                        csEmpleados empleado = new csEmpleados(0, cedula, nombre, apellido, fechaNacimiento, correo);
                        csEmpleados.csCredenciales credenciales = new csEmpleados.csCredenciales(usuario, contraseña);
                        bool registrado = empleado.RegistrarEmpleado(credenciales);

                        if (registrado)
                        {
                            MessageBox.Show("Empleado registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarControles();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el empleado", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Completa todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException exq)
            {
                MessageBox.Show($"Ocurrió un error: {exq.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmRegistrarE_Load(object sender, EventArgs e)
        {
            DateTime fechaLimite = DateTime.Now.AddYears(-18);
            dtFechaE.MaxDate = fechaLimite;
        }
    }
}
