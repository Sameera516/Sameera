using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "hello", "good", "morning", "have", "a", "great", "day" };
            foreach (string i in array)
            {
                Console.WriteLine(i);
               
            }
            Console.ReadKey();
        }
    }
}
