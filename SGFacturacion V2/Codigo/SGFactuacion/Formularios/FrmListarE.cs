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
        private List<csEmpleados> empleados;
        private BindingSource bindingSource;
        public FrmListarE()
        {
            InitializeComponent();
            try
            {
                CargarEmpleados();
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
                bindingSource = new BindingSource();
                bindingSource.DataSource = empleados;
                dgvListarEmpleado.DataSource = bindingSource;
                dgvListarEmpleado.Columns["Contraseña"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgvListarEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListarE_Load(object sender, EventArgs e)
        {

        }
    }
}
