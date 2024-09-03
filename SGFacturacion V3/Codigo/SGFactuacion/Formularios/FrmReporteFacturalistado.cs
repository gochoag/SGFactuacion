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
    public partial class FrmReporteFacturalistado : Form
    {
        public FrmReporteFacturalistado()
        {
            InitializeComponent();
        }

        private void FrmReporteFacturalistado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturaDataSet.sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5' Puede moverla o quitarla según sea necesario.
           
            csFactura f=new csFactura();
            f.CargarReportesp_sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5(this.reportViewer1);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
