namespace SGFactuacion.Formularios
{
    partial class FrmReporteFacturalistado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSTop5Factura = new SGFactuacion.BDFacturaDataSet();
            this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter = new SGFactuacion.BDFacturaDataSetTableAdapters.sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSTop5Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.Rp_Top5factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSTop5Factura
            // 
            this.dSTop5Factura.DataSetName = "dSTop5Factura";
            this.dSTop5Factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprepListadoFacturaMayorCantidadProductosTop5BindingSource
            // 
            this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource.DataMember = "sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5";
            this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource.DataSource = this.dSTop5Factura;
            // 
            // sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter
            // 
            this.sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteFacturalistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 349);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteFacturalistado";
            this.Text = "FrmReporteFacturalistado";
            this.Load += new System.EventHandler(this.FrmReporteFacturalistado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTop5Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprepListadoFacturaMayorCantidadProductosTop5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDFacturaDataSet dSTop5Factura;
        private System.Windows.Forms.BindingSource sprepListadoFacturaMayorCantidadProductosTop5BindingSource;
        private BDFacturaDataSetTableAdapters.sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5TableAdapter;
    }
}