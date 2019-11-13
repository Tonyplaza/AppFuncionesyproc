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
            for (int i=1; i<a; i++)
            {
                f = f * (i + 1);
            }
            return f;
        }
    }
}
