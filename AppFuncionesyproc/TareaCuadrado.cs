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
    public partial class TareaCuadrado : Form
    {
        public TareaCuadrado()
        {
            InitializeComponent();
        }

        private void Cuadrado_Load(object sender, EventArgs e)
        {

        }
        private int cuadrado(int a)
        {
            int b = 0;
            b = (a * a);
            return b;
        }
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuadrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a;
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el Numero.");
                this.txtNumero.Focus();
                return;
            }
             a= int.Parse(this.txtNumero.Text);
            int b = cuadrado(a);
            this.txtCuadrado.Text = b.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = String.Empty;
            this.txtCuadrado.Text = String.Empty;
            this.txtNumero.Focus();
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
