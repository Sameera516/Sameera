using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            { "Amma","Raj","Munna","Krish","Sajid","Chandu"};
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat", "mat" };
            al.SetRange(4, r);
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("sam");
            al.Add("samiii");
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            Console.WriteLine("Array after sorting:");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }

            al.RemoveRange(0, 4);
            Console.WriteLine("Array after using RemoverRange:");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
