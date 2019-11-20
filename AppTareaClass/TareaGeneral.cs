using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTareaClass
{
    public static class Formula
    {
        public static double x1(double a, double b, double c, out string msg)
        {
            double x1 = 0, d = 0;
            msg = "";
            if (a == 0) 
            {
                msg = "Error, division cero";
                return 0;
            }
            d = (b * b) - (4 * a * c);
            if (d<0)
            {
                msg = "Raices negativas no existen, error.";
                return 0;
            }
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        public static double x2(double a, double b, double c, out string msg)
        {
            double x2 = 0, d = 0;
            msg = "";
            if (a == 0) 
            {
                msg = "Error, division cero";
                return 0;
            }
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                msg = "Raices negativas no existen, error.";
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }
        public static double getx1(double a, double b, double c)
        {
            double x1 = 0, d = 0;
            if (a == 0)
                throw new Exception("Error, division cero");

            d = (b * b) - (4 * a * c);
            if (d < 0)
                throw new Exception("Raices negativas no existen, error.");
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        public static long billete10(int a)
        {
            int b;
            b = a / 10;
            return b;
        }
        public static long billete5(int a)
        {
            int b;
            b = (a % 10) / 5;
            return b;
        }
    }
}
