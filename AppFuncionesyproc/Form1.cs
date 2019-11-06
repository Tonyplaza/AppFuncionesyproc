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
        int fsuma(int a,int b)
        {
            return (a + b);
        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
