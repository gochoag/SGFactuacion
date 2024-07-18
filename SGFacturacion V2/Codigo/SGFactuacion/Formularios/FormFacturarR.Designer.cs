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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturarR));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.PnDiseñoF = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatosBuscados = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnCerrarDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.PnDiseñoF.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBuscados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(229, 5);
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
            this.label5.Location = new System.Drawing.Point(315, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Buscar producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad:";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.AllowUserToResizeColumns = false;
            this.dgvListaProductos.AllowUserToResizeRows = false;
            this.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProductos.EnableHeadersVisualStyles = false;
            this.dgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvListaProductos.Location = new System.Drawing.Point(12, 272);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProductos.RowHeadersWidth = 51;
            this.dgvListaProductos.Size = new System.Drawing.Size(593, 155);
            this.dgvListaProductos.TabIndex = 11;
            this.dgvListaProductos.DataSourceChanged += new System.EventHandler(this.dgvListaProductos_DataSourceChanged);
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio:";
            // 
            // BTNRegistrarFactura
            // 
            this.BTNRegistrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTNRegistrarFactura.Enabled = false;
            this.BTNRegistrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNRegistrarFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegistrarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRegistrarFactura.Location = new System.Drawing.Point(221, 442);
            this.BTNRegistrarFactura.Name = "BTNRegistrarFactura";
            this.BTNRegistrarFactura.Size = new System.Drawing.Size(170, 33);
            this.BTNRegistrarFactura.TabIndex = 13;
            this.BTNRegistrarFactura.Text = "Realizar factura";
            this.BTNRegistrarFactura.UseVisualStyleBackColor = false;
            this.BTNRegistrarFactura.Click += new System.EventHandler(this.BTNRegistrarFactura_Click);
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
            this.btnAgregarProductoToDGV.Click += new System.EventHandler(this.btnAgregarProductoToDGV_Click);
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
            this.btnQuitarProductoToDGV.Click += new System.EventHandler(this.btnQuitarProductoToDGV_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(95, 190);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(89, 20);
            this.txtCantidad.TabIndex = 16;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(92, 106);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNombreCliente.TabIndex = 17;
            this.lblNombreCliente.TextChanged += new System.EventHandler(this.lblNombreCliente_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Stock:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(92, 149);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 17);
            this.lblNombreProducto.TabIndex = 19;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(375, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 17);
            this.lblPrecio.TabIndex = 20;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(518, 149);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 17);
            this.lblStock.TabIndex = 21;
            // 
            // PnDiseñoF
            // 
            this.PnDiseñoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.PnDiseñoF.Controls.Add(this.label1);
            this.PnDiseñoF.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDiseñoF.Location = new System.Drawing.Point(0, 0);
            this.PnDiseñoF.Margin = new System.Windows.Forms.Padding(0);
            this.PnDiseñoF.Name = "PnDiseñoF";
            this.PnDiseñoF.Size = new System.Drawing.Size(682, 37);
            this.PnDiseñoF.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(319, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(378, 190);
            this.txtIVA.MaxLength = 2;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(46, 20);
            this.txtIVA.TabIndex = 24;
            this.txtIVA.Text = "15";
            this.txtIVA.Enter += new System.EventHandler(this.txtIVA_Enter);
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            this.txtIVA.Leave += new System.EventHandler(this.txtIVA_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatosBuscados);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 132);
            this.panel1.TabIndex = 25;
            this.panel1.Visible = false;
            // 
            // dgvDatosBuscados
            // 
            this.dgvDatosBuscados.AllowUserToAddRows = false;
            this.dgvDatosBuscados.AllowUserToDeleteRows = false;
            this.dgvDatosBuscados.AllowUserToResizeColumns = false;
            this.dgvDatosBuscados.AllowUserToResizeRows = false;
            this.dgvDatosBuscados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosBuscados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatosBuscados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosBuscados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosBuscados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosBuscados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosBuscados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosBuscados.EnableHeadersVisualStyles = false;
            this.dgvDatosBuscados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvDatosBuscados.Location = new System.Drawing.Point(0, 0);
            this.dgvDatosBuscados.Name = "dgvDatosBuscados";
            this.dgvDatosBuscados.ReadOnly = true;
            this.dgvDatosBuscados.RowHeadersVisible = false;
            this.dgvDatosBuscados.RowHeadersWidth = 51;
            this.dgvDatosBuscados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosBuscados.Size = new System.Drawing.Size(609, 132);
            this.dgvDatosBuscados.TabIndex = 0;
            this.dgvDatosBuscados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosBuscados_CellContentClick);
            this.dgvDatosBuscados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosBuscados_CellDoubleClick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(112, 57);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(197, 20);
            this.txtBuscarCliente.TabIndex = 26;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            this.txtBuscarCliente.Enter += new System.EventHandler(this.txtBuscarCliente_Enter);
            this.txtBuscarCliente.Leave += new System.EventHandler(this.txtBuscarCliente_Leave);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Enabled = false;
            this.txtBuscarProducto.Location = new System.Drawing.Point(432, 60);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(141, 20);
            this.txtBuscarProducto.TabIndex = 27;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscaarProducto_TextChanged);
            this.txtBuscarProducto.Enter += new System.EventHandler(this.txtBuscaarProducto_Enter);
            this.txtBuscarProducto.Leave += new System.EventHandler(this.txtBuscaarProducto_Leave);
            // 
            // btnCerrarDGV
            // 
            this.btnCerrarDGV.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarDGV.Enabled = false;
            this.btnCerrarDGV.FlatAppearance.BorderSize = 0;
            this.btnCerrarDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarDGV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDGV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarDGV.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarDGV.Image")));
            this.btnCerrarDGV.Location = new System.Drawing.Point(586, 54);
            this.btnCerrarDGV.Name = "btnCerrarDGV";
            this.btnCerrarDGV.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarDGV.TabIndex = 28;
            this.btnCerrarDGV.UseVisualStyleBackColor = false;
            this.btnCerrarDGV.Click += new System.EventHandler(this.btnCerrarDGV_Click);
            // 
            // FormFacturarR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 502);
            this.Controls.Add(this.btnCerrarDGV);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PnDiseñoF);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFacturarR";
            this.Text = "FormFacturarR";
            this.Activated += new System.EventHandler(this.FormFacturarR_Activated);
            this.Load += new System.EventHandler(this.FormFacturarR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.PnDiseñoF.ResumeLayout(false);
            this.PnDiseñoF.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosBuscados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Panel PnDiseñoF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatosBuscados;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnCerrarDGV;
    }
}