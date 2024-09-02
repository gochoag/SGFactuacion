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
    public partial class FrmReporteproducto : Form
    {
        private csProducto producto;

        public FrmReporteproducto()
        {
            InitializeComponent();
        }

        private void FrmReporteproducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturaDataSet.sp_rep_Productos_Vendidos_Top5' Puede moverla o quitarla según sea necesario.
            producto = new csProducto();

            
            //this.sp_rep_Productos_Vendidos_Top5TableAdapter.Fill(this.dSProductoVendido.sp_rep_Productos_Vendidos_Top5);
            //this.sp_rep_Productos_Vendidos_Top5TableAdapter.Fill(csProducto.ListarProductos());

            //this.reportViewer1.LocalReport.DataSources = csProducto.ListarProductos();
            producto.CargarReporteListarProductos(this.reportViewer1);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
