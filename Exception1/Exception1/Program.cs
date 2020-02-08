using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
    class ex
    {
         public static void div(int x,int y)
        {
            try
            {
              
                int z = x / y;
                Console.WriteLine(z);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ex e = new ex();
            ex.div(20, 2);
            ex.div(20, 0);
            Console.ReadKey();
           
        }
    }
}
