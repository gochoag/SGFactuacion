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
        public FrmReporteproducto()
        {
            InitializeComponent();
        }

        private void FrmReporteproducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturaDataSet.sp_rep_Productos_Vendidos_Top5' Puede moverla o quitarla según sea necesario.
            this.sp_rep_Productos_Vendidos_Top5TableAdapter.Fill(this.dSProductoVendido.sp_rep_Productos_Vendidos_Top5);
            this.reportViewer1.RefreshReport();
        }
    }
}
