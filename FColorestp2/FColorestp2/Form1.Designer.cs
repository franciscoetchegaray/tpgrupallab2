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
            this.SuspendLayout();
            // 
            // BAmarillo
            // 
            this.BAmarillo.Location = new System.Drawing.Point(41, 112);
            this.BAmarillo.Name = "BAmarillo";
            this.BAmarillo.Size = new System.Drawing.Size(127, 30);
            this.BAmarillo.TabIndex = 0;
            this.BAmarillo.Text = "Amarillo";
            this.BAmarillo.UseVisualStyleBackColor = true;
            this.BAmarillo.Click += new System.EventHandler(this.BAmarillo_Click);
            // 
            // BRojo
            // 
            this.BRojo.Location = new System.Drawing.Point(218, 112);
            this.BRojo.Name = "BRojo";
            this.BRojo.Size = new System.Drawing.Size(126, 30);
            this.BRojo.TabIndex = 1;
            this.BRojo.Text = "Rojo";
            this.BRojo.UseVisualStyleBackColor = true;
            this.BRojo.Click += new System.EventHandler(this.BRojo_Click);
            // 
            // Bazul
            // 
            this.Bazul.Location = new System.Drawing.Point(380, 112);
            this.Bazul.Name = "Bazul";
            this.Bazul.Size = new System.Drawing.Size(120, 30);
            this.Bazul.TabIndex = 2;
            this.Bazul.Text = "Azul";
            this.Bazul.UseVisualStyleBackColor = true;
            this.Bazul.Click += new System.EventHandler(this.Bazul_Click);
            // 
            // FColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bazul);
            this.Controls.Add(this.BRojo);
            this.Controls.Add(this.BAmarillo);
            this.Name = "FColores";
            this.Text = "Mezcla de Colores";
            this.Load += new System.EventHandler(this.FColores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAmarillo;
        private System.Windows.Forms.Button BRojo;
        private System.Windows.Forms.Button Bazul;
    }
}

