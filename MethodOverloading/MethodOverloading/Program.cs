using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Overloading
    {
        public string area(int side)
        {
            int ar = side * side;
            return string.Format("Square Area={0}", ar);
        }
        public string area(int l,int b)
        {
            int ar = l * b;
            return string.Format("Reactangle Area={0}", ar);
        }
        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("Area of Circle={0}", ar);

        }
        public string area(double b,int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("Traingle Area={0}", ar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overloading o = new Overloading();
            Console.WriteLine(o.area(5));
            Console.WriteLine(o.area(6,8));
            Console.WriteLine(o.area(7.77777));
            Console.WriteLine(o.area(5.55554,3));
            Console.ReadKey();

        }
    }
}
