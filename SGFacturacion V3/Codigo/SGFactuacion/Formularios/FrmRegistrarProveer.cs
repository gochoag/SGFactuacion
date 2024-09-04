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

namespace SGFactuacion.Formularios
{
    public partial class FrmRegistrarProveer : Form
    {
        public FrmRegistrarProveer()
        {
            InitializeComponent();
            txtRuc.KeyPress += txtRuc_KeyPress;
            txtTelf.KeyPress += txtTelf_KeyPress;
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtRuc.Text.Length >= 13)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void FrmRegistrarProveer_Load(object sender, EventArgs e)
        {

        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtTelf.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }
        private bool EsCorreoValido(string email)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patron);
        }
        private void BtnProveeRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRuc.Text) || string.IsNullOrEmpty(txtCorreo.Text)|| string.IsNullOrEmpty(txtDireccion.Text)  || string.IsNullOrEmpty(txtTelf.Text)|| string.IsNullOrEmpty(txtRazon.Text))
                {
                    MessageBox.Show("Ingrese todos los campos", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!EsCorreoValido(txtCorreo.Text))
                {
                    MessageBox.Show("El correo electrónico ingresado no es válido.", "Correo Electrónico Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas registrar a este proveedor?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    CsProveedor prove = new CsProveedor(txtRuc.Text, txtRazon.Text, txtTelf.Text, txtDireccion.Text, txtCorreo.Text);
                    if (prove.RegistrarProveedor())
                    {
                        MessageBox.Show("Proveedor registrado con éxito", "Registro de proveedor", MessageBoxButtons.OK);
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo lograr el registro", "Registro de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void LimpiarControles()
        {
            txtRuc.Clear();
            txtRazon.Clear();
            txtTelf.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
        }
    }
}
