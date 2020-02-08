using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{ 
    class Cal
    {
        public int a, b;
        public Cal()
        {
            Console.WriteLine("Default constructor:Below are the mathamatical operations");
        }
        public Cal(int m,int n)
        {
            a = m;
            b = n;
        }
        public int add()
        {
            
            return a + b;
        }
        public int sub()
        {
            return a - b;
        }
        public int mul()
        {
            return a * b;
        }
        public int div()
        {
            return (a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            Cal c1 = new Cal(10, 20);
            Cal c2 = new Cal(20, 10);
            Cal c3 = new Cal(10, 20);
            Cal c4 = new Cal(20, 10);
            Console.WriteLine( "Addition of two numbers :"+c1.add());
            Console.WriteLine("Subtraction of two numbers:" + c2.sub());
            Console.WriteLine("multiplication of two numbers:" + c3.mul());
            Console.WriteLine("division of two numbers:" + c4.div());
            Console.ReadKey();
        }
    }
}
