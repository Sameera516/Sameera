using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    interface Lairborne
    {
        void fly();
    }
    class Helicopter:Lairborne
    {
        public void fly()
        {
            Console.WriteLine("Helicopter is flying");
        }
    }
    class Aeroplane:Lairborne
    {
       public void fly()
        {
            Console.WriteLine("Aeroplane is flying..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lairborne l = new Helicopter();
            l.fly();
            l = new Aeroplane();
            l.fly();
            Console.ReadKey();
        }
    }
}
