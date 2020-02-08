using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNLastName
{
    class String1
    {
        string firstname, lastname;
        public string Firstname
        {
            get
            { return firstname; }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;

            }
            set
            {
                lastname = value;
            }
        }
        public String1(string fname, string lname)
        {
            firstname = fname;
            lastname = lname;
        }
        public string fullName()
        {
            string x = firstname + " " + lastname;
            return x;
        }
        class Program
        {
            static void Main(string[] args)
            {
                String1 s = new String1("sameera", "sheik");
                Console.WriteLine(s.fullName());
                Console.ReadKey();
            }
        }
    }
}
