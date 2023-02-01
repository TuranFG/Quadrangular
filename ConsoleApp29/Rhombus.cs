using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Rhombus : Quadrangular
    {
        public double angle;
        /// <summary>
        /// Rhombus create method
        /// </summary>
        /// <param name="a"></side>
        /// <param name="angle"></angle>
        public Rhombus(double a, double angle): base(a, a, a, a)
        {
            this.angle = angle;
        }
        public override double Area()
        {
            double pi = Math.Round(Math.PI,2);
            double rad = angle * pi/180;
            double sin=Math.Round(Math.Sin(rad),2);
            return sin * a * a;
        }
    }
}
