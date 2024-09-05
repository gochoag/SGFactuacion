namespace SGFactuacion
{
    partial class FormEditarC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListadoCliente = new System.Windows.Forms.DataGridView();
            this.dtFechaC = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcedulaC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTEditarC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.PnDiseñoC = new System.Windows.Forms.Panel();
            this.pnDgvEC = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCliente)).BeginInit();
            this.PnDiseñoC.SuspendLayout();
            this.pnDgvEC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvListadoCliente
            // 
            this.dgvListadoCliente.AllowUserToAddRows = false;
            this.dgvListadoCliente.AllowUserToDeleteRows = false;
            this.dgvListadoCliente.AllowUserToResizeColumns = false;
            this.dgvListadoCliente.AllowUserToResizeRows = false;
            this.dgvListadoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListadoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListadoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoCliente.EnableHeadersVisualStyles = false;
            this.dgvListadoCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvListadoCliente.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoCliente.Name = "dgvListadoCliente";
            this.dgvListadoCliente.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListadoCliente.RowHeadersVisible = false;
            this.dgvListadoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoCliente.Size = new System.Drawing.Size(567, 204);
            this.dgvListadoCliente.TabIndex = 2;
            this.dgvListadoCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoCliente_CellClick);
            this.dgvListadoCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoCliente_CellContentClick);
            // 
            // dtFechaC
            // 
            this.dtFechaC.Enabled = false;
            this.dtFechaC.Location = new System.Drawing.Point(287, 169);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Size = new System.Drawing.Size(200, 20);
            this.dtFechaC.TabIndex = 20;
            this.dtFechaC.Value = new System.DateTime(1999, 12, 27, 0, 0, 0, 0);
            this.dtFechaC.ValueChanged += new System.EventHandler(this.dtFechaC_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // txtEmailC
            // 
            this.txtEmailC.Enabled = false;
            this.txtEmailC.Location = new System.Drawing.Point(422, 122);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(174, 20);
            this.txtEmailC.TabIndex = 18;
            this.txtEmailC.TextChanged += new System.EventHandler(this.txtEmailC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Email:";
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Enabled = false;
            this.txtApellidoC.Location = new System.Drawing.Point(100, 119);
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoC.TabIndex = 16;
            this.txtApellidoC.TextChanged += new System.EventHandler(this.txtApellidoC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Enabled = false;
            this.txtNombreC.Location = new System.Drawing.Point(422, 65);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(174, 20);
            this.txtNombreC.TabIndex = 14;
            this.txtNombreC.TextChanged += new System.EventHandler(this.txtNombreC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombres:";
            // 
            // txtcedulaC
            // 
            this.txtcedulaC.Enabled = false;
            this.txtcedulaC.Location = new System.Drawing.Point(100, 65);
            this.txtcedulaC.Name = "txtcedulaC";
            this.txtcedulaC.Size = new System.Drawing.Size(174, 20);
            this.txtcedulaC.TabIndex = 12;
            this.txtcedulaC.TextChanged += new System.EventHandler(this.txtcedulaC_TextChanged);
            this.txtcedulaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedulaC_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cedula:";
            // 
            // BTEditarC
            // 
            this.BTEditarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEditarC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEditarC.Location = new System.Drawing.Point(497, 220);
            this.BTEditarC.Name = "BTEditarC";
            this.BTEditarC.Size = new System.Drawing.Size(99, 33);
            this.BTEditarC.TabIndex = 21;
            this.BTEditarC.Text = "Editar";
            this.BTEditarC.UseVisualStyleBackColor = false;
            this.BTEditarC.Click += new System.EventHandler(this.BTEditarC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buscar:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(95, 236);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 23;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // PnDiseñoC
            // 
            this.PnDiseñoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.PnDiseñoC.Controls.Add(this.label1);
            this.PnDiseñoC.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDiseñoC.Location = new System.Drawing.Point(0, 0);
            this.PnDiseñoC.Margin = new System.Windows.Forms.Padding(0);
            this.PnDiseñoC.Name = "PnDiseñoC";
            this.PnDiseñoC.Size = new System.Drawing.Size(633, 37);
            this.PnDiseñoC.TabIndex = 24;
            // 
            // pnDgvEC
            // 
            this.pnDgvEC.Controls.Add(this.dgvListadoCliente);
            this.pnDgvEC.Location = new System.Drawing.Point(29, 262);
            this.pnDgvEC.Name = "pnDgvEC";
            this.pnDgvEC.Size = new System.Drawing.Size(567, 204);
            this.pnDgvEC.TabIndex = 25;
            // 
            // FormEditarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.pnDgvEC);
            this.Controls.Add(this.PnDiseñoC);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTEditarC);
            this.Controls.Add(this.dtFechaC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcedulaC);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditarC";
            this.Text = "FormEditarCcs";
            this.Load += new System.EventHandler(this.FormEditarC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCliente)).EndInit();
            this.PnDiseñoC.ResumeLayout(false);
            this.PnDiseñoC.PerformLayout();
            this.pnDgvEC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListadoCliente;
        private System.Windows.Forms.DateTimePicker dtFechaC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcedulaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTEditarC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel PnDiseñoC;
        private System.Windows.Forms.Panel pnDgvEC;
    }
}