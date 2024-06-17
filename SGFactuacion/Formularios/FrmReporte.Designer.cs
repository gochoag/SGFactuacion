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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            this.sp_GetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFacturadetalle = new SGFactuacion.DataSets.DSFacturadetalle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetFacturaDetallesTableAdapter = new SGFactuacion.DataSets.DSFacturadetalleTableAdapters.sp_GetFacturaDetallesTableAdapter();
            this.cbData1 = new System.Windows.Forms.ComboBox();
            this.lblDatos2 = new System.Windows.Forms.Label();
            this.cbData2 = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.cbData2);
            this.panel1.Controls.Add(this.lblDatos2);
            this.panel1.Controls.Add(this.cbData1);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbTipoReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDatos.Location = new System.Drawing.Point(11, 52);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(55, 17);
            this.lblDatos.TabIndex = 13;
            this.lblDatos.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reporte:";
            // 
            // cbTipoReporte
            // 
            this.cbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoReporte.FormattingEnabled = true;
            this.cbTipoReporte.Items.AddRange(new object[] {
            "Detalle de factura"});
            this.cbTipoReporte.Location = new System.Drawing.Point(77, 19);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(194, 21);
            this.cbTipoReporte.TabIndex = 0;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 371);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DSFacturaDetails";
            reportDataSource3.Value = this.sp_GetFacturaDetallesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_FacturaDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 371);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
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
            // cbData1
            // 
            this.cbData1.Enabled = false;
            this.cbData1.FormattingEnabled = true;
            this.cbData1.Location = new System.Drawing.Point(77, 52);
            this.cbData1.Name = "cbData1";
            this.cbData1.Size = new System.Drawing.Size(194, 21);
            this.cbData1.TabIndex = 14;
            this.cbData1.SelectedIndexChanged += new System.EventHandler(this.cbData1_SelectedIndexChanged);
            // 
            // lblDatos2
            // 
            this.lblDatos2.AutoSize = true;
            this.lblDatos2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos2.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDatos2.Location = new System.Drawing.Point(277, 22);
            this.lblDatos2.Name = "lblDatos2";
            this.lblDatos2.Size = new System.Drawing.Size(47, 17);
            this.lblDatos2.TabIndex = 15;
            this.lblDatos2.Text = "Fecha:";
            // 
            // cbData2
            // 
            this.cbData2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData2.Enabled = false;
            this.cbData2.FormattingEnabled = true;
            this.cbData2.Location = new System.Drawing.Point(330, 22);
            this.cbData2.Name = "cbData2";
            this.cbData2.Size = new System.Drawing.Size(176, 21);
            this.cbData2.TabIndex = 16;
            this.cbData2.SelectedIndexChanged += new System.EventHandler(this.cbData2_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(558, 22);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(41, 37);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
        private System.Windows.Forms.ComboBox cbTipoReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_GetFacturaDetallesBindingSource;
        private DataSets.DSFacturadetalle dSFacturadetalle;
        private System.Windows.Forms.BindingSource spGetFacturaDetallesBindingSource;
        private DataSets.DSFacturadetalleTableAdapters.sp_GetFacturaDetallesTableAdapter sp_GetFacturaDetallesTableAdapter;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbData2;
        private System.Windows.Forms.Label lblDatos2;
        private System.Windows.Forms.ComboBox cbData1;
    }
}