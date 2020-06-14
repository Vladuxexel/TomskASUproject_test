using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomskAsyProject_Test
{
    static class Model
    {
        public static double Function(int degree, double a, double x, double b, double y, int c)
        {
            double result;

            result = a * Math.Pow(x, degree) + Math.Pow(b, (degree - 1)) * y + c;
            
            return result;
        }
    }
}
