using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalAndStatis
{
    class sample
    {
        int no=0;
        static int count=0;
        public sample()
        {
            no++;
            count++;
            Console.WriteLine("normal no:{0} static count:{1}", no, count);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample s = new sample();
            sample s1 = new sample();
            sample s2= new sample();
            sample s3 = new sample();
            Console.ReadKey();
        }
    }
}
