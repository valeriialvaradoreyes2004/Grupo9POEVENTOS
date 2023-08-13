using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroDivisibleEntre13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            int numero;



            if (int.TryParse(textBoxNumero.Text, out numero))
            {
                if (numero % 13 == 0)
                {
                    MessageBox.Show("El número es divisible por 13.");
                }
                else
                {
                    MessageBox.Show("El número NO es divisible por 13.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }

        }

        
    }
}
    
