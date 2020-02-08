using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCSharp
{
    class Program
    {
        public static double average(int[] d,int l)
        {
            double sum = 0,av=0;
            for(int i=0;i<l;i++)
            {
                sum = sum + d[i];
            }
            av = (sum )/ l;
            return av;
        }
        static void Main(string[] args)
        {
            int[] d = new int[] {85,34,9,87,90 };
            int l = d.Length;
           Console.WriteLine("Average of marks is :" +average(d,l));
            Console.ReadKey();

        }
    }
}
