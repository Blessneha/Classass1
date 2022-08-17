using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    internal class Shapes
    {
        public void area(int l,int w)
        {
            int res = l * w;
            Console.WriteLine("The area of rectangle: " + res);
        }

        public void area(double b,double h)
        {
            double res = b * h;
            Console.WriteLine("The area of triangle: " + res);
        }

        public void area(double x)
        {
            double res = 3.14 * x * x;
            Console.WriteLine("The area of circle is " + res);
        }

        public void area(int l)
        { 
         int res=l * l;
            Console.WriteLine("The area of square is "+res);

        }
    }
}
