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
            
            lblDatos.Text = string.Empty; 
            txtNum.Visible = false;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al seleccionar los tipos de reporte {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                GenerarReporte(long.Parse(txtNum.Text));
            }
        }
        public void GenerarReporte(long id)
        {
            try
            {
                
                this.sp_GetFacturaDetallesTableAdapter.Fill(this.dSFacturadetalle.sp_GetFacturaDetalles, id);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
