using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentiInches

{
    class Convert
    {
        double centimeter;
        
        public double Inch
        {
            get
            {
                return (centimeter * 2.54);
            }
            set
            {
                centimeter = value / 2.54;
            }
        }
            public void showCenti()
        {
            Console.WriteLine("Centimeter:" +centimeter );
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Convert c = new Convert();
            c.Inch = 19;
            Console.WriteLine(c.Inch);
            c.showCenti();
            Console.ReadKey();
        }
    }
}
