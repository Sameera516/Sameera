using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
   abstract  class Bike
    {
     abstract  public void bikeColor();
    }
    interface Idrone
    {
        void show();
    }
    class Multiple:Bike,Idrone
    {
        public override void bikeColor()
        {
            Console.WriteLine("The class method is defined");
         }
        public void show()
        {
            Console.WriteLine("The interface method is defined");
        }
   

        static void Main(string[] args)
        {
            Multiple m = new Multiple();
            m.bikeColor();
            m.show();
            Console.ReadKey();

        }
    }
}
