using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateExample
{

    class Program
    {

        public delegate void delmethod(int x, int y);
        public void Add_method(int x, int y)
        {
            Console.WriteLine("Addition:");
            Console.WriteLine(x + y);
        }
        public void Sub_method(int x, int y)
        {
            Console.WriteLine("Subtration");
            Console.WriteLine(x - y);
        }
        public void Square_area(int x, int y)
        {
            Console.WriteLine("Square Area :" + (x * y));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            delmethod del = new delmethod(p.Add_method);
            del(10, 20);
            delmethod del2 = new delmethod(p.Sub_method);
            del2(30, 10);
            delmethod del3 = new delmethod(p.Square_area);
            del3(20, 20);
            Console.ReadKey();

        }
    }
}
