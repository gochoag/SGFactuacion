﻿namespace SGFactuacion.Formularios
{
    partial class FrmReportetopcliente
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
            this.dSTop5clientes = new SGFactuacion.BDFacturaDataSet();
            this.spListadoClienteTop5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Listado_Cliente_Top5TableAdapter = new SGFactuacion.BDFacturaDataSetTableAdapters.Sp_Listado_Cliente_Top5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSTop5clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoClienteTop5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListadoClienteTop5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_Top5cliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(633, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSTop5clientes
            // 
            this.dSTop5clientes.DataSetName = "dSTop5clientes";
            this.dSTop5clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListadoClienteTop5BindingSource
            // 
            this.spListadoClienteTop5BindingSource.DataMember = "Sp_Listado_Cliente_Top5";
            this.spListadoClienteTop5BindingSource.DataSource = this.dSTop5clientes;
            // 
            // sp_Listado_Cliente_Top5TableAdapter
            // 
            this.sp_Listado_Cliente_Top5TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportetopcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 349);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportetopcliente";
            this.Text = "FrmReportetopcliente";
            this.Load += new System.EventHandler(this.FrmReportetopcliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTop5clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadoClienteTop5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDFacturaDataSet dSTop5clientes;
        private System.Windows.Forms.BindingSource spListadoClienteTop5BindingSource;
        private BDFacturaDataSetTableAdapters.Sp_Listado_Cliente_Top5TableAdapter sp_Listado_Cliente_Top5TableAdapter;
    }
}