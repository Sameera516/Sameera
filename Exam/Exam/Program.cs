using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Exam
    {
        string studentName, StudentClass;
        int maths, science, social;
        public void getData(string sname, string sclass, int mts, int sc, int so)
        {
            studentName = sname;
            StudentClass = sclass;
            maths = mts;
            science = sc;
            social = so;
        }
        public void showData()
        {
            Console.WriteLine("Student Name:" + studentName);
            Console.WriteLine("Student class:" + StudentClass);
            Console.WriteLine("Maths marks:" + maths);
            Console.WriteLine("Science marks:" + science);
            Console.WriteLine("social marks" + social);

        }
        public void showPercent()
        {
            //maths = mat;
            //science = sci;
            //social = sol;
            int sum = 0;
                float percent = 0;
            sum = maths + science + social;
            percent = (sum*100)/300;
            Console.WriteLine("Percentage: " + percent+"%");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exam e1 = new Exam();
            e1.getData("Sameera", "Tenth", 51, 80, 85);
            e1.showData();
            e1.showPercent();
            Console.ReadKey();
        }
    }
}
