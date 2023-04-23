namespace FColorestp2
{
    partial class FColores
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
            this.BAmarillo = new System.Windows.Forms.Button();
            this.BRojo = new System.Windows.Forms.Button();
            this.Bazul = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lAmarillo = new System.Windows.Forms.Label();
            this.lRojo = new System.Windows.Forms.Label();
            this.lAzul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAmarillo
            // 
            this.BAmarillo.Location = new System.Drawing.Point(140, 68);
            this.BAmarillo.Name = "BAmarillo";
            this.BAmarillo.Size = new System.Drawing.Size(148, 37);
            this.BAmarillo.TabIndex = 0;
            this.BAmarillo.Text = "&Amarillo";
            this.BAmarillo.UseVisualStyleBackColor = true;
            this.BAmarillo.Click += new System.EventHandler(this.BAmarillo_Click);
            // 
            // BRojo
            // 
            this.BRojo.Location = new System.Drawing.Point(140, 111);
            this.BRojo.Name = "BRojo";
            this.BRojo.Size = new System.Drawing.Size(148, 37);
            this.BRojo.TabIndex = 1;
            this.BRojo.Text = "&Rojo";
            this.BRojo.UseVisualStyleBackColor = true;
            this.BRojo.Click += new System.EventHandler(this.BRojo_Click);
            // 
            // Bazul
            // 
            this.Bazul.Location = new System.Drawing.Point(140, 154);
            this.Bazul.Name = "Bazul";
            this.Bazul.Size = new System.Drawing.Size(148, 37);
            this.Bazul.TabIndex = 2;
            this.Bazul.Text = "A&zul";
            this.Bazul.UseVisualStyleBackColor = true;
            this.Bazul.Click += new System.EventHandler(this.Bazul_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(310, 258);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(95, 36);
            this.bCerrar.TabIndex = 3;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lAmarillo
            // 
            this.lAmarillo.AutoSize = true;
            this.lAmarillo.Location = new System.Drawing.Point(310, 80);
            this.lAmarillo.Name = "lAmarillo";
            this.lAmarillo.Size = new System.Drawing.Size(13, 13);
            this.lAmarillo.TabIndex = 4;
            this.lAmarillo.Text = "0";
            this.lAmarillo.Visible = false;
            // 
            // lRojo
            // 
            this.lRojo.AutoSize = true;
            this.lRojo.Location = new System.Drawing.Point(310, 123);
            this.lRojo.Name = "lRojo";
            this.lRojo.Size = new System.Drawing.Size(13, 13);
            this.lRojo.TabIndex = 5;
            this.lRojo.Text = "0";
            this.lRojo.Visible = false;
            // 
            // lAzul
            // 
            this.lAzul.AutoSize = true;
            this.lAzul.Location = new System.Drawing.Point(310, 166);
            this.lAzul.Name = "lAzul";
            this.lAzul.Size = new System.Drawing.Size(13, 13);
            this.lAzul.TabIndex = 6;
            this.lAzul.Text = "0";
            this.lAzul.Visible = false;
            // 
            // FColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.lAzul);
            this.Controls.Add(this.lRojo);
            this.Controls.Add(this.lAmarillo);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.Bazul);
            this.Controls.Add(this.BRojo);
            this.Controls.Add(this.BAmarillo);
            this.Name = "FColores";
            this.Text = "Mezcla de Colores";
            this.Load += new System.EventHandler(this.FColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAmarillo;
        private System.Windows.Forms.Button BRojo;
        private System.Windows.Forms.Button Bazul;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lAmarillo;
        private System.Windows.Forms.Label lRojo;
        private System.Windows.Forms.Label lAzul;
    }
}

