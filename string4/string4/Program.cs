using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string4
{
    class StringExample
    {
        public void stringName(string[] array)
        {
            foreach(string i in array)
            {
                Console.Write(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "hello ", "good ", "morning ", "have ", "a ", "nice ", "day " };
            StringExample s = new StringExample();
            s.stringName(arr);
            Console.ReadKey();
        }
    }
}
