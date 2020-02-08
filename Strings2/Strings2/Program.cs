using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("Helloo");
            Console.WriteLine(stb);
            stb.Append(844810);
            Console.WriteLine("Appended string :{0}", stb);
            int i = stb.Capacity;
            Console.WriteLine("string capacity :{0}",i);
            stb.Insert(6, " world ");
            Console.WriteLine("String inserted at 6 :{0}", stb);
            stb.Remove(5, 1);//(from which character , how many characters to be removed
            Console.WriteLine("String after removed:{0}", stb);
            stb.Replace("lo","arious");//(from which character to,what character to be replaced)
            Console.WriteLine("string after replacement:{0}", stb);
            stb.Clear();
            Console.WriteLine("after clear :{0}", stb);

            Console.ReadKey();

           
        }
    }
}
