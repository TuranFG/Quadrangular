using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public abstract class Quadrangular
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public Quadrangular (double a, double b, double c, double d)
        {
            this.a = a; 
            this.b = b; 
            this.c = c; 
            this.d = d; 
        }
        public double Perimeter ()
        {
            return a + b + c + d;

                }

        public abstract double Area();

        public override string ToString()
        {
            return @$"<<{this.GetType().Name}>>
                            Perimeter:{this.Perimeter()}
                            Area :{this.Area()}";
        }
        }
}
