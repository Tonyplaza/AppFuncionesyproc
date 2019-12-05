using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaOrdenar
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(this.txtTamanio.Text);
            int[] vector = ordenar.generar(tamanio);
            listBoxVector.Items.Clear();
            for (int i=0; i<tamanio;i++)
            {
                listBoxVector.Items.Add(vector[i]);
            }
            //Ordeno el vector y vuelvo a cargar la lista
            ordenar.Ordenar(vector, tamanio);
            lstVexctorOrdenado.Items.Clear();
            for (int i = 0; i < tamanio; i++)
            {
                lstVexctorOrdenado.Items.Add(vector[i]);
            }
        }
    }
}
