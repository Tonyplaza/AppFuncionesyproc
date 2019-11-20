using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBilletes
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Ingrese el dinero: ");
            a=double.Parse(Console.ReadLine());
            cambio(a);
            Console.ReadKey();
        }
        static void cambio(double dolares)
        {
            int billete10 = (int)dolares / 10;
            Console.WriteLine("{0} billetes de 10 dolares",billete10);
            int billete5 = ((int)dolares % 10) / 5;
            Console.WriteLine("{0} billetes de 5 dolares", billete5);
            int monedadolar = ((int)dolares % 10) % 5;
            Console.WriteLine("{0} monedas de dolar ", monedadolar);
            double monedacentavos = ((dolares % 10) % 5)%1;
            Console.WriteLine("{0} centavos de dolar ", monedacentavos);
        }
    }
}
