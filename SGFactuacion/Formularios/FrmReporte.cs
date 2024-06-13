using Microsoft.Reporting.WinForms;
using SGFactuacion.DataSets;
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
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSFacturadetalle.sp_GetFacturaDetalles' Puede moverla o quitarla según sea necesario.
            
            lblDatos.Text = string.Empty; 
            txtNum.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTipoReporte.SelectedItem.ToString())
            {
                case "Detalle de factura":
                    lblDatos.Text = "Nº Factura";
                    txtNum.Visible = true;
                    break;
                case "Clientes":
                    lblDatos.Text = "ID Cliente";
                    txtNum.Visible = true;
                    break;
                case "Productos":
                    lblDatos.Text = "ID Producto";
                    txtNum.Visible = true;
                    break;
                default:
                    lblDatos.Text = string.Empty;
                    txtNum.Visible = false;
                    break;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNum.Text))
            {
                GenerarReporte(txtNum.Text);
            }
        }
        private void GenerarReporte(string valorParametro)
        {
            int id;
            id = int.Parse(txtNum.Text);
            this.sp_GetFacturaDetallesTableAdapter.Fill(this.dSFacturadetalle.sp_GetFacturaDetalles, id);
            
            this.reportViewer1.RefreshReport();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
