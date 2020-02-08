using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleShape
{
    abstract class Shape
    {
      public  abstract double Area(double r);

    }
    class Circle:Shape
    {
        public override double Area(double r)
        {
            double Carea;
            Carea = (3.14) * r * r;
            Console.WriteLine("Area of Circle having radius {0}:", r);
            return Carea;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
           Console.WriteLine( c.Area(5));
            Console.ReadKey();

        }
    }
}
