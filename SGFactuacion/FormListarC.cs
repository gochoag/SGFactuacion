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
        private List<csCliente> clientes;
        private BindingSource bindingSource;
        public FormListarC()
        {
            InitializeComponent();
            CargarClientes();
            bindingSource = new BindingSource();
            bindingSource.DataSource = clientes;
            dgvListarCliente.DataSource = bindingSource;
        }
        private void CargarClientes()
        {
            clientes = csCliente.ListarClientes();

        }
        private void FormListarC_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBuscar.Text;
            if (string.IsNullOrWhiteSpace(filterText))
            {
                bindingSource.DataSource = clientes;
            }
            else
            {
                bindingSource.DataSource = csCliente.BuscarClientes(filterText);
            }
        }
    }
}
