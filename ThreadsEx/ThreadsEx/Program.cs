using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsEx
{
    

    class Program
    {
        public static void getNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(400);
            }
        }
        public delegate void getmethods();
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getNumbers);
            Thread th = new Thread(tsd);
            th.Start();
            //ThreadStart td = new ThreadStart(getNumbers);
            //Thread t = new Thread(td);
            //t.Start();
            
           
            Console.ReadKey();
        }
       


        
    }
}
