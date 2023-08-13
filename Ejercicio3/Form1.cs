using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_Suma_De_Dos_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click_1(object sender, EventArgs e)
        {
            TxtN1.Text = "";
            TxtN2.Text = "";
            TxtR.Text = "";

        }
        
        private void Calcular_Click_1(object sender, EventArgs e)
        {
            double N1, N2, R;
            N1 = double.Parse(TxtN1.Text);
            N2 = double.Parse(TxtN2.Text);
            R = N1 + N2;
            TxtR.Text = R.ToString();
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
