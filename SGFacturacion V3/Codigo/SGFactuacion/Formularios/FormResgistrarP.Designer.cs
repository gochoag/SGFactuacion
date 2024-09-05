namespace SGFactuacion
{
    partial class FormResgistrarP
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNombreP = new System.Windows.Forms.TextBox();
            this.TBPrecioP = new System.Windows.Forms.TextBox();
            this.TBStockP = new System.Windows.Forms.TextBox();
            this.BTRegistrarP = new System.Windows.Forms.Button();
            this.PnDiseñoP = new System.Windows.Forms.Panel();
            this.cbRazoncomercial = new System.Windows.Forms.ComboBox();
            this.LblRazon = new System.Windows.Forms.Label();
            this.PnDiseñoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(214, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock:";
            // 
            // TBNombreP
            // 
            this.TBNombreP.Location = new System.Drawing.Point(260, 122);
            this.TBNombreP.Name = "TBNombreP";
            this.TBNombreP.Size = new System.Drawing.Size(184, 20);
            this.TBNombreP.TabIndex = 5;
            // 
            // TBPrecioP
            // 
            this.TBPrecioP.Location = new System.Drawing.Point(260, 171);
            this.TBPrecioP.Name = "TBPrecioP";
            this.TBPrecioP.Size = new System.Drawing.Size(184, 20);
            this.TBPrecioP.TabIndex = 6;
            this.TBPrecioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecioP_KeyPress);
            // 
            // TBStockP
            // 
            this.TBStockP.Location = new System.Drawing.Point(260, 225);
            this.TBStockP.Name = "TBStockP";
            this.TBStockP.Size = new System.Drawing.Size(184, 20);
            this.TBStockP.TabIndex = 7;
            this.TBStockP.TextChanged += new System.EventHandler(this.TBStockP_TextChanged);
            this.TBStockP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStockP_KeyPress);
            // 
            // BTRegistrarP
            // 
            this.BTRegistrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(34)))));
            this.BTRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTRegistrarP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTRegistrarP.Location = new System.Drawing.Point(434, 385);
            this.BTRegistrarP.Name = "BTRegistrarP";
            this.BTRegistrarP.Size = new System.Drawing.Size(99, 33);
            this.BTRegistrarP.TabIndex = 12;
            this.BTRegistrarP.Text = "Registrar";
            this.BTRegistrarP.UseVisualStyleBackColor = false;
            this.BTRegistrarP.Click += new System.EventHandler(this.BTRegistrarP_Click);
            // 
            // PnDiseñoP
            // 
            this.PnDiseñoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(165)))), ((int)(((byte)(93)))));
            this.PnDiseñoP.Controls.Add(this.label1);
            this.PnDiseñoP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnDiseñoP.Location = new System.Drawing.Point(0, 0);
            this.PnDiseñoP.Name = "PnDiseñoP";
            this.PnDiseñoP.Size = new System.Drawing.Size(633, 37);
            this.PnDiseñoP.TabIndex = 13;
            // 
            // cbRazoncomercial
            // 
            this.cbRazoncomercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRazoncomercial.FormattingEnabled = true;
            this.cbRazoncomercial.Location = new System.Drawing.Point(260, 273);
            this.cbRazoncomercial.Name = "cbRazoncomercial";
            this.cbRazoncomercial.Size = new System.Drawing.Size(184, 21);
            this.cbRazoncomercial.TabIndex = 14;
            this.cbRazoncomercial.SelectedIndexChanged += new System.EventHandler(this.cbRazoncomercial_SelectedIndexChanged);
            // 
            // LblRazon
            // 
            this.LblRazon.AutoSize = true;
            this.LblRazon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRazon.Location = new System.Drawing.Point(122, 277);
            this.LblRazon.Name = "LblRazon";
            this.LblRazon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblRazon.Size = new System.Drawing.Size(125, 17);
            this.LblRazon.TabIndex = 15;
            this.LblRazon.Text = "Nombre comercial:";
            this.LblRazon.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormResgistrarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 502);
            this.Controls.Add(this.LblRazon);
            this.Controls.Add(this.cbRazoncomercial);
            this.Controls.Add(this.PnDiseñoP);
            this.Controls.Add(this.BTRegistrarP);
            this.Controls.Add(this.TBStockP);
            this.Controls.Add(this.TBPrecioP);
            this.Controls.Add(this.TBNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResgistrarP";
            this.Text = "FormResgistrarP";
            this.Load += new System.EventHandler(this.FormResgistrarP_Load);
            this.PnDiseñoP.ResumeLayout(false);
            this.PnDiseñoP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBNombreP;
        private System.Windows.Forms.TextBox TBPrecioP;
        private System.Windows.Forms.TextBox TBStockP;
        private System.Windows.Forms.Button BTRegistrarP;
        private System.Windows.Forms.Panel PnDiseñoP;
        private System.Windows.Forms.ComboBox cbRazoncomercial;
        private System.Windows.Forms.Label LblRazon;
    }
}