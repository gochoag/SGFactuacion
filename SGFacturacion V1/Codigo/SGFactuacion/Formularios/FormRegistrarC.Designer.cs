﻿namespace SGFactuacion
{
    partial class FormRegistrarC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcedulaC = new System.Windows.Forms.TextBox();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaC = new System.Windows.Forms.DateTimePicker();
            this.BTNRegistrarC = new System.Windows.Forms.Button();
            this.PnDiseñoC = new System.Windows.Forms.Panel();
            this.PnDiseñoC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(234, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula:";
            // 
            // txtcedulaC
            // 
            this.txtcedulaC.Location = new System.Drawing.Point(274, 84);
            this.txtcedulaC.Name = "txtcedulaC";
            this.txtcedulaC.Size = new System.Drawing.Size(174, 20);
            this.txtcedulaC.TabIndex = 2;
            this.txtcedulaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedulaC_KeyPress);
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(274, 143);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(174, 20);
            this.txtNombreC.TabIndex = 4;
            this.txtNombreC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // txtApellidoC
            // 
            this.txtApellidoC.Location = new System.Drawing.Point(274, 207);
            this.txtApellidoC.Name = "txtApellidoC";
            this.txtApellidoC.Size = new System.Drawing.Size(174, 20);
            this.txtApellidoC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(275, 274);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(174, 20);
            this.txtEmailC.TabIndex = 8;
            this.txtEmailC.TextChanged += new System.EventHandler(this.txtEmailC_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(187, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // dtFechaC
            // 
            this.dtFechaC.Location = new System.Drawing.Point(274, 344);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Size = new System.Drawing.Size(200, 20);
            this.dtFechaC.TabIndex = 10;
            this.dtFechaC.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // BTNRegistrarC
            // 
            this.BTNRegistrarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTNRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNRegistrarC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegistrarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNRegistrarC.Location = new System.Drawing.Point(453, 425);
            this.BTNRegistrarC.Name = "BTNRegistrarC";
            this.BTNRegistrarC.Size = new System.Drawing.Size(99, 33);
            this.BTNRegistrarC.TabIndex = 11;
            this.BTNRegistrarC.Text = "Registrar";
            this.BTNRegistrarC.UseVisualStyleBackColor = false;
            this.BTNRegistrarC.Click += new System.EventHandler(this.BTNRegistrarC_Click);
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
            this.PnDiseñoC.TabIndex = 12;
            // 
            // FormRegistrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.PnDiseñoC);
            this.Controls.Add(this.BTNRegistrarC);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrarC";
            this.Text = "FormRegistrarC";
            this.Load += new System.EventHandler(this.FormRegistrarC_Load);
            this.PnDiseñoC.ResumeLayout(false);
            this.PnDiseñoC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcedulaC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaC;
        private System.Windows.Forms.Button BTNRegistrarC;
        private System.Windows.Forms.Panel PnDiseñoC;
    }
}