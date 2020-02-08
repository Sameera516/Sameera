using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class Course
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public DateTime StartDate { get; set; }
        public int Fees { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Course> dic = new Dictionary<int, Course>();
             dic.Add(1, new Course
             {
                 Cid = 11,
                 Cname = "ruby",
                 StartDate = DateTime.Today,
                 Fees = 2000,

             });
            dic.Add(2, new Course
            {
                Cid = 22,
                Cname = "java",
                StartDate = DateTime.Today,
                Fees = 3000,

            });
            dic.Add(3, new Course
            {
                Cid = 33,
                Cname = "c-sharp",
                StartDate = DateTime.Today,
                Fees = 5000,

            });
            foreach(KeyValuePair<int,Course> cr in dic)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", cr.Key, cr.Value.Cid, cr.Value.Cname, cr.Value.StartDate, cr.Value.Fees);

            }
            Console.ReadKey();

        }
    }
}
