using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNotas.classNotas
{
    class ClasesNotas
    {
        public static string Aleatorios(out double sum, out double prom)
        {
            StringBuilder nota = new StringBuilder();
            sum = 0;
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                int num = r.Next(20, 50);
                nota.Append(num + "   ");
                sum = sum + num;
            }
            prom = sum / 30;
            return nota.ToString();
        }
    }
}
