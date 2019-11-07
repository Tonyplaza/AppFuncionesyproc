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
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar a la funcion calcular x1
            double a,b,c;
            //validar si el usuario a ingresado valores
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
            double x1 = calcularx1(a, b, c);
            double x2 = calcularx2(a, b, c);
            //asigno el resultado de x1 en el tectbox txtX1
            this.txtX1.Text = x1.ToString();
            this.txtX2.Text = x2.ToString();
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            //este evento
            // se ejecuta cada vez que se abre el formulario

            //establecer el contro txt2 de solo lectura
            this.txtX2.ReadOnly = true;
        }

        //crear un metodo o procedimiento
        private double calcularx1(double a, double b, double c)
        {
            //declarar variables
            double x1 = 0, d = 0;

            //calcular el discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a es distinto de 0
            if (a == 0)
            {
                MessageBox.Show("Error al difivir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias");
                return 0;
            }
            x1 = (-b + Math.Sqrt(d))/(2*a);
            return x1;
        }
        private double calcularx2(double a, double b, double c)
        {
            //declarar variables
            double x2 = 0, d = 0;

            //calcular el discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a es distinto de 0
            if (a == 0)
            {
                MessageBox.Show("Error al difivir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias");
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //encerrar cuadro de texto
            this.txtA.Text = "";
            this.txtB.Text = String.Empty;
            this.txtC.Text = String.Empty;
            this.txtX1.Text = String.Empty;
            this.txtX2.Text = String.Empty;
            this.txtA.Focus();
        }

        private void txtX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
