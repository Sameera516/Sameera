using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSizeArray
{
    class Program
    {
        public  string JoinstrArray(string[] arr)
        {
            return string.Join(" ",arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[size];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter word {0}", i +1);
                arr[i] = Console.ReadLine();
            }
            Program p = new Program();
           
            Console.WriteLine(p.JoinstrArray(arr));
            Console.ReadKey();
        }
    }
}
