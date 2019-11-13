using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFuncionesyproc
{
    public partial class TareaAreaTrian : Form
    {
        public TareaAreaTrian()
        {
            InitializeComponent();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
        private double Area(double a, double b, double c)
        {
            //declarar variables
            double x1 = 0, p = 0, d = 0;

            //calcular el discriminante
            p = (a+b+c)/2;
            d = p * (p - a) * (p - b) * (p - c);
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias");
                return 0;
            }
            x1 = Math.Sqrt(d);
            return x1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //llamar a la funcion calcular x1
            double a, b, c;
            if (this.txtA.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de A.");
                this.txtA.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtB.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de B.");
                this.txtB.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtC.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de C.");
                this.txtC.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            double x1 = Area(a, b, c);
            //asigno el resultado de x1 en el tectbox txtX1
            this.txtArea.Text = x1.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtA.Text = String.Empty;
            this.txtB.Text = String.Empty;
            this.txtC.Text = String.Empty;
            this.txtArea.Text = String.Empty;
            this.txtA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
