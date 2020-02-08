using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4, b = 2;
            x -= b /= x * b;
            Console.WriteLine(x + " " + b);
            Console.ReadLine();
        }
    }
}
