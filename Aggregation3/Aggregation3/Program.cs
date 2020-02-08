using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation3
{
    class Customer
    {
       public int cid;
        public string name;
        public string address;
        public void getDetals(int c,string nm,string adr)
        {
            cid = c;
            name = nm;
            address = adr;

        }
    }
    class BankAccount
    {
       public int accountnumber, balance;
        Customer ct;
       
        public void bankDetails(int ac,int bal,Customer c1)
        {
            accountnumber = ac;
            balance = bal;
            ct = c1;

        }
        public virtual double interestAmout(int t,double r)
        {


            double simpleinterest=(balance*t*r)/100;
            Console.WriteLine("Simple Interest:");
            return simpleinterest;
        }
        public void display()
        {
            Console.WriteLine("Cusomer Id :" + ct.cid);
            Console.WriteLine("Cusomer Name :" + ct.name);
            Console.WriteLine("Cusomer address :" + ct.address);
            Console.WriteLine("Bank account :" + accountnumber);
            Console.WriteLine("bank Balance :" + balance);
        }
    }
    class FixedAccount : BankAccount
    {
        public override double interestAmout(int t,double r)
        {
             
            double s1 = (balance * t * r) / 100;
            double fi = s1 * 3 / 100;
            double total = s1 + fi;
            Console.WriteLine("Simple Interest+ 3% additional :");
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer cc = new Customer();
            cc.getDetals(1, "sameera", "chennai");
            BankAccount b = new BankAccount();
            b.bankDetails(10110, 20000, cc);
            b.display();
            Console.WriteLine(b.interestAmout(2, 3));
            FixedAccount f = new FixedAccount();
            Console.WriteLine(f.interestAmout(2, 3));
            Console.ReadKey();
        }
    }
}
