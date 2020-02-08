using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArr
    {
        int[] temp;
        int j;
        public int[] ReverseA(int[] arr)
        {
            int i = 0;
            int j = arr.Length;
            while (j >= 0)
            {
                temp[i] = arr[j];
                i++;
                j--;
            }
            return temp;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            ReverseArr rev = new ReverseArr();
            int[] a1 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(rev.ReverseA(a1));
            Console.ReadKey();
            
        }
    }
}
