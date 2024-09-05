using SGFactuacion.Clases;
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
    public partial class FormListarC : Form
    {
        
        private BindingSource bindingSource = new BindingSource();
        public FormListarC()
        {
            InitializeComponent();
           
        }
       
        private void FormListarC_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscar.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = csPersona.ListarPersona();
                }
                else
                {
                    bindingSource.DataSource = csPersona.BuscarPersona(filterText);
                }
                dgvListarCliente.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
