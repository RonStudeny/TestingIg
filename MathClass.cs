using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingIg
{
    public class MathClass
    {
        public double  Discriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public (double, double) Roots(double a, double b, double c)
        {
            double res1 = (-b + Math.Sqrt(Discriminant(a, b, c))) / 2 * a;
            double res2 = (-b - Math.Sqrt(Discriminant(a, b, c))) / 2 * a;

            return(res1, res2);
        }
    }
}
