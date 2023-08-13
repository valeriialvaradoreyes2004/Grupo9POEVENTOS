namespace Ejercicio_2
{
    partial class Conversor
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
            this.btnCelciusFahr = new System.Windows.Forms.Button();
            this.btnKelvinCelsius = new System.Windows.Forms.Button();
            this.lblConvertir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCelciusFahr
            // 
            this.btnCelciusFahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelciusFahr.Location = new System.Drawing.Point(208, 139);
            this.btnCelciusFahr.Name = "btnCelciusFahr";
            this.btnCelciusFahr.Size = new System.Drawing.Size(144, 52);
            this.btnCelciusFahr.TabIndex = 0;
            this.btnCelciusFahr.Text = "Celsius - Fahrenheit";
            this.btnCelciusFahr.UseVisualStyleBackColor = true;
            this.btnCelciusFahr.Click += new System.EventHandler(this.btnCelciusFahr_Click);
            // 
            // btnKelvinCelsius
            // 
            this.btnKelvinCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelvinCelsius.Location = new System.Drawing.Point(449, 139);
            this.btnKelvinCelsius.Name = "btnKelvinCelsius";
            this.btnKelvinCelsius.Size = new System.Drawing.Size(144, 52);
            this.btnKelvinCelsius.TabIndex = 1;
            this.btnKelvinCelsius.Text = "Kelvin - Celsius";
            this.btnKelvinCelsius.UseVisualStyleBackColor = true;
            this.btnKelvinCelsius.Click += new System.EventHandler(this.btnKelvinCelsius_Click);
            // 
            // lblConvertir
            // 
            this.lblConvertir.AutoSize = true;
            this.lblConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertir.Location = new System.Drawing.Point(148, 60);
            this.lblConvertir.Name = "lblConvertir";
            this.lblConvertir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConvertir.Size = new System.Drawing.Size(496, 24);
            this.lblConvertir.TabIndex = 2;
            this.lblConvertir.Text = "CONVERTIDOR DE UNIDADES DE TEMPERATURA";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 280);
            this.Controls.Add(this.lblConvertir);
            this.Controls.Add(this.btnKelvinCelsius);
            this.Controls.Add(this.btnCelciusFahr);
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCelciusFahr;
        private System.Windows.Forms.Button btnKelvinCelsius;
        private System.Windows.Forms.Label lblConvertir;
    }
}