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
    public partial class TabajoFactorial : Form
    {
        public TabajoFactorial()
        {
            InitializeComponent();
        }

        private void txtFactorial_TextChanged(object sender, EventArgs e)
        {

        }
        private long factorial(int a)
        {
            //declarar variables
            int f = 1;
            for (int i=0; i<a; i++)
            {
                f = f * (i + 1);
            }
            return f;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a;
            if (this.txtFactorial.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor del factorial");
                this.txtFactorial.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
             a = int.Parse(this.txtFactorial.Text);
            this.txtResultado.Text = factorial(a).ToString("");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtFactorial.Text = String.Empty;
            this.txtResultado.Text = String.Empty;
            this.txtFactorial.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
