namespace SGFactuacion.Formularios
{
    partial class FrmListarE
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
            this.dgvListarEmpleado = new System.Windows.Forms.DataGridView();
            this.PnDiseñoE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // PnDiseñoE
            // 
            this.PnDiseñoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.PnDiseñoE.Controls.Add(this.label1);
            this.PnDiseñoE.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDiseñoE.Location = new System.Drawing.Point(0, 0);
            this.PnDiseñoE.Name = "PnDiseñoE";
            this.PnDiseñoE.Size = new System.Drawing.Size(633, 37);
            this.PnDiseñoE.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(231, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de empleados";
            // 
            // txtBuscarE
            // 
            this.txtBuscarE.Location = new System.Drawing.Point(84, 145);
            this.txtBuscarE.Name = "txtBuscarE";
            this.txtBuscarE.Size = new System.Drawing.Size(229, 20);
            this.txtBuscarE.TabIndex = 29;
            this.txtBuscarE.TextChanged += new System.EventHandler(this.txtBuscarE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Buscar:";
            // 
            // dgvListarEmpleado
            // 
            this.dgvListarEmpleado.AllowUserToAddRows = false;
            this.dgvListarEmpleado.AllowUserToDeleteRows = false;
            this.dgvListarEmpleado.AllowUserToResizeColumns = false;
            this.dgvListarEmpleado.AllowUserToResizeRows = false;
            this.dgvListarEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarEmpleado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListarEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListarEmpleado.EnableHeadersVisualStyles = false;
            this.dgvListarEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(118)))), ((int)(((byte)(59)))));
            this.dgvListarEmpleado.Location = new System.Drawing.Point(28, 199);
            this.dgvListarEmpleado.Name = "dgvListarEmpleado";
            this.dgvListarEmpleado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(249)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListarEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListarEmpleado.RowHeadersVisible = false;
            this.dgvListarEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvListarEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarEmpleado.Size = new System.Drawing.Size(567, 204);
            this.dgvListarEmpleado.TabIndex = 27;
            this.dgvListarEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarEmpleado_CellContentClick);
            // 
            // FrmListarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 466);
            this.Controls.Add(this.PnDiseñoE);
            this.Controls.Add(this.txtBuscarE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvListarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarE";
            this.Text = "FrmListarE";
            this.Load += new System.EventHandler(this.FrmListarE_Load);
            this.PnDiseñoE.ResumeLayout(false);
            this.PnDiseñoE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnDiseñoE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListarEmpleado;
    }
}