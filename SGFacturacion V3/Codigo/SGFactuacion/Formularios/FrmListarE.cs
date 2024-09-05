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

namespace SGFactuacion.Formularios
{
    public partial class FrmListarE : Form
    {
     
        private BindingSource bindingSource = new BindingSource();
        public FrmListarE()
        {
            InitializeComponent();
           
        }

       


        private void txtBuscarE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscarE.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = csEmpleados.ListarEmpleados();
                }
                else
                {
                    bindingSource.DataSource = csEmpleados.BuscarEmpleados(filterText);
                }
                dgvListarEmpleado.DataSource = bindingSource; dgvListarEmpleado.Columns["Contraseña"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvListarEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListarE_Load(object sender, EventArgs e)
        {

        }
    }
}
