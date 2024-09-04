namespace SGFactuacion.Formularios
{
    partial class FrmEditarProvee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnDiseñoE = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonE = new System.Windows.Forms.TextBox();
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.txtCorreoE = new System.Windows.Forms.TextBox();
            this.txtTelfE = new System.Windows.Forms.TextBox();
            this.txtRUCE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEditarE = new System.Windows.Forms.Button();
            this.txtBuscarE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListadoProveedor = new System.Windows.Forms.DataGridView();
            this.PnDiseñoE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // PnDiseñoE
            // 
            this.PnDiseñoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.PnDiseñoE.Controls.Add(this.label1);
            this.PnDiseñoE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDiseñoE.Location = new System.Drawing.Point(0, 0);
            this.PnDiseñoE.Margin = new System.Windows.Forms.Padding(0);
            this.PnDiseñoE.Name = "PnDiseñoE";
            this.PnDiseñoE.Size = new System.Drawing.Size(633, 37);
            this.PnDiseñoE.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar Proveedores";
            // 
            // txtRazonE
            // 
            this.txtRazonE.Enabled = false;
            this.txtRazonE.Location = new System.Drawing.Point(292, 171);
            this.txtRazonE.Name = "txtRazonE";
            this.txtRazonE.Size = new System.Drawing.Size(174, 20);
            this.txtRazonE.TabIndex = 55;
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.Enabled = false;
            this.txtDireccionE.Location = new System.Drawing.Point(422, 113);
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(174, 20);
            this.txtDireccionE.TabIndex = 51;
            // 
            // txtCorreoE
            // 
            this.txtCorreoE.Enabled = false;
            this.txtCorreoE.Location = new System.Drawing.Point(100, 110);
            this.txtCorreoE.Name = "txtCorreoE";
            this.txtCorreoE.Size = new System.Drawing.Size(174, 20);
            this.txtCorreoE.TabIndex = 49;
            // 
            // txtTelfE
            // 
            this.txtTelfE.Enabled = false;
            this.txtTelfE.Location = new System.Drawing.Point(422, 61);
            this.txtTelfE.Name = "txtTelfE";
            this.txtTelfE.Size = new System.Drawing.Size(174, 20);
            this.txtTelfE.TabIndex = 47;
            this.txtTelfE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelfE_KeyPress);
            // 
            // txtRUCE
            // 
            this.txtRUCE.Enabled = false;
            this.txtRUCE.Location = new System.Drawing.Point(100, 61);
            this.txtRUCE.Name = "txtRUCE";
            this.txtRUCE.Size = new System.Drawing.Size(174, 20);
            this.txtRUCE.TabIndex = 45;
            this.txtRUCE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUCE_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "RUC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Razon Comercial:";
            // 
            // BtnEditarE
            // 
            this.BtnEditarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BtnEditarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditarE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditarE.Location = new System.Drawing.Point(497, 221);
            this.BtnEditarE.Name = "BtnEditarE";
            this.BtnEditarE.Size = new System.Drawing.Size(99, 33);
            this.BtnEditarE.TabIndex = 61;
            this.BtnEditarE.Text = "Editar";
            this.BtnEditarE.UseVisualStyleBackColor = false;
            this.BtnEditarE.Click += new System.EventHandler(this.BtnEditarE_Click);
            // 
            // txtBuscarE
            // 
            this.txtBuscarE.Location = new System.Drawing.Point(87, 252);
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(229, 20);
            this.txtBuscarE.TabIndex = 63;
            this.txtBuscarE.TextChanged += new System.EventHandler(this.txtBuscarE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Buscar:";
            // 
            // dgvListadoProveedor
            // 
            this.dgvListadoProveedor.AllowUserToAddRows = false;
            this.dgvListadoProveedor.AllowUserToDeleteRows = false;
            this.dgvListadoProveedor.AllowUserToResizeColumns = false;
            this.dgvListadoProveedor.AllowUserToResizeRows = false;
            this.dgvListadoProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProveedor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListadoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListadoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoProveedor.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListadoProveedor.EnableHeadersVisualStyles = false;
            this.dgvListadoProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvListadoProveedor.Location = new System.Drawing.Point(29, 287);
            this.dgvListadoProveedor.Name = "dgvListadoProveedor";
            this.dgvListadoProveedor.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListadoProveedor.RowHeadersVisible = false;
            this.dgvListadoProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProveedor.Size = new System.Drawing.Size(567, 203);
            this.dgvListadoProveedor.TabIndex = 64;
            this.dgvListadoProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProveedor_CellClick);
            // 
            // FrmEditarProvee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.dgvListadoProveedor);
            this.Controls.Add(this.BtnEditarE);
            this.Controls.Add(this.txtBuscarE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazonE);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.txtCorreoE);
            this.Controls.Add(this.txtTelfE);
            this.Controls.Add(this.txtRUCE);
            this.Controls.Add(this.PnDiseñoE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarProvee";
            this.Text = "FrmEditarProvee";
            this.Load += new System.EventHandler(this.FrmEditarProvee_Load);
            this.PnDiseñoE.ResumeLayout(false);
            this.PnDiseñoE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnDiseñoE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonE;
        private System.Windows.Forms.TextBox txtDireccionE;
        private System.Windows.Forms.TextBox txtCorreoE;
        private System.Windows.Forms.TextBox txtTelfE;
        private System.Windows.Forms.TextBox txtRUCE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEditarE;
        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListadoProveedor;
    }
}