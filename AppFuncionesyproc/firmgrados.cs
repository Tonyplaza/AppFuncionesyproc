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
    public partial class firmgrados : Form
    {
        public firmgrados()
        {
            InitializeComponent();
        }

        private void txtGradoC_TextChanged(object sender, EventArgs e)
        {

        }
        private int calculargrado(int a)
        {
            int b = 0;

            b = (9 * a) / 5 + 32;
            return b;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a;
            if (this.txtGradoC.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor del grado C.");
                this.txtGradoC.Focus();
                return;
            }
            a = int.Parse(this.txtGradoC.Text);
            int b = calculargrado(a);
            this.txtGradoF.Text = b.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtGradoC.Text = String.Empty;
            this.txtGradoC.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firmgrados_Load(object sender, EventArgs e)
        {

        }
    }
}
