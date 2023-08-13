namespace Ejercicio_2
{
    partial class ConversorCelciusFahr
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblConversor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCelciusFahr = new System.Windows.Forms.Button();
            this.btnFahrCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(329, 90);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(126, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(120, 29);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(546, 20);
            this.lblConversor.TabIndex = 1;
            this.lblConversor.Text = "CONVERTIR CELSIUS - FAHRENHEIT / FAHRENHEIT - CELCIUS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INGRESE EL VALOR";
            // 
            // btnCelciusFahr
            // 
            this.btnCelciusFahr.Location = new System.Drawing.Point(180, 160);
            this.btnCelciusFahr.Name = "btnCelciusFahr";
            this.btnCelciusFahr.Size = new System.Drawing.Size(137, 43);
            this.btnCelciusFahr.TabIndex = 3;
            this.btnCelciusFahr.Text = "CELCIUS A FAHRENHEIT";
            this.btnCelciusFahr.UseVisualStyleBackColor = true;
            this.btnCelciusFahr.Click += new System.EventHandler(this.btnCelciusFahr_Click);
            // 
            // btnFahrCelsius
            // 
            this.btnFahrCelsius.Location = new System.Drawing.Point(468, 160);
            this.btnFahrCelsius.Name = "btnFahrCelsius";
            this.btnFahrCelsius.Size = new System.Drawing.Size(137, 43);
            this.btnFahrCelsius.TabIndex = 4;
            this.btnFahrCelsius.Text = "FAHRENHEIT A CELCIUS";
            this.btnFahrCelsius.UseVisualStyleBackColor = true;
            this.btnFahrCelsius.Click += new System.EventHandler(this.btnFahrCelsius_Click);
            // 
            // ConversorCelciusFahr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 256);
            this.Controls.Add(this.btnFahrCelsius);
            this.Controls.Add(this.btnCelciusFahr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConversor);
            this.Controls.Add(this.txtInput);
            this.Name = "ConversorCelciusFahr";
            this.Text = "ConversorCelciusFahr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCelciusFahr;
        private System.Windows.Forms.Button btnFahrCelsius;
    }
}