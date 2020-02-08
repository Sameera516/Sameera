using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStatic
{
    class Program
    {
        void nonStatic()
        {
            Console.WriteLine("Non Static Method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.nonStatic();
            Console.ReadKey();
        }
    }
}
