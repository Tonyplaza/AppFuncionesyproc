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
    public partial class TareaMetros : Form
    {
        public TareaMetros()
        {
            InitializeComponent();
        }

        private void txtMetros_TextChanged(object sender, EventArgs e)
        {

        }
        private double pulgada(double a)
        {
            //declarar variables
           double x2 = 0;
           x2 = a*39.37;
            return x2;
        }
        private double pie(double a)
        {
            //declarar variables
            double x2 = 0;
            x2 = a /12;
            return x2;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //llamar a la funcion calcular x1
            double a;
            //validar si el usuario a ingresado valores
            if (this.txtMetros.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de metros.");
                this.txtMetros.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            a = Double.Parse(this.txtMetros.Text);
            double x1 = pulgada(a);
            double x2 = pie(x1);
            //asigno el resultado de x1 en el tectbox txtX1
            this.txtPulgadas.Text = x1.ToString();
            this.txtPies.Text = x2.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtMetros.Text = String.Empty;
            this.txtPulgadas.Text = String.Empty;
            this.txtPies.Text = String.Empty;
            this.txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
