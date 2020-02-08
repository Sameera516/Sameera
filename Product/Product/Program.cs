using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   /* class product
    {
        public int[] ID = new int[3];

        public int this[int index]
        {
            get
            {
                return ID[index];
            }
            set
            {
                ID[index] = value;
            }
        }
        public string[] Name = new string[3];

        public string this[int index]
        {
            get
            {
                return Name[index];
            }
            set
            {
                Name[index] = value;
            }
        }
       
        public int Price{ get; set; }*/
    //}
    class Program
    {
        static void Main(string[] args)
        {
            String c = "Hello i love CSharp";

            Boolean var;
            var = c.StartsWith("hello");
            Console.WriteLine(var);
            Console.ReadKey();
        }
    }
}
