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
    public partial class FrmReportetopcliente : Form
    {
        public FrmReportetopcliente()
        {
            InitializeComponent();
        }

        private void FrmReportetopcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDFacturaDataSet.Sp_Listado_Cliente_Top5' Puede moverla o quitarla según sea necesario.
            this.sp_Listado_Cliente_Top5TableAdapter.Fill(this.dSTop5clientes.Sp_Listado_Cliente_Top5);

            this.reportViewer1.RefreshReport();
        }
    }
}
