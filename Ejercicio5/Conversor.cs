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
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void btnCelciusFahr_Click(object sender, EventArgs e)
        {
            ConversorCelciusFahr ConversorCelciusFahrForm = new ConversorCelciusFahr();
            ConversorCelciusFahrForm.Show();
        }

        private void btnKelvinCelsius_Click(object sender, EventArgs e)
        {
            ConversorCelciusKelvin ConversorCelciusKelvinForm = new ConversorCelciusKelvin();
            ConversorCelciusKelvinForm.Show();
        }
    }
}
