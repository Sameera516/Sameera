using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousEx
{
    class Program
    {
        public delegate void Mydelg(string s);
        static void Main(string[] args)
        {
            //anonymous method
            /*  Mydelg delgt = a => Console.WriteLine(a);
              delgt("helloo......");
              Func<int, double, double> Calc = (x, y) => x * y;
              Console.ReadKey();*/
            Func<int, int, double> triangle = (x, y) => 0.5 * x * y;
            Console.WriteLine(triangle(4, 5));
            Console.ReadKey();
        
        }
    }
}
