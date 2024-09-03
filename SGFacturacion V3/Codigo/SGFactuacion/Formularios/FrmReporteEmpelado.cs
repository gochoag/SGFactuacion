﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGFactuacion.Clases;

namespace SGFactuacion.Formularios
{
    public partial class FrmReporteEmpelado : Form
    {
        

        public FrmReporteEmpelado()
        {
            InitializeComponent();
           
        }


        public void GenerarReporte(long id)
        {
            csEmpleados emp = new csEmpleados();
            try
            {
               
                emp.CargarReportesp_Sp_Venta_Empleado(this.reportViewer1,id);
                // Asume que tienes un TableAdapter configurado para el dataset correspondiente
                //this.sp_Venta_EmpleadoTableAdapter.Fill(this.dSVentaempleado.Sp_Venta_Empleado, id);

               
               // reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReporteEmpelado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
