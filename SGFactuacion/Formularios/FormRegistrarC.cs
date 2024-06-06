using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    public partial class FormRegistrarC : Form
    {
        public FormRegistrarC()
        {
            InitializeComponent();
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
                csCliente clienteRegistrar = new csCliente(txtcedulaC.Text, txtNombreC.Text, txtApellidoC.Text, dtFechaC.Value, txtEmailC.Text);
                if (clienteRegistrar.RegistrarCliente())
                {
                    MessageBox.Show("Cliente registrado con exito", "Registro de cliente", MessageBoxButtons.OK);
                    LimpiarControles();
                }
                else MessageBox.Show("No se puedo lograr el registro", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else MessageBox.Show("Complete todos los campos", "Campos vacios",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
           



        }

        private void txtEmailC_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistrarC_Load(object sender, EventArgs e)
        {

        }
    }
}
