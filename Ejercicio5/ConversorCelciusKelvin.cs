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
    public partial class ConversorCelciusKelvin : Form
    {
        public ConversorCelciusKelvin()
        {
            InitializeComponent();
        }

        private void btnCelciusKelvin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double celsius))
            {
                double kelvin = celsius + 273.15;
                MessageBox.Show($"{celsius} °C equivale a {kelvin:F2} K");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en grados Celsius.");
            }
        }

        private void btnKelvinCelcius_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double kelvin))
            {
                double celsius = kelvin - 273.15;
                MessageBox.Show($"{kelvin} K equivale a {celsius:F2} °C");
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido en Kelvin.");
            }
        }

        private void lblConversor_Click(object sender, EventArgs e)
        {

        }
    }
}
