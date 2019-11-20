using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTareaClass
{
    public static class Formula
    {
        public static double x1(double a, double b, double c)
        {
            double x1 = 0, d = 0;
            d = (b * b) - (4 * a * c);
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        public static double x2(double a, double b, double c)
        {
            double x2 = 0, d = 0;
            d = (b * b) - (4 * a * c);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }
    }
}
