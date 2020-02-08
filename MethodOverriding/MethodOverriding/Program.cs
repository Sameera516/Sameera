using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Base
    {
        public virtual void show()
        {
            Console.WriteLine("base class");
        }
    }
    class Derived:Base
    {
        public override void show()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            Base b = new Base();
            b.show();
                        d.show();
            Console.ReadKey();
        }
    }

}
