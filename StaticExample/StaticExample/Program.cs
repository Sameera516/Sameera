using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    class Sales
    {
        string productname;
        int quantity;
        double price;
        static int totalsales=0;
        int salesamount;
        public void salesAmount(string s,int q,int sa)
        {
            productname = s;
            quantity = q;
            salesamount = sa;



            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
