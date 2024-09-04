using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
    public partial class FrmEditarProvee : Form
    {
        public FrmEditarProvee()
        {
            InitializeComponent();
            txtRUCE.KeyPress += txtRUCE_KeyPress;
            txtTelfE.KeyPress += txtTelfE_KeyPress;
        }

        private void txtRUCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtRUCE.Text.Length >= 13)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void txtTelfE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtTelfE.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }
    }
}
