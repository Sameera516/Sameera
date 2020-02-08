using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExamples
{
    class Program
    {
        private static void LambdaExpression()
        {
            Func<int, int> Cube = a => a * a * a;
            Console.WriteLine("Enter any number");
            int cr = int.Parse(Console.ReadLine());
            Console.WriteLine(Cube(cr));
        }
        private static void LamdaLinqOrder()
        {
            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);
            Console.WriteLine(string.Join("", sort));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            LambdaExpression();
            LamdaLinqOrder();
            Console.ReadKey();
        }
    }
}