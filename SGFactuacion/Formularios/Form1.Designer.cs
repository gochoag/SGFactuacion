namespace SGFactuacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Barra_Arriba = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.SGFacturacion = new System.Windows.Forms.Label();
            this.Imagelateral = new System.Windows.Forms.PictureBox();
            this.Panelmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Flowcliente = new System.Windows.Forms.FlowLayoutPanel();
            this.Panelcliente = new System.Windows.Forms.Panel();
            this.Bcliente = new System.Windows.Forms.Button();
            this.Panelregistrar = new System.Windows.Forms.Panel();
            this.BregistarC = new System.Windows.Forms.Button();
            this.Paneleditar = new System.Windows.Forms.Panel();
            this.BEditarC = new System.Windows.Forms.Button();
            this.Panellistar = new System.Windows.Forms.Panel();
            this.BlistarC = new System.Windows.Forms.Button();
            this.FlowProducto = new System.Windows.Forms.FlowLayoutPanel();
            this.Panelproducto = new System.Windows.Forms.Panel();
            this.Bproducto = new System.Windows.Forms.Button();
            this.Panelregistrarp = new System.Windows.Forms.Panel();
            this.BregistrarP = new System.Windows.Forms.Button();
            this.PaneleditarP = new System.Windows.Forms.Panel();
            this.BeditarP = new System.Windows.Forms.Button();
            this.PanellistarP = new System.Windows.Forms.Panel();
            this.BlistarP = new System.Windows.Forms.Button();
            this.PanelFactura = new System.Windows.Forms.Panel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.Menutransacion = new System.Windows.Forms.Timer(this.components);
            this.MenuTrP = new System.Windows.Forms.Timer(this.components);
            this.SidbarTr = new System.Windows.Forms.Timer(this.components);
            this.btnReportes = new System.Windows.Forms.Button();
            this.Barra_Arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagelateral)).BeginInit();
            this.Panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Flowcliente.SuspendLayout();
            this.Panelcliente.SuspendLayout();
            this.Panelregistrar.SuspendLayout();
            this.Paneleditar.SuspendLayout();
            this.Panellistar.SuspendLayout();
            this.FlowProducto.SuspendLayout();
            this.Panelproducto.SuspendLayout();
            this.Panelregistrarp.SuspendLayout();
            this.PaneleditarP.SuspendLayout();
            this.PanellistarP.SuspendLayout();
            this.PanelFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra_Arriba
            // 
            this.Barra_Arriba.BackColor = System.Drawing.Color.White;
            this.Barra_Arriba.Controls.Add(this.Close);
            this.Barra_Arriba.Controls.Add(this.SGFacturacion);
            this.Barra_Arriba.Controls.Add(this.Imagelateral);
            this.Barra_Arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Arriba.Location = new System.Drawing.Point(0, 0);
            this.Barra_Arriba.Name = "Barra_Arriba";
            this.Barra_Arriba.Size = new System.Drawing.Size(838, 34);
            this.Barra_Arriba.TabIndex = 0;
            // 
            // Close
            // 
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(798, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 24);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SGFacturacion
            // 
            this.SGFacturacion.AutoSize = true;
            this.SGFacturacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGFacturacion.Location = new System.Drawing.Point(68, 6);
            this.SGFacturacion.Name = "SGFacturacion";
            this.SGFacturacion.Size = new System.Drawing.Size(119, 21);
            this.SGFacturacion.TabIndex = 1;
            this.SGFacturacion.Text = "SGFacturacion";
            // 
            // Imagelateral
            // 
            this.Imagelateral.Image = ((System.Drawing.Image)(resources.GetObject("Imagelateral.Image")));
            this.Imagelateral.Location = new System.Drawing.Point(5, 3);
            this.Imagelateral.Name = "Imagelateral";
            this.Imagelateral.Size = new System.Drawing.Size(39, 28);
            this.Imagelateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Imagelateral.TabIndex = 1;
            this.Imagelateral.TabStop = false;
            this.Imagelateral.Click += new System.EventHandler(this.Imagelateral_Click);
            // 
            // Panelmenu
            // 
            this.Panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Panelmenu.Controls.Add(this.panel1);
            this.Panelmenu.Controls.Add(this.Flowcliente);
            this.Panelmenu.Controls.Add(this.FlowProducto);
            this.Panelmenu.Controls.Add(this.PanelFactura);
            this.Panelmenu.Controls.Add(this.btnReportes);
            this.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelmenu.Location = new System.Drawing.Point(0, 34);
            this.Panelmenu.Name = "Panelmenu";
            this.Panelmenu.Size = new System.Drawing.Size(205, 502);
            this.Panelmenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Flowcliente
            // 
            this.Flowcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.Flowcliente.Controls.Add(this.Panelcliente);
            this.Flowcliente.Controls.Add(this.Panelregistrar);
            this.Flowcliente.Controls.Add(this.Paneleditar);
            this.Flowcliente.Controls.Add(this.Panellistar);
            this.Flowcliente.Location = new System.Drawing.Point(3, 109);
            this.Flowcliente.Name = "Flowcliente";
            this.Flowcliente.Size = new System.Drawing.Size(200, 37);
            this.Flowcliente.TabIndex = 5;
            // 
            // Panelcliente
            // 
            this.Panelcliente.Controls.Add(this.Bcliente);
            this.Panelcliente.Location = new System.Drawing.Point(3, 3);
            this.Panelcliente.Name = "Panelcliente";
            this.Panelcliente.Size = new System.Drawing.Size(200, 37);
            this.Panelcliente.TabIndex = 3;
            // 
            // Bcliente
            // 
            this.Bcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.Bcliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bcliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcliente.ForeColor = System.Drawing.Color.Transparent;
            this.Bcliente.Image = ((System.Drawing.Image)(resources.GetObject("Bcliente.Image")));
            this.Bcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcliente.Location = new System.Drawing.Point(-5, -2);
            this.Bcliente.Name = "Bcliente";
            this.Bcliente.Size = new System.Drawing.Size(213, 44);
            this.Bcliente.TabIndex = 2;
            this.Bcliente.Text = "Cliente ";
            this.Bcliente.UseVisualStyleBackColor = false;
            this.Bcliente.Click += new System.EventHandler(this.Bcliente_Click);
            // 
            // Panelregistrar
            // 
            this.Panelregistrar.Controls.Add(this.BregistarC);
            this.Panelregistrar.Location = new System.Drawing.Point(3, 46);
            this.Panelregistrar.Name = "Panelregistrar";
            this.Panelregistrar.Size = new System.Drawing.Size(200, 37);
            this.Panelregistrar.TabIndex = 4;
            // 
            // BregistarC
            // 
            this.BregistarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BregistarC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BregistarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BregistarC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BregistarC.ForeColor = System.Drawing.Color.Transparent;
            this.BregistarC.Image = ((System.Drawing.Image)(resources.GetObject("BregistarC.Image")));
            this.BregistarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BregistarC.Location = new System.Drawing.Point(-2, -2);
            this.BregistarC.Name = "BregistarC";
            this.BregistarC.Size = new System.Drawing.Size(212, 44);
            this.BregistarC.TabIndex = 2;
            this.BregistarC.Text = "                 Registrar";
            this.BregistarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BregistarC.UseVisualStyleBackColor = false;
            this.BregistarC.Click += new System.EventHandler(this.BregistarC_Click);
            // 
            // Paneleditar
            // 
            this.Paneleditar.Controls.Add(this.BEditarC);
            this.Paneleditar.Location = new System.Drawing.Point(3, 89);
            this.Paneleditar.Name = "Paneleditar";
            this.Paneleditar.Size = new System.Drawing.Size(200, 37);
            this.Paneleditar.TabIndex = 5;
            // 
            // BEditarC
            // 
            this.BEditarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BEditarC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BEditarC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEditarC.ForeColor = System.Drawing.Color.Transparent;
            this.BEditarC.Image = ((System.Drawing.Image)(resources.GetObject("BEditarC.Image")));
            this.BEditarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarC.Location = new System.Drawing.Point(-2, -2);
            this.BEditarC.Name = "BEditarC";
            this.BEditarC.Size = new System.Drawing.Size(212, 44);
            this.BEditarC.TabIndex = 2;
            this.BEditarC.Text = "                 Editar";
            this.BEditarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEditarC.UseVisualStyleBackColor = false;
            this.BEditarC.Click += new System.EventHandler(this.BEditarC_Click);
            // 
            // Panellistar
            // 
            this.Panellistar.Controls.Add(this.BlistarC);
            this.Panellistar.Location = new System.Drawing.Point(3, 132);
            this.Panellistar.Name = "Panellistar";
            this.Panellistar.Size = new System.Drawing.Size(200, 37);
            this.Panellistar.TabIndex = 6;
            // 
            // BlistarC
            // 
            this.BlistarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BlistarC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BlistarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlistarC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarC.ForeColor = System.Drawing.Color.Transparent;
            this.BlistarC.Image = ((System.Drawing.Image)(resources.GetObject("BlistarC.Image")));
            this.BlistarC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlistarC.Location = new System.Drawing.Point(-2, -2);
            this.BlistarC.Name = "BlistarC";
            this.BlistarC.Size = new System.Drawing.Size(212, 44);
            this.BlistarC.TabIndex = 2;
            this.BlistarC.Text = "                 Listar";
            this.BlistarC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlistarC.UseVisualStyleBackColor = false;
            this.BlistarC.Click += new System.EventHandler(this.BlistarC_Click);
            // 
            // FlowProducto
            // 
            this.FlowProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.FlowProducto.Controls.Add(this.Panelproducto);
            this.FlowProducto.Controls.Add(this.Panelregistrarp);
            this.FlowProducto.Controls.Add(this.PaneleditarP);
            this.FlowProducto.Controls.Add(this.PanellistarP);
            this.FlowProducto.Location = new System.Drawing.Point(3, 152);
            this.FlowProducto.Name = "FlowProducto";
            this.FlowProducto.Size = new System.Drawing.Size(200, 37);
            this.FlowProducto.TabIndex = 5;
            // 
            // Panelproducto
            // 
            this.Panelproducto.Controls.Add(this.Bproducto);
            this.Panelproducto.Location = new System.Drawing.Point(3, 3);
            this.Panelproducto.Name = "Panelproducto";
            this.Panelproducto.Size = new System.Drawing.Size(200, 42);
            this.Panelproducto.TabIndex = 4;
            // 
            // Bproducto
            // 
            this.Bproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Bproducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bproducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bproducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bproducto.ForeColor = System.Drawing.Color.Transparent;
            this.Bproducto.Image = ((System.Drawing.Image)(resources.GetObject("Bproducto.Image")));
            this.Bproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bproducto.Location = new System.Drawing.Point(-6, -2);
            this.Bproducto.Name = "Bproducto";
            this.Bproducto.Size = new System.Drawing.Size(212, 44);
            this.Bproducto.TabIndex = 2;
            this.Bproducto.Text = "Producto ";
            this.Bproducto.UseVisualStyleBackColor = false;
            this.Bproducto.Click += new System.EventHandler(this.Bproducto_Click);
            // 
            // Panelregistrarp
            // 
            this.Panelregistrarp.Controls.Add(this.BregistrarP);
            this.Panelregistrarp.Location = new System.Drawing.Point(3, 51);
            this.Panelregistrarp.Name = "Panelregistrarp";
            this.Panelregistrarp.Size = new System.Drawing.Size(200, 37);
            this.Panelregistrarp.TabIndex = 5;
            // 
            // BregistrarP
            // 
            this.BregistrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BregistrarP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BregistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BregistrarP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BregistrarP.ForeColor = System.Drawing.Color.Transparent;
            this.BregistrarP.Image = ((System.Drawing.Image)(resources.GetObject("BregistrarP.Image")));
            this.BregistrarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BregistrarP.Location = new System.Drawing.Point(-2, -2);
            this.BregistrarP.Name = "BregistrarP";
            this.BregistrarP.Size = new System.Drawing.Size(212, 44);
            this.BregistrarP.TabIndex = 2;
            this.BregistrarP.Text = "                 Registro ";
            this.BregistrarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BregistrarP.UseVisualStyleBackColor = false;
            this.BregistrarP.Click += new System.EventHandler(this.BregistrarP_Click);
            // 
            // PaneleditarP
            // 
            this.PaneleditarP.Controls.Add(this.BeditarP);
            this.PaneleditarP.Location = new System.Drawing.Point(3, 94);
            this.PaneleditarP.Name = "PaneleditarP";
            this.PaneleditarP.Size = new System.Drawing.Size(200, 37);
            this.PaneleditarP.TabIndex = 6;
            // 
            // BeditarP
            // 
            this.BeditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BeditarP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BeditarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BeditarP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeditarP.ForeColor = System.Drawing.Color.Transparent;
            this.BeditarP.Image = ((System.Drawing.Image)(resources.GetObject("BeditarP.Image")));
            this.BeditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeditarP.Location = new System.Drawing.Point(-2, -2);
            this.BeditarP.Name = "BeditarP";
            this.BeditarP.Size = new System.Drawing.Size(212, 44);
            this.BeditarP.TabIndex = 2;
            this.BeditarP.Text = "                 Editar";
            this.BeditarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeditarP.UseVisualStyleBackColor = false;
            this.BeditarP.Click += new System.EventHandler(this.BeditarP_Click);
            // 
            // PanellistarP
            // 
            this.PanellistarP.Controls.Add(this.BlistarP);
            this.PanellistarP.Location = new System.Drawing.Point(3, 137);
            this.PanellistarP.Name = "PanellistarP";
            this.PanellistarP.Size = new System.Drawing.Size(200, 37);
            this.PanellistarP.TabIndex = 7;
            // 
            // BlistarP
            // 
            this.BlistarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.BlistarP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BlistarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlistarP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlistarP.ForeColor = System.Drawing.Color.Transparent;
            this.BlistarP.Image = ((System.Drawing.Image)(resources.GetObject("BlistarP.Image")));
            this.BlistarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlistarP.Location = new System.Drawing.Point(-2, -2);
            this.BlistarP.Name = "BlistarP";
            this.BlistarP.Size = new System.Drawing.Size(212, 44);
            this.BlistarP.TabIndex = 2;
            this.BlistarP.Text = "                 Listar ";
            this.BlistarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlistarP.UseVisualStyleBackColor = false;
            this.BlistarP.Click += new System.EventHandler(this.BlistarP_Click);
            // 
            // PanelFactura
            // 
            this.PanelFactura.Controls.Add(this.btnFacturar);
            this.PanelFactura.Location = new System.Drawing.Point(3, 195);
            this.PanelFactura.Name = "PanelFactura";
            this.PanelFactura.Size = new System.Drawing.Size(200, 42);
            this.PanelFactura.TabIndex = 6;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.Transparent;
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(-3, -1);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(212, 44);
            this.btnFacturar.TabIndex = 3;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // Menutransacion
            // 
            this.Menutransacion.Interval = 50;
            this.Menutransacion.Tick += new System.EventHandler(this.Menutransacion_Tick);
            // 
            // MenuTrP
            // 
            this.MenuTrP.Interval = 50;
            this.MenuTrP.Tick += new System.EventHandler(this.MenuTrP_Tick);
            // 
            // SidbarTr
            // 
            this.SidbarTr.Interval = 10;
            this.SidbarTr.Tick += new System.EventHandler(this.SidbarTr_Tick);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(3, 243);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(212, 44);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(838, 536);
            this.Controls.Add(this.Panelmenu);
            this.Controls.Add(this.Barra_Arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGFacturacion";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Barra_Arriba.ResumeLayout(false);
            this.Barra_Arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imagelateral)).EndInit();
            this.Panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Flowcliente.ResumeLayout(false);
            this.Panelcliente.ResumeLayout(false);
            this.Panelregistrar.ResumeLayout(false);
            this.Paneleditar.ResumeLayout(false);
            this.Panellistar.ResumeLayout(false);
            this.FlowProducto.ResumeLayout(false);
            this.Panelproducto.ResumeLayout(false);
            this.Panelregistrarp.ResumeLayout(false);
            this.PaneleditarP.ResumeLayout(false);
            this.PanellistarP.ResumeLayout(false);
            this.PanelFactura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra_Arriba;
        private System.Windows.Forms.PictureBox Imagelateral;
        private System.Windows.Forms.Label SGFacturacion;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.FlowLayoutPanel Panelmenu;
        private System.Windows.Forms.Button Bcliente;
        private System.Windows.Forms.Panel Panelcliente;
        private System.Windows.Forms.Panel Panelproducto;
        private System.Windows.Forms.Button Bproducto;
        private System.Windows.Forms.FlowLayoutPanel Flowcliente;
        private System.Windows.Forms.Panel Panelregistrar;
        private System.Windows.Forms.Button BregistarC;
        private System.Windows.Forms.Panel Paneleditar;
        private System.Windows.Forms.Button BEditarC;
        private System.Windows.Forms.Panel Panellistar;
        private System.Windows.Forms.Button BlistarC;
        private System.Windows.Forms.Timer Menutransacion;
        private System.Windows.Forms.FlowLayoutPanel FlowProducto;
        private System.Windows.Forms.Panel Panelregistrarp;
        private System.Windows.Forms.Button BregistrarP;
        private System.Windows.Forms.Panel PaneleditarP;
        private System.Windows.Forms.Button BeditarP;
        private System.Windows.Forms.Panel PanellistarP;
        private System.Windows.Forms.Button BlistarP;
        private System.Windows.Forms.Timer MenuTrP;
        private System.Windows.Forms.Timer SidbarTr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelFactura;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnReportes;
    }
}

