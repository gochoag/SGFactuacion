namespace SGFactuacion
{
    partial class FormFacturarR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturarR));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBuscarProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNRegistrarFactura = new System.Windows.Forms.Button();
            this.btnAgregarProductoToDGV = new System.Windows.Forms.Button();
            this.btnQuitarProductoToDGV = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrar Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar cliente:";
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.Location = new System.Drawing.Point(127, 60);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(197, 21);
            this.cbBuscarCliente.TabIndex = 5;
            this.cbBuscarCliente.SelectedIndexChanged += new System.EventHandler(this.cbBuscarCliente_SelectedIndexChanged);
            this.cbBuscarCliente.TextChanged += new System.EventHandler(this.cbBuscarCliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista de productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Buscar producto:";
            // 
            // cbBuscarProducto
            // 
            this.cbBuscarProducto.FormattingEnabled = true;
            this.cbBuscarProducto.Location = new System.Drawing.Point(127, 152);
            this.cbBuscarProducto.Name = "cbBuscarProducto";
            this.cbBuscarProducto.Size = new System.Drawing.Size(197, 21);
            this.cbBuscarProducto.TabIndex = 8;
            this.cbBuscarProducto.SelectedIndexChanged += new System.EventHandler(this.cbBuscarProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad:";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(12, 274);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.Size = new System.Drawing.Size(604, 155);
            this.dgvListaProductos.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio:";
            // 
            // BTNRegistrarFactura
            // 
            this.BTNRegistrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTNRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNRegistrarFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegistrarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRegistrarFactura.Location = new System.Drawing.Point(221, 442);
            this.BTNRegistrarFactura.Name = "BTNRegistrarFactura";
            this.BTNRegistrarFactura.Size = new System.Drawing.Size(170, 33);
            this.BTNRegistrarFactura.TabIndex = 13;
            this.BTNRegistrarFactura.Text = "Realizar factura";
            this.BTNRegistrarFactura.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProductoToDGV
            // 
            this.btnAgregarProductoToDGV.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProductoToDGV.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductoToDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductoToDGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductoToDGV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProductoToDGV.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductoToDGV.Image")));
            this.btnAgregarProductoToDGV.Location = new System.Drawing.Point(570, 233);
            this.btnAgregarProductoToDGV.Name = "btnAgregarProductoToDGV";
            this.btnAgregarProductoToDGV.Size = new System.Drawing.Size(35, 35);
            this.btnAgregarProductoToDGV.TabIndex = 14;
            this.btnAgregarProductoToDGV.UseVisualStyleBackColor = false;
            // 
            // btnQuitarProductoToDGV
            // 
            this.btnQuitarProductoToDGV.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarProductoToDGV.FlatAppearance.BorderSize = 0;
            this.btnQuitarProductoToDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProductoToDGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductoToDGV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitarProductoToDGV.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarProductoToDGV.Image")));
            this.btnQuitarProductoToDGV.Location = new System.Drawing.Point(529, 233);
            this.btnQuitarProductoToDGV.Name = "btnQuitarProductoToDGV";
            this.btnQuitarProductoToDGV.Size = new System.Drawing.Size(35, 35);
            this.btnQuitarProductoToDGV.TabIndex = 15;
            this.btnQuitarProductoToDGV.UseVisualStyleBackColor = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(414, 153);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(89, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(124, 106);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNombreCliente.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Stock:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(92, 198);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 17);
            this.lblNombreProducto.TabIndex = 19;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(375, 198);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 17);
            this.lblPrecio.TabIndex = 20;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(518, 198);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 17);
            this.lblStock.TabIndex = 21;
            // 
            // FormFacturarR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 484);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnQuitarProductoToDGV);
            this.Controls.Add(this.btnAgregarProductoToDGV);
            this.Controls.Add(this.BTNRegistrarFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvListaProductos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBuscarProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBuscarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturarR";
            this.Text = "FormFacturarR";
            this.Activated += new System.EventHandler(this.FormFacturarR_Activated);
            this.Load += new System.EventHandler(this.FormFacturarR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTNRegistrarFactura;
        private System.Windows.Forms.Button btnAgregarProductoToDGV;
        private System.Windows.Forms.Button btnQuitarProductoToDGV;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
    }
}