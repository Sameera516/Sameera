using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    class StringExample2
    {
        public void FirstAndLastName(string fn,string ln)
        {
            string s1;
            s1 = string.Concat(fn, ln);
            Console.WriteLine(s1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringExample2 se = new StringExample2();
            se.FirstAndLastName("sameera ", "sheik");
            Console.ReadKey();
        }
    }
}
