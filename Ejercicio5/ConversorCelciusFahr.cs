using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class ConversorCelciusFahr : Form
    {
        public ConversorCelciusFahr()
        {
            InitializeComponent();
        }

        private void btnCelciusFahr_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                MessageBox.Show($"{fahrenheit} °F equivale a {celsius:F2} °C");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en grados Fahrenheit.");
            }
        }

        private void btnFahrCelsius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                MessageBox.Show($"{fahrenheit} °F equivale a {celsius:F2} °C");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en grados Fahrenheit.");
            }
        }
    }
}
