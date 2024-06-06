namespace SGFactuacion
{
    partial class FormEditarP
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBStockP = new System.Windows.Forms.TextBox();
            this.TBPrecioP = new System.Windows.Forms.TextBox();
            this.TBNombreP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEditProdu = new System.Windows.Forms.DataGridView();
            this.BTEditarP = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProdu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar producto";
            // 
            // TBStockP
            // 
            this.TBStockP.Location = new System.Drawing.Point(92, 136);
            this.TBStockP.Name = "TBStockP";
            this.TBStockP.Size = new System.Drawing.Size(184, 20);
            this.TBStockP.TabIndex = 13;
            // 
            // TBPrecioP
            // 
            this.TBPrecioP.Location = new System.Drawing.Point(413, 87);
            this.TBPrecioP.Name = "TBPrecioP";
            this.TBPrecioP.Size = new System.Drawing.Size(184, 20);
            this.TBPrecioP.TabIndex = 12;
            // 
            // TBNombreP
            // 
            this.TBNombreP.Location = new System.Drawing.Point(92, 87);
            this.TBNombreP.Name = "TBNombreP";
            this.TBNombreP.Size = new System.Drawing.Size(184, 20);
            this.TBNombreP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // dgvEditProdu
            // 
            this.dgvEditProdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditProdu.Location = new System.Drawing.Point(46, 221);
            this.dgvEditProdu.Name = "dgvEditProdu";
            this.dgvEditProdu.Size = new System.Drawing.Size(523, 150);
            this.dgvEditProdu.TabIndex = 14;
            this.dgvEditProdu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditProdu_CellClick);
            // 
            // BTEditarP
            // 
            this.BTEditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEditarP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEditarP.Location = new System.Drawing.Point(470, 405);
            this.BTEditarP.Name = "BTEditarP";
            this.BTEditarP.Size = new System.Drawing.Size(99, 33);
            this.BTEditarP.TabIndex = 22;
            this.BTEditarP.Text = "Editar";
            this.BTEditarP.UseVisualStyleBackColor = false;
            this.BTEditarP.Click += new System.EventHandler(this.BTEditarP_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 191);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Buscar:";
            // 
            // FormEditarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTEditarP);
            this.Controls.Add(this.dgvEditProdu);
            this.Controls.Add(this.TBStockP);
            this.Controls.Add(this.TBPrecioP);
            this.Controls.Add(this.TBNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarP";
            this.Text = "FormEditarP";
            this.Load += new System.EventHandler(this.FormEditarP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProdu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBStockP;
        private System.Windows.Forms.TextBox TBPrecioP;
        private System.Windows.Forms.TextBox TBNombreP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEditProdu;
        private System.Windows.Forms.Button BTEditarP;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
    }
}