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
            string msg1="",msg2="";
            double x1 = AppTareaClass.Formula.x1(a, b, c, out msg1);
            double x2 = AppTareaClass.Formula.x2(a, b, c, out msg2);
            if ( msg1.Length == 0)
            {
                this.txtX1.Text = x1.ToString("0.00");
            }
            else
            {
                this.txtX1.Text = msg1;
            }
            if (msg2.Length == 0)
            {
                this.txtX2.Text = x2.ToString("0.00");
            }
            else
            {
                this.txtX2.Text = msg2;
            }
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

        private void btnGetX1_Click(object sender, EventArgs e)
        {
            double a, b, c, d,x1;
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
            try
            {
                x1 = AppTareaClass.Formula.getx1(a, b, c);
                this.txtX1.Text = x1.ToString("0.00");
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
