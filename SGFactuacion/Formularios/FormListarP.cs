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
            CargarProductos();
            bindingSource= new BindingSource();
            bindingSource.DataSource = producto;
            dgvListProductos.DataSource = bindingSource;
        }
        private void CargarProductos()
        {
            producto=csProducto.ListarProductos();
        }

        private void FormListarP_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filterText=txtBuscar.Text;
            if (string.IsNullOrWhiteSpace(filterText))
            {
                bindingSource.DataSource = producto;
            }
            else
            {
                bindingSource.DataSource = csProducto.BuscarProductoPorNombre(filterText);
            }
        }
    }
}
