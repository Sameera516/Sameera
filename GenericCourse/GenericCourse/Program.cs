using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCourse
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
            List<Course> courselist = new List<Course>(); 
            courselist.Add(new Course
            {
                Cid =1,
                Cname ="c#",
                StartDate =DateTime.Today,
                Fees =6000
            });
           
            courselist.Add(new Course
            {
                Cid = 2,
                Cname = "c++",
                StartDate = DateTime.Parse("01-01-2020"),
                Fees = 5000
            });
            
            courselist.Add(new Course
            {
                Cid = 3,
                Cname = "python",
                StartDate = Convert.ToDateTime("01-01-2020"),
                Fees = 6000
            });
            foreach(Course cr in courselist)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
            Console.ReadKey();
        }
    }
}
