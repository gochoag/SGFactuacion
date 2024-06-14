namespace SGFactuacion
{
    partial class FrmReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_GetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFacturadetalle = new SGFactuacion.DataSets.DSFacturadetalle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetFacturaDetallesTableAdapter = new SGFactuacion.DataSets.DSFacturadetalleTableAdapters.sp_GetFacturaDetallesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetFacturaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturadetalle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGetFacturaDetallesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_GetFacturaDetallesBindingSource
            // 
            this.sp_GetFacturaDetallesBindingSource.DataMember = "sp_GetFacturaDetalles";
            this.sp_GetFacturaDetallesBindingSource.DataSource = this.dSFacturadetalle;
            // 
            // dSFacturadetalle
            // 
            this.dSFacturadetalle.DataSetName = "DSFacturadetalle";
            this.dSFacturadetalle.EnforceConstraints = false;
            this.dSFacturadetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbTipoReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDatos.Location = new System.Drawing.Point(341, 20);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 17);
            this.lblDatos.TabIndex = 13;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(471, 20);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 12;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de reporte:";
            // 
            // cbTipoReporte
            // 
            this.cbTipoReporte.FormattingEnabled = true;
            this.cbTipoReporte.Items.AddRange(new object[] {
            "Detalle de factura",
            "Clientes",
            "Productos"});
            this.cbTipoReporte.Location = new System.Drawing.Point(125, 19);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(171, 21);
            this.cbTipoReporte.TabIndex = 0;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 396);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSFacturaDetails";
            reportDataSource2.Value = this.sp_GetFacturaDetallesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_FacturaDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // spGetFacturaDetallesBindingSource
            // 
            this.spGetFacturaDetallesBindingSource.DataMember = "sp_GetFacturaDetalles";
            this.spGetFacturaDetallesBindingSource.DataSource = this.dSFacturadetalle;
            // 
            // sp_GetFacturaDetallesTableAdapter
            // 
            this.sp_GetFacturaDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporte";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetFacturaDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturadetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spGetFacturaDetallesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipoReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtNum;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_GetFacturaDetallesBindingSource;
        private DataSets.DSFacturadetalle dSFacturadetalle;
        private System.Windows.Forms.BindingSource spGetFacturaDetallesBindingSource;
        private DataSets.DSFacturadetalleTableAdapters.sp_GetFacturaDetallesTableAdapter sp_GetFacturaDetallesTableAdapter;
    }
}