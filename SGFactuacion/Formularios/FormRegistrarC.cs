using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormRegistrarC : Form
    {
        public FormRegistrarC()
        {
            InitializeComponent();
            txtcedulaC.KeyPress += txtcedulaC_KeyPress;
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void LimpiarControles()
        {
            txtcedulaC.Text = string.Empty;
            txtApellidoC.Text= string.Empty;
            txtNombreC.Text=string.Empty;
            txtEmailC.Text= string.Empty;
            dtFechaC.Value = new DateTime(2000, 9, 1);
        }
        private void BTNRegistrarC_Click(object sender, EventArgs e)
        {
            if (txtcedulaC.Text != string.Empty && txtNombreC.Text != string.Empty && txtApellidoC.Text != string.Empty && txtEmailC.Text != string.Empty)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas registrar a este cliente?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    csCliente clienteRegistrar = new csCliente(txtcedulaC.Text, txtNombreC.Text, txtApellidoC.Text, dtFechaC.Value, txtEmailC.Text);
                    if (clienteRegistrar.RegistrarCliente())
                    {
                        MessageBox.Show("Cliente registrado con éxito", "Registro de cliente", MessageBoxButtons.OK);
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo lograr el registro", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmailC_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistrarC_Load(object sender, EventArgs e)
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
    }
}
