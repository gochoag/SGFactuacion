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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock:";
            // 
            // TBNombreP
            // 
            this.TBNombreP.Location = new System.Drawing.Point(179, 91);
            this.TBNombreP.Name = "TBNombreP";
            this.TBNombreP.Size = new System.Drawing.Size(184, 20);
            this.TBNombreP.TabIndex = 5;
            // 
            // TBPrecioP
            // 
            this.TBPrecioP.Location = new System.Drawing.Point(200, 140);
            this.TBPrecioP.Name = "TBPrecioP";
            this.TBPrecioP.Size = new System.Drawing.Size(184, 20);
            this.TBPrecioP.TabIndex = 6;
            // 
            // TBStockP
            // 
            this.TBStockP.Location = new System.Drawing.Point(179, 194);
            this.TBStockP.Name = "TBStockP";
            this.TBStockP.Size = new System.Drawing.Size(184, 20);
            this.TBStockP.TabIndex = 7;
            // 
            // BTRegistrarP
            // 
            this.BTRegistrarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTRegistrarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTRegistrarP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTRegistrarP.Location = new System.Drawing.Point(415, 421);
            this.BTRegistrarP.Name = "BTRegistrarP";
            this.BTRegistrarP.Size = new System.Drawing.Size(99, 33);
            this.BTRegistrarP.TabIndex = 12;
            this.BTRegistrarP.Text = "Registrar";
            this.BTRegistrarP.UseVisualStyleBackColor = false;
            // 
            // FormResgistrarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 481);
            this.Controls.Add(this.BTRegistrarP);
            this.Controls.Add(this.TBStockP);
            this.Controls.Add(this.TBPrecioP);
            this.Controls.Add(this.TBNombreP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResgistrarP";
            this.Text = "FormResgistrarP";
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
    }
}