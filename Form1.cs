using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.LadoA = double.Parse(txtA.Text);
            triangulo.LadoB = double.Parse(txtB.Text);
            triangulo.LadoC = double.Parse(txtC.Text);
            lblPerimetro.Text = $"Perimetro: {triangulo.Perimetro().ToString()}";
            lblPerimetro.Visible = true;
            txtA.Text= string.Empty;
            txtB.Text= string.Empty;
            txtC.Text= string.Empty;
            txtA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
