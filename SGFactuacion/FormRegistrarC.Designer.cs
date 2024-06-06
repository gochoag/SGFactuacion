namespace SGFactuacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBrcedulaC = new System.Windows.Forms.TextBox();
            this.TBNombreC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBApellidoC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBEmailC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTFechaC = new System.Windows.Forms.DateTimePicker();
            this.BTRegistrarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula:";
            // 
            // TBrcedulaC
            // 
            this.TBrcedulaC.Location = new System.Drawing.Point(226, 73);
            this.TBrcedulaC.Name = "TBrcedulaC";
            this.TBrcedulaC.Size = new System.Drawing.Size(174, 20);
            this.TBrcedulaC.TabIndex = 2;
            // 
            // TBNombreC
            // 
            this.TBNombreC.Location = new System.Drawing.Point(226, 132);
            this.TBNombreC.Name = "TBNombreC";
            this.TBNombreC.Size = new System.Drawing.Size(174, 20);
            this.TBNombreC.TabIndex = 4;
            this.TBNombreC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:";
            // 
            // TBApellidoC
            // 
            this.TBApellidoC.Location = new System.Drawing.Point(226, 196);
            this.TBApellidoC.Name = "TBApellidoC";
            this.TBApellidoC.Size = new System.Drawing.Size(174, 20);
            this.TBApellidoC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos:";
            // 
            // TBEmailC
            // 
            this.TBEmailC.Location = new System.Drawing.Point(227, 263);
            this.TBEmailC.Name = "TBEmailC";
            this.TBEmailC.Size = new System.Drawing.Size(174, 20);
            this.TBEmailC.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // DTFechaC
            // 
            this.DTFechaC.Location = new System.Drawing.Point(226, 333);
            this.DTFechaC.Name = "DTFechaC";
            this.DTFechaC.Size = new System.Drawing.Size(200, 20);
            this.DTFechaC.TabIndex = 10;
            // 
            // BTRegistrarC
            // 
            this.BTRegistrarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTRegistrarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTRegistrarC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTRegistrarC.Location = new System.Drawing.Point(385, 429);
            this.BTRegistrarC.Name = "BTRegistrarC";
            this.BTRegistrarC.Size = new System.Drawing.Size(99, 33);
            this.BTRegistrarC.TabIndex = 11;
            this.BTRegistrarC.Text = "Registrar";
            this.BTRegistrarC.UseVisualStyleBackColor = false;
            // 
            // FormRegistrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 509);
            this.Controls.Add(this.BTRegistrarC);
            this.Controls.Add(this.DTFechaC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBEmailC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBApellidoC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBNombreC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBrcedulaC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarC";
            this.Text = "FormRegistrarC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBrcedulaC;
        private System.Windows.Forms.TextBox TBNombreC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBApellidoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBEmailC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTFechaC;
        private System.Windows.Forms.Button BTRegistrarC;
    }
}