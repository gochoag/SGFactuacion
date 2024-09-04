namespace SGFactuacion.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSGFacturacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.imglistOjos = new System.Windows.Forms.ImageList(this.components);
            this.btnOjo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblSGFacturacion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(385, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 288);
            this.panel1.TabIndex = 0;
            // 
            // lblSGFacturacion
            // 
            this.lblSGFacturacion.AutoSize = true;
            this.lblSGFacturacion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGFacturacion.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSGFacturacion.Location = new System.Drawing.Point(41, 37);
            this.lblSGFacturacion.Name = "lblSGFacturacion";
            this.lblSGFacturacion.Size = new System.Drawing.Size(199, 37);
            this.lblSGFacturacion.TabIndex = 1;
            this.lblSGFacturacion.Text = "SGFacturacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.ForeColor = System.Drawing.Color.Green;
            this.lblIniciar.Location = new System.Drawing.Point(102, 9);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(167, 32);
            this.lblIniciar.TabIndex = 1;
            this.lblIniciar.Text = "Iniciar Sesión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(21, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 21);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(21, 84);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(266, 20);
            this.txtbUsuario.TabIndex = 3;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.Location = new System.Drawing.Point(21, 144);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(92, 21);
            this.lblcontra.TabIndex = 4;
            this.lblcontra.Text = "Contraseña";
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(21, 168);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.PasswordChar = '*';
            this.txtbContraseña.Size = new System.Drawing.Size(266, 20);
            this.txtbContraseña.TabIndex = 5;
            this.txtbContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbContraseña_KeyPress);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEntrar.Location = new System.Drawing.Point(125, 221);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(121, 38);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // imglistOjos
            // 
            this.imglistOjos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistOjos.ImageStream")));
            this.imglistOjos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistOjos.Images.SetKeyName(0, "ojocerrado.png");
            this.imglistOjos.Images.SetKeyName(1, "ojoabierto.png");
            // 
            // btnOjo
            // 
            this.btnOjo.FlatAppearance.BorderSize = 0;
            this.btnOjo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOjo.Location = new System.Drawing.Point(293, 161);
            this.btnOjo.Name = "btnOjo";
            this.btnOjo.Size = new System.Drawing.Size(32, 32);
            this.btnOjo.TabIndex = 8;
            this.btnOjo.UseVisualStyleBackColor = true;
            this.btnOjo.Click += new System.EventHandler(this.btnOjo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(224, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(649, 288);
            this.Controls.Add(this.btnOjo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSGFacturacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.ImageList imglistOjos;
        private System.Windows.Forms.Button btnOjo;
        public System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCerrar;
    }
}