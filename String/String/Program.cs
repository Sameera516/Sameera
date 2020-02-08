using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "hello world";
            Console.WriteLine(data);
            string a = data.Insert(6, "My ");
            string bn = " you are so nice.";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a,bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "anand", "raju", "kumar", "vijay" };
            foreach (string st in names){
                Console.WriteLine(st);
            

            }
            string allnames = string.Join(" ,", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to the c sharp";
            string[] words = st1.Split();
            foreach (string s in words)
            {
                Console.Write(s);
            }
                int nx = string.Compare("hello", "hello");
                Console.WriteLine("Comparasion is {0}", nx);
                Console.ReadKey();
            
        } 
    }
}
