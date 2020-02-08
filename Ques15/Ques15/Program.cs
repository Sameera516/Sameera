using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques15
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
    class EmpCollections
     {
        
            List<Employee> IstEmp = new List<Employee>();
        //EmpCollections e = new EmpCollections();
           
        public void addData(int id, string name, string Design, int Sal)
        {
            IstEmp.Add(new Employee
            {
                Eid = id,
                Ename = name,
                Designation = Design,
                Salary = Sal
            });
                
        }
        public void removeData(int i)
        {
            IstEmp.RemoveAt(i);
        }
    
        
        public void show()
            {
                foreach (Employee e1 in IstEmp)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", e1.Eid, e1.Ename, e1.Designation, e1.Salary);
                }
            }
        static void Main(string[] args)
        {
            EmpCollections ee = new EmpCollections();
            ee.addData(2222, "xxxx", "software", 30000);
            ee.addData(1111, "dddd", "software", 22222);
            ee.addData(1331, "ddii", "software", 88888);
            ee. show();
            ee.removeData(1);
            ee.show();
            Console.ReadKey();
          
         

        }
    }
}
