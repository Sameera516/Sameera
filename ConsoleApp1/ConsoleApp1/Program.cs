using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trainee
    {
        string name,  address;
        int age, id;
        public void getData(string nm,string adr,int id,int ag)
        {
            name = nm;
            address = adr;
            this.id = id;
            age = ag;
        }
        public void showData()
        {
            Console.WriteLine("Name: {0} Address: {1} ID: {2} Age: {3}" , name, address, id, age);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trainee tr1 = new Trainee();
            tr1.getData("Saeera", "Palakl", 8440, 21);
            tr1.showData();
            geTrobj();
            Console.ReadKey();
        }

        private static void geTrobj()
        {
            Trainee tr = new Trainee();
            tr.getData("Sameera", "Palakol", 844810, 21);
            tr.showData();
        }
        
}
