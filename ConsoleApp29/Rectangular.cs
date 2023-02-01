using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Rectangular : Quadrangular
    { /// <summary>
    /// Rectangular create method
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
        public Rectangular (double a,double b)  : base(a, b, a,b)
        {

        }
        public override double Area()
        {
            double area = a * b;
            return area;    
        }
    }
}
