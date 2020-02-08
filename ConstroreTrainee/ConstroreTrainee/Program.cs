using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstroreTrainee
{
    class Car
    {
        string regno, model, color;
        int price;
        public Car() { }
        public Car (string reg)
        {
            regno = reg;

        }
        public Car(string reg,string md)
        {
            regno = reg;
            model = md;
        }
        public Car(string reg,string md,string col,int price)
        {
            regno = reg;
            model = md;
            color = col;
            this.price = price;


        }
        public void show()
        {
            Console.WriteLine("regno:{0},model:{1},color:{2},price:{3}", regno, model, color, price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.show();
            Car c1 = new Car("ADPIJ999");
            c1.show();
            Car c2 = new Car("ap37ddd", "ee32", "black", 50000);
            c2.show();
            Console.ReadKey();
        }
    }
}
