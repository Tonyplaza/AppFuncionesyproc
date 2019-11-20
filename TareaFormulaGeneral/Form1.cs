using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaFormulaGeneral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
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
            if (a == 0)
            {
                MessageBox.Show("Error al difivir para cero...");
                return ;
            }
            //verificar si d es positivo
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias");
                return ;
            }
            double x1 = AppTareaClass.Formula.x1(a, b, c);
            double x2 = AppTareaClass.Formula.x2(a, b, c);
            this.txtX1.Text = x1.ToString();
            this.txtX2.Text = x2.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtA.Text = String.Empty;
            this.txtB.Text = String.Empty;
            this.txtC.Text = String.Empty;
            this.txtX1.Text = String.Empty;
            this.txtX2.Text = String.Empty;
            this.txtA.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
