﻿namespace SGFactuacion.Formularios
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSProductoVendido = new SGFactuacion.BDFacturaDataSet();
            this.sprepProductosVendidosTop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rep_Productos_Vendidos_Top5TableAdapter = new SGFactuacion.BDFacturaDataSetTableAdapters.sp_rep_Productos_Vendidos_Top5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSProductoVendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprepProductosVendidosTop5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sprepProductosVendidosTop5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_Productovendidordlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSProductoVendido
            // 
            this.dSProductoVendido.DataSetName = "dSProductoVendido";
            this.dSProductoVendido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprepProductosVendidosTop5BindingSource
            // 
            this.sprepProductosVendidosTop5BindingSource.DataMember = "sp_rep_Productos_Vendidos_Top5";
            this.sprepProductosVendidosTop5BindingSource.DataSource = this.dSProductoVendido;
            // 
            // sp_rep_Productos_Vendidos_Top5TableAdapter
            // 
            this.sp_rep_Productos_Vendidos_Top5TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 349);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteproducto";
            this.Text = "FrmReporteproducto";
            this.Load += new System.EventHandler(this.FrmReporteproducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSProductoVendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprepProductosVendidosTop5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDFacturaDataSet dSProductoVendido;
        private System.Windows.Forms.BindingSource sprepProductosVendidosTop5BindingSource;
        private BDFacturaDataSetTableAdapters.sp_rep_Productos_Vendidos_Top5TableAdapter sp_rep_Productos_Vendidos_Top5TableAdapter;
    }
}