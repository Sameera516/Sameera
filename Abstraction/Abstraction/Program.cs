using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Hello
    {
        public abstract void show();
    }
    class Diot : Hello
    {
        public override void show()
        {
            Console.WriteLine("Hello.... Good Morning");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diot d = new Diot();
            d.show();
            Console.ReadKey();

        }
    }
}
