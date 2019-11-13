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
    public partial class TareaPerimetroRec : Form
    {
        public TareaPerimetroRec()
        {
            InitializeComponent();
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }
        private double perimetro(double a, double b)
        {
            //declarar variables
            double c = 0;
            c=(2*a)+(2*b);
            return c;
        }
        private double superficie(double a, double b)
        {
            //declarar variables
            double c = 0;
            c = a * b;
            return c;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b;
            if (this.txtBase.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la base");
                this.txtBase.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la altura");
                this.txtAltura.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            a = Double.Parse(this.txtBase.Text);
            b = Double.Parse(this.txtAltura.Text);
            double x1 = perimetro(a, b);
            double x2 = superficie(a, b);
            //asigno el resultado de x1 en el tectbox txtX1
            this.txtPerimetro.Text = x1.ToString();
            this.txtSuperficie.Text = x2.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtBase.Text = String.Empty;
            this.txtAltura.Text = String.Empty;
            this.txtPerimetro.Text = String.Empty;
            this.txtSuperficie.Text = String.Empty;
            this.txtBase.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
