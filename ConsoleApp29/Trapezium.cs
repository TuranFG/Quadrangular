using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Trapezium : Quadrangular
    {
        private double h;
        /// <summary>
        /// Trapeze create method
        /// </summary>
        /// <param name="a"></the length of parallel side>
        /// <param name="b"></non-parallel sides>
        /// <param name="c"></the length of parallel side>
        /// <param name="h"></non-parallel sides>

        public Trapezium(double a, double c, double b, double h)  :base(a,b,c,b)
        {
            this.h = h;
        }
        public override double Area()
        {
            return h*(a+c)/2;
        }
    }
}
