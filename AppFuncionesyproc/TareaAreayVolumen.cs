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
    public partial class TareaAreayVolumen : Form
    {
        public TareaAreayVolumen()
        {
            InitializeComponent();
        }

        private double area(double a, double b)
        {
            //declarar variables
            double al = 0,ab = 0,at=0;
            al = 2 * 3.14 * a * b;
            ab = 3.14 * a * a;
            at = al + ab;
            return at;
        }
        private double volumen(double a, double b)
        {
            //declarar variables
            double vt = 0;
            vt = 3.14 * a * a * b;
            return vt;
        }
        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b;
            if (this.txtRadio.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor del radio");
                this.txtRadio.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtAltura.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de Altura");
                this.txtAltura.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
             a = Double.Parse(this.txtRadio.Text);
             b = Double.Parse(this.txtAltura.Text);
            double x1 = area(a, b);
            double x2 = volumen(a, b);
            this.txtArea.Text = x1.ToString();
            this.txtVolumen.Text = x2.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtRadio.Text = String.Empty;
            this.txtAltura.Text = String.Empty;
            this.txtArea.Text = String.Empty;
            this.txtVolumen.Text = String.Empty;
            this.txtRadio.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
