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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporte));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_GetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFacturadetalle = new SGFactuacion.DataSets.DSFacturadetalle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarDGV = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgvDatosBuscados = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbData2 = new System.Windows.Forms.ComboBox();
            this.lblDatos2 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spGetFacturaDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetFacturaDetallesTableAdapter = new SGFactuacion.DataSets.DSFacturadetalleTableAdapters.sp_GetFacturaDetallesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetFacturaDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturadetalle)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBuscados)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrarDGV);
            this.panel1.Controls.Add(this.txtBuscarCliente);
            this.panel1.Controls.Add(this.dgvDatosBuscados);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.cbData2);
            this.panel1.Controls.Add(this.lblDatos2);
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbTipoReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 155);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscar Cliente:";
            // 
            // btnCerrarDGV
            // 
            this.btnCerrarDGV.Location = new System.Drawing.Point(310, 164);
            this.btnCerrarDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarDGV.Name = "btnCerrarDGV";
            this.btnCerrarDGV.Size = new System.Drawing.Size(56, 19);
            this.btnCerrarDGV.TabIndex = 28;
            this.btnCerrarDGV.Text = "button1";
            this.btnCerrarDGV.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(113, 54);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(197, 20);
            this.txtBuscarCliente.TabIndex = 27;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            // 
            // dgvDatosBuscados
            // 
            this.dgvDatosBuscados.AllowUserToAddRows = false;
            this.dgvDatosBuscados.AllowUserToDeleteRows = false;
            this.dgvDatosBuscados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosBuscados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDatosBuscados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosBuscados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosBuscados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosBuscados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosBuscados.EnableHeadersVisualStyles = false;
            this.dgvDatosBuscados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvDatosBuscados.Location = new System.Drawing.Point(312, 11);
            this.dgvDatosBuscados.Name = "dgvDatosBuscados";
            this.dgvDatosBuscados.ReadOnly = true;
            this.dgvDatosBuscados.RowHeadersVisible = false;
            this.dgvDatosBuscados.RowHeadersWidth = 51;
            this.dgvDatosBuscados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosBuscados.Size = new System.Drawing.Size(397, 134);
            this.dgvDatosBuscados.TabIndex = 18;
            this.dgvDatosBuscados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosBuscados_CellContentClick);
            this.dgvDatosBuscados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosBuscados_CellContentDoubleClick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(325, 11);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(41, 37);
            this.btnGenerar.TabIndex = 17;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbData2
            // 
            this.cbData2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData2.Enabled = false;
            this.cbData2.FormattingEnabled = true;
            this.cbData2.Location = new System.Drawing.Point(113, 118);
            this.cbData2.Name = "cbData2";
            this.cbData2.Size = new System.Drawing.Size(176, 21);
            this.cbData2.TabIndex = 16;
            this.cbData2.SelectedIndexChanged += new System.EventHandler(this.cbData2_SelectedIndexChanged);
            // 
            // lblDatos2
            // 
            this.lblDatos2.AutoSize = true;
            this.lblDatos2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDatos2.Location = new System.Drawing.Point(13, 117);
            this.lblDatos2.Name = "lblDatos2";
            this.lblDatos2.Size = new System.Drawing.Size(47, 17);
            this.lblDatos2.TabIndex = 15;
            this.lblDatos2.Text = "Fecha:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDatos.Location = new System.Drawing.Point(11, 84);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(55, 17);
            this.lblDatos.TabIndex = 13;
            this.lblDatos.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.cbTipoReporte.Location = new System.Drawing.Point(113, 20);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(194, 21);
            this.cbTipoReporte.TabIndex = 0;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 293);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSFacturaDetails";
            reportDataSource1.Value = this.sp_GetFacturaDetallesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SGFactuacion.Reportes.RP_FacturaDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(712, 293);
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
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporte";
            this.Load += new System.EventHandler(this.FrmReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetFacturaDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturadetalle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBuscados)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDatosBuscados;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnCerrarDGV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}