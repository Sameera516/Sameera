using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Func<int, int, int> add = (x, y) => ( x + y);
            Console.WriteLine("add=" + add(10, 20));
             Multiply(10, 20);
            List<Student> lst = new List<Student>
            {
                new Student{ID=1,StudentName="arvind",Course="C#"},
                  new Student{ID=2,StudentName="vijay",Course="python"},
                   new Student{ID=3,StudentName="pradeep",Course="java"},
                  new Student{ID=4,StudentName="Baji",Course="c++"},

            };
            Predicate<Student> fst = x => x.ID == 2;
            Student st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentName, st.Course);
            Console.ReadKey();
        }
    }
}
