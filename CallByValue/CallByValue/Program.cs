using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue
{
    class Program
    {
        public static void showdata(int m,int n)
        {
            double sum = m + n;
            Console.WriteLine(sum);
            m += 5;
            n += 5;
            Console.WriteLine("M= {0} , N= {1}",m,n);
           

        }
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;
            showdata(a, b);
            Console.WriteLine("a={0},b={1}",a,b);
             Console.ReadKey();

        }
    }
}
