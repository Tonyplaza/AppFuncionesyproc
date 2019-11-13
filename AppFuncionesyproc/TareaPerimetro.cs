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
    public partial class TareaPerimetro : Form
    {
        public TareaPerimetro()
        {
            InitializeComponent();
        }

        private void txtLongitud_TextChanged(object sender, EventArgs e)
        {

        }
        private double perimetro(double a)
        {
            //declarar variables
            double b=0;
            b = 4 * a;
            return b;
        }
        private double superficie(double a)
        {
            //declarar variables
            double b = 0;
            b = a*a;
            return b;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a;
            //validar si el usuario a ingresado valores
            if (this.txtLongitud.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la Longitud");
                this.txtLongitud.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            a = Double.Parse(this.txtLongitud.Text);
            double x1 = perimetro(a);
            double x2 = superficie(a);
            //asigno el resultado de x1 en el tectbox txtX1
            this.txtPerimetro.Text = x1.ToString();
            this.txtSuperficie.Text = x2.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtLongitud.Text = String.Empty;
            this.txtPerimetro.Text = String.Empty;
            this.txtSuperficie.Text = String.Empty;
            this.txtLongitud.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
