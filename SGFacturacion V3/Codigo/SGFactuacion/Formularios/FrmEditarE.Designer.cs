namespace SGFactuacion.Formularios
{
    partial class FrmEditarE
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
            this.PnDiseñoE = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcedulaE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListadoEmpleado = new System.Windows.Forms.DataGridView();
            this.BTEditarE = new System.Windows.Forms.Button();
            this.pnlDgvE = new System.Windows.Forms.Panel();
            this.PnDiseñoE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpleado)).BeginInit();
            this.pnlDgvE.SuspendLayout();
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
            this.PnDiseñoE.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar empleados";
            // 
            // txtBuscarE
            // 
            this.txtBuscarE.Location = new System.Drawing.Point(76, 247);
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(229, 20);
            this.txtBuscarE.TabIndex = 38;
            this.txtBuscarE.TextChanged += new System.EventHandler(this.txtBuscarE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Buscar:";
            // 
            // dtFechaE
            // 
            this.dtFechaE.Enabled = false;
            this.dtFechaE.Location = new System.Drawing.Point(274, 201);
            this.dtFechaE.Name = "dtFechaE";
            this.dtFechaE.Size = new System.Drawing.Size(200, 20);
            this.dtFechaE.TabIndex = 35;
            this.dtFechaE.Value = new System.DateTime(1999, 12, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // txtEmailE
            // 
            this.txtEmailE.Enabled = false;
            this.txtEmailE.Location = new System.Drawing.Point(422, 107);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(174, 20);
            this.txtEmailE.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email:";
            // 
            // txtApellidoE
            // 
            this.txtApellidoE.Enabled = false;
            this.txtApellidoE.Location = new System.Drawing.Point(100, 104);
            this.txtApellidoE.Name = "txtApellidoE";
            this.txtApellidoE.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoE.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Enabled = false;
            this.txtNombreE.Location = new System.Drawing.Point(422, 62);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(174, 20);
            this.txtNombreE.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombres:";
            // 
            // txtcedulaE
            // 
            this.txtcedulaE.Enabled = false;
            this.txtcedulaE.Location = new System.Drawing.Point(100, 62);
            this.txtcedulaE.Name = "txtcedulaE";
            this.txtcedulaE.Size = new System.Drawing.Size(174, 20);
            this.txtcedulaE.TabIndex = 27;
            this.txtcedulaE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedulaE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cedula:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(422, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(100, 154);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(174, 20);
            this.txtUser.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Usuario:";
            // 
            // dgvListadoEmpleado
            // 
            this.dgvListadoEmpleado.AllowUserToAddRows = false;
            this.dgvListadoEmpleado.AllowUserToDeleteRows = false;
            this.dgvListadoEmpleado.AllowUserToResizeColumns = false;
            this.dgvListadoEmpleado.AllowUserToResizeRows = false;
            this.dgvListadoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListadoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListadoEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoEmpleado.EnableHeadersVisualStyles = false;
            this.dgvListadoEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvListadoEmpleado.Location = new System.Drawing.Point(0, 0);
            this.dgvListadoEmpleado.Name = "dgvListadoEmpleado";
            this.dgvListadoEmpleado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListadoEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoEmpleado.RowHeadersVisible = false;
            this.dgvListadoEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoEmpleado.Size = new System.Drawing.Size(567, 203);
            this.dgvListadoEmpleado.TabIndex = 25;
            this.dgvListadoEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoEmpleado_CellClick);
            // 
            // BTEditarE
            // 
            this.BTEditarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTEditarE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTEditarE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEditarE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTEditarE.Location = new System.Drawing.Point(497, 239);
            this.BTEditarE.Name = "BTEditarE";
            this.BTEditarE.Size = new System.Drawing.Size(99, 33);
            this.BTEditarE.TabIndex = 36;
            this.BTEditarE.Text = "Editar";
            this.BTEditarE.UseVisualStyleBackColor = false;
            this.BTEditarE.Click += new System.EventHandler(this.BTEditarE_Click);
            // 
            // pnlDgvE
            // 
            this.pnlDgvE.Controls.Add(this.dgvListadoEmpleado);
            this.pnlDgvE.Location = new System.Drawing.Point(29, 287);
            this.pnlDgvE.Name = "pnlDgvE";
            this.pnlDgvE.Size = new System.Drawing.Size(567, 203);
            this.pnlDgvE.TabIndex = 44;
            // 
            // FrmEditarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.pnlDgvE);
            this.Controls.Add(this.BTEditarE);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PnDiseñoE);
            this.Controls.Add(this.txtBuscarE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidoE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcedulaE);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarE";
            this.Text = "FrmEditarE";
            this.Load += new System.EventHandler(this.FrmEditarE_Load);
            this.PnDiseñoE.ResumeLayout(false);
            this.PnDiseñoE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpleado)).EndInit();
            this.pnlDgvE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnDiseñoE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFechaE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcedulaE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListadoEmpleado;
        private System.Windows.Forms.Button BTEditarE;
        private System.Windows.Forms.Panel pnlDgvE;
    }
}