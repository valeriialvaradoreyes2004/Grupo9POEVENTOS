namespace Ejercicio_2
{
    partial class ConversorCelciusKelvin
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
            this.btnKelvinCelcius = new System.Windows.Forms.Button();
            this.btnCelciusKelvin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversor = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKelvinCelcius
            // 
            this.btnKelvinCelcius.Location = new System.Drawing.Point(475, 169);
            this.btnKelvinCelcius.Name = "btnKelvinCelcius";
            this.btnKelvinCelcius.Size = new System.Drawing.Size(137, 43);
            this.btnKelvinCelcius.TabIndex = 9;
            this.btnKelvinCelcius.Text = "KELVIN A CELCIUS";
            this.btnKelvinCelcius.UseVisualStyleBackColor = true;
            this.btnKelvinCelcius.Click += new System.EventHandler(this.btnKelvinCelcius_Click);
            // 
            // btnCelciusKelvin
            // 
            this.btnCelciusKelvin.Location = new System.Drawing.Point(187, 169);
            this.btnCelciusKelvin.Name = "btnCelciusKelvin";
            this.btnCelciusKelvin.Size = new System.Drawing.Size(137, 43);
            this.btnCelciusKelvin.TabIndex = 8;
            this.btnCelciusKelvin.Text = "CELCIUS A KELVIN";
            this.btnCelciusKelvin.UseVisualStyleBackColor = true;
            this.btnCelciusKelvin.Click += new System.EventHandler(this.btnCelciusKelvin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESE EL VALOR";
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(168, 30);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(444, 20);
            this.lblConversor.TabIndex = 6;
            this.lblConversor.Text = "CONVERTIR CELSIUS - KELVIN / KELVIN - CELCIUS";
            this.lblConversor.Click += new System.EventHandler(this.lblConversor_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(336, 99);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(126, 20);
            this.txtInput.TabIndex = 5;
            // 
            // ConversorCelciusKelvin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.btnKelvinCelcius);
            this.Controls.Add(this.btnCelciusKelvin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConversor);
            this.Controls.Add(this.txtInput);
            this.Name = "ConversorCelciusKelvin";
            this.Text = "ConversorCelciusKelvin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKelvinCelcius;
        private System.Windows.Forms.Button btnCelciusKelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.TextBox txtInput;
    }
}