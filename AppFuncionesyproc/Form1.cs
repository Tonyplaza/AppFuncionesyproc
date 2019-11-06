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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int suma = fsuma(num1, num2);
            //adigno el resultado al cuadro de teto
            this.txtResultado.Text = suma.ToString();
        }
        int fsuma(int a, int b)
        {
            return (a + b);
        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int resta = fresta(num1, num2);
            //asigno el resultado al cuadro de texto
            this.txtResultado.Text = resta.ToString();
        }
        int fresta(int a, int b)
        {
            return (a - b);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int multi = fmulti(num1, num2);
            //asigno el resultado al cuadro de texto
            this.txtResultado.Text = multi.ToString();
        }
        int fmulti(int a, int b )
        {
            return(a * b);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtnum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int division = fdivision(num1, num2);
            //asigno el resultado al cuadro de texto
            this.txtResultado.Text = division.ToString();
        }
        int fdivision(int a, int b)
        {
            return (a / b);
        }
    }
}
