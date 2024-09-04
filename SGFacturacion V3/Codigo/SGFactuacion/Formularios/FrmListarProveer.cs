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
    public partial class FrmListarProveer : Form
    {
        private List<CsProveedor> listaProveedor;
        private BindingSource bindingSource = new BindingSource();
        public FrmListarProveer()
        {
            InitializeComponent();
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarP.Text))
                {
                    bindingSource.DataSource = CsProveedor.ListarProveedores();
                }
                else
                {
                    bindingSource.DataSource = CsProveedor.BuscarProveedor(txtBuscarP.Text);
                }
                dgvListarProveedores.DataSource = bindingSource;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
            
        }
    }
}
