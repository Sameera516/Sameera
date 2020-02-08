using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleApUsingCalculateLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.No1 = 400;
            c.No2 = 50;
           Console.WriteLine( c.Add());
            Console.WriteLine(c.Difference());
            Console.WriteLine(c.Multiply());
            Console.WriteLine(c.Division());
            Console.ReadKey();

        }
    }
}
