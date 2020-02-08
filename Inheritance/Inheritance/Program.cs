using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class vehicle
    {
        public void showVehicle()
        {

            Console.WriteLine("this is vehicle");
        }
    }
    class RoadwayVehicles:vehicle
    {
        public virtual void show()
        {
            Console.WriteLine("Road way vehicles");
        }
    }
    class Train:RoadwayVehicles
    {
        public void showTrain()
        {
            Console.WriteLine("Trains");
        }
    }
    class Ship:RoadwayVehicles
    {
        public override void show()
        {
            Console.WriteLine("Ships");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RoadwayVehicles r = new RoadwayVehicles();
            Ship s = new Ship();
            vehicle v = new vehicle();
            Train t = new Train();
            r.show();
            t.showVehicle();
            r.showVehicle();
            v.showVehicle();
            s.show();
            Console.ReadKey();
        }
    }
}
