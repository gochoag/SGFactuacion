namespace SGFactuacion.Formularios
{
    partial class FrmReporteproducto
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
            this.sprepProductosVendidosTop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSProductoVendido = new SGFactuacion.BDFacturaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_rep_Productos_Vendidos_Top5TableAdapter = new SGFactuacion.BDFacturaDataSetTableAdapters.sp_rep_Productos_Vendidos_Top5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sprepProductosVendidosTop5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductoVendido)).BeginInit();
            this.SuspendLayout();
            // 
            // sprepProductosVendidosTop5BindingSource
            // 
            this.sprepProductosVendidosTop5BindingSource.DataMember = "sp_rep_Productos_Vendidos_Top5";
            this.sprepProductosVendidosTop5BindingSource.DataSource = this.dSProductoVendido;
            // 
            // dSProductoVendido
            // 
            this.dSProductoVendido.DataSetName = "dSProductoVendido";
            this.dSProductoVendido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sprepProductosVendidosTop5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_Productovendidordlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(844, 430);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_rep_Productos_Vendidos_Top5TableAdapter
            // 
            this.sp_rep_Productos_Vendidos_Top5TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 430);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmReporteproducto";
            this.Text = "FrmReporteproducto";
            this.Load += new System.EventHandler(this.FrmReporteproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sprepProductosVendidosTop5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductoVendido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDFacturaDataSet dSProductoVendido;
        private System.Windows.Forms.BindingSource sprepProductosVendidosTop5BindingSource;
        private BDFacturaDataSetTableAdapters.sp_rep_Productos_Vendidos_Top5TableAdapter sp_rep_Productos_Vendidos_Top5TableAdapter;
    }
}