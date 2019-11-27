using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sum = 0,prom;
            string nota;
            nota = classNotas.ClasesNotas.Aleatorios(out sum, out prom);
            this.lstNotas.Items.Clear();
            this.lstNotas.Items.Add(nota);
            this.txtProm.Text = prom.ToString();
            this.txtSuma.Text = sum.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
