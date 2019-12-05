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
        int[] num = new int[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            for (int i=0; i<19;i++)
            {
                num[i] = ordenar.agregar();
                lstNum.Items.Add(num[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
