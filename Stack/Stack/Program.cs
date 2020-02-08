using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            Console.WriteLine("Stack items");
            stk.Push("chocolate");
            stk.Push("Biscuits");
            stk.Push("cakes");
            stk.Push("icecremes");
            foreach(string s in stk)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Queue items");
            Queue q = new Queue();
            q.Enqueue("Chocolates");
            q.Enqueue("Biscuits");
            q.Enqueue("cakes");
            q.Enqueue("Icecremes");
            foreach(string s in q)
            {
                Console.WriteLine(s);
            }

            SortedList sl = new SortedList();
            sl.Add("Zameer", 234);
            sl.Add("anand", 123);
            sl.Add("bhim", 646);
            foreach(string k in sl.Keys)
            {
                Console.WriteLine(k);
            }

            Console.ReadKey();
        }
    }
}
