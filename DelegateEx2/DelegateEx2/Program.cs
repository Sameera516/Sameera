using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    class Program
    {
        public delegate void DeleventHandler();
        public static event DeleventHandler handler;

        static void Main(string[] args)
        {
            handler = handler + new DeleventHandler(Square);
            handler += new DeleventHandler(Circle);
            handler.Invoke();
            Console.ReadKey();
        }
        static void Circle()
        {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine("Area of Circle:{0}", ar);
        }
        static void Square()
        {
            int r = 5;
            int ar = r * r;
            Console.WriteLine("Area of Square:{0}", ar);
        }
        
    }
}
