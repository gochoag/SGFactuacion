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
    public partial class FrmRegistrarProveer : Form
    {
        public FrmRegistrarProveer()
        {
            InitializeComponent();
            txtRuc.KeyPress += txtRuc_KeyPress;
            txtTelf.KeyPress += txtTelf_KeyPress;
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtRuc.Text.Length >= 13)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void FrmRegistrarProveer_Load(object sender, EventArgs e)
        {

        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtTelf.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }
    }
}
