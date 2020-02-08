using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Dept
    {
        public int d_id;
        public string d_name;
        public void department(int i,string name)
        {
            d_id = i;
            d_name = name;
        }
    }
    class Employee
    {
        public int id;
        string name, address;
        Dept dt;
        public void employ(int i, string nm, string add, Dept d)
        {
            id = i;
            name = nm;
            address = add;
            dt = d;
        }


        public void display()
        {
            Console.WriteLine("empId:" + id+"emp name:"+name+"address"+address+"Dept Id"+dt.d_id,"Dept Name:"+dt.d_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dept d = new Dept();
            d.department(11, "maths");
            Employee e = new Employee();
            e.employ(1, "sam", "palakol", d);
            e.display();
            Console.ReadKey();

        }
    }
}
