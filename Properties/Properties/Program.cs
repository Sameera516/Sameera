using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        string name,firstname,lastname;
        int idno;
        string course;
        DateTime joiningdate;

        public Student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;

        }

         
        public string Name
        {
            get { return string.Format("firstname: "+firstname+"lastname :"+lastname); }
            
        }
        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            set { course = value; }
            get { return course; }
        }
        public DateTime Joiningdate
        {
            get { return joiningdate;
           }
            set { joiningdate = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
            Student s1 = new Student("sameera","sheik");
            s1.Idno = 844810;
            s1.Course = "c#";
            s1.Joiningdate = DateTime.Parse("01-21-2020");
            Console.WriteLine("name is {0}\n ID is {1}", s1.Name, s1.Idno);
            Console.WriteLine("Course:{0}\n Joining Date is {1}", s1.Course, s1.Joiningdate);
            Console.ReadKey();

        }
    }
}
