using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            var stringcol = new SomeSample<string>();
            stringcol[0] = "This is a indexer demo";
            Console.WriteLine(stringcol[0]);
            stringcol[1] = "hello world";
            Console.WriteLine(stringcol[1]);
            var stdetails = new SomeSample<Student>();
            stdetails[0] = new Student
            {
                ID = 777,
                StudentName = "sameera",
                Course = "web apps"
            };
            stdetails[1] = new Student
            {
                ID = 111,
                StudentName = "sam...",
                Course = "python"
            };
            Console.WriteLine("{\0}\t{1}\t{2}", stdetails[0].ID, stdetails[0].StudentName, stdetails[0].Course);
            Console.WriteLine("{\0}\t{1}\t{2}", stdetails[1].ID, stdetails[1].StudentName, stdetails[1].Course);
            Console.ReadKey();
        }
    }
}
