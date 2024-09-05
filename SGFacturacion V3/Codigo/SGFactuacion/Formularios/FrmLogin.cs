using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGFactuacion.Clases.csEmpleados;

namespace SGFactuacion.Formularios
{
    public partial class FrmLogin : Form
    {
        private bool mostrandoContraseña = false;
        public FrmLogin()
        {
            InitializeComponent();
            txtbContraseña.PasswordChar = '*';

            // Configura el botón para mostrar/ocultar contraseña con la imagen del ojo cerrado
            btnOjo.ImageList = imglistOjos;
            btnOjo.ImageIndex = 0; // Ojo cerrado{

           
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
           string usuario = txtbUsuario.Text.Trim();
           string contraseña = txtbContraseña.Text.Trim();

            //string usuario = "jp";
            //string contraseña = "root";



            // Asegúrate de que los campos de usuario y contraseña no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crea una instancia de csCredenciales con los valores ingresados
            csCredenciales credenciales = new csCredenciales(usuario, contraseña);

            // Verifica si el inicio de sesión es exitoso
            bool sesionIniciada = credenciales.IniciarSesion();

            if (sesionIniciada)
            {
                Form frm = new Principal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales de inicio de sesión inválidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOjo_Click(object sender, EventArgs e)
        {
            // Alterna entre mostrar y ocultar la contraseña
            if (mostrandoContraseña)
            {
                // Ocultar contraseña
                txtbContraseña.PasswordChar = '*';
                btnOjo.ImageIndex = 0; // Ojo cerrado
                mostrandoContraseña = false;
            }
            else
            {
                // Mostrar contraseña
                txtbContraseña.PasswordChar = '\0';
                btnOjo.ImageIndex = 1; // Ojo abierto
                mostrandoContraseña = true;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
               
                btnEntrar_Click(sender, e);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Enter(object sender, EventArgs e)
        {
           
        }

        private void FrmLogin_Enter(object sender, EventArgs e)
        {
        }

        private void txtbUsuario_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtbContraseña_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                btnEntrar_Click(sender, e);

            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                btnEntrar_Click(sender, e);

            }
        }

        private void btnOjo_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
    }
}
