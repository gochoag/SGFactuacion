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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDgvP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProdu)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDgvP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(237, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar producto";
            // 
            // TBStockP
            // 
            this.TBStockP.Location = new System.Drawing.Point(92, 148);
            this.TBStockP.Name = "TBStockP";
            this.TBStockP.Size = new System.Drawing.Size(184, 20);
            this.TBStockP.TabIndex = 13;
            this.TBStockP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStockP_KeyPress);
            // 
            // TBPrecioP
            // 
            this.TBPrecioP.Location = new System.Drawing.Point(413, 100);
            this.TBPrecioP.Name = "TBPrecioP";
            this.TBPrecioP.Size = new System.Drawing.Size(184, 20);
            this.TBPrecioP.TabIndex = 12;
            this.TBPrecioP.TextChanged += new System.EventHandler(this.TBPrecioP_TextChanged);
            this.TBPrecioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecioP_KeyPress);
            // 
            // TBNombreP
            // 
            this.TBNombreP.Location = new System.Drawing.Point(92, 100);
            this.TBNombreP.Name = "TBNombreP";
            this.TBNombreP.Size = new System.Drawing.Size(184, 20);
            this.TBNombreP.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // dgvEditProdu
            // 
            this.dgvEditProdu.AllowUserToAddRows = false;
            this.dgvEditProdu.AllowUserToDeleteRows = false;
            this.dgvEditProdu.AllowUserToResizeColumns = false;
            this.dgvEditProdu.AllowUserToResizeRows = false;
            this.dgvEditProdu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditProdu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvEditProdu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditProdu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditProdu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditProdu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditProdu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditProdu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEditProdu.EnableHeadersVisualStyles = false;
            this.dgvEditProdu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvEditProdu.Location = new System.Drawing.Point(0, 0);
            this.dgvEditProdu.Name = "dgvEditProdu";
            this.dgvEditProdu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditProdu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditProdu.RowHeadersVisible = false;
            this.dgvEditProdu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditProdu.Size = new System.Drawing.Size(567, 204);
            this.dgvEditProdu.TabIndex = 14;
            this.dgvEditProdu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditProdu_CellClick);
            // 
            // BTEditarP
            // 
            this.BTEditarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTEditarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEditarP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEditarP.Location = new System.Drawing.Point(492, 218);
            this.BTEditarP.Name = "BTEditarP";
            this.BTEditarP.Size = new System.Drawing.Size(99, 33);
            this.BTEditarP.TabIndex = 22;
            this.BTEditarP.Text = "Editar";
            this.BTEditarP.UseVisualStyleBackColor = false;
            this.BTEditarP.Click += new System.EventHandler(this.BTEditarP_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 226);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Buscar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 37);
            this.panel1.TabIndex = 26;
            // 
            // pnlDgvP
            // 
            this.pnlDgvP.Controls.Add(this.dgvEditProdu);
            this.pnlDgvP.Location = new System.Drawing.Point(24, 257);
            this.pnlDgvP.Name = "pnlDgvP";
            this.pnlDgvP.Size = new System.Drawing.Size(567, 204);
            this.pnlDgvP.TabIndex = 27;
            // 
            // FormEditarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.pnlDgvP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTEditarP);
            this.Controls.Add(this.TBStockP);
            this.Controls.Add(this.TBPrecioP);
            this.Controls.Add(this.TBNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarP";
            this.Text = "FormEditarP";
            this.Load += new System.EventHandler(this.FormEditarP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditProdu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDgvP.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDgvP;
    }
}