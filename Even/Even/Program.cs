using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class EvenTotals
    {
        public int EvenSum(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EvenTotals e = new EvenTotals();
           // int[] arr = { 10, 22, 11, 2, 3, 4, 1 };
            int[] ar1 = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter num{0}", i + 1);
                ar1[i] =Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine(e.EvenSum(ar1));
            Console.ReadKey();
        }
    }
}
