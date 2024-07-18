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
    public partial class FormListarP : Form
    {
        private List<csProducto> producto;
        private BindingSource bindingSource;
        public FormListarP()
        {
            InitializeComponent();
            try
            {
                CargarProductos();
                bindingSource = new BindingSource();
                bindingSource.DataSource = producto;
                dgvListProductos.DataSource = bindingSource;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarProductos()
        {
            try
            {
                producto = csProducto.ListarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormListarP_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscar.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = producto;
                    
                }
                else
                {
                    bindingSource.DataSource = csProducto.BuscarProductoPorNombre(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
