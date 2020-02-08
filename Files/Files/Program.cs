using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
           string path = @"D:\New Folder\hello.text";
         /*   if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Enter your Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your City");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter your ID:");
                    int ID = int.Parse(Console.ReadLine());
                    sw.WriteLine("Name:" + name);
                    sw.WriteLine("City" + city);
                    sw.WriteLine("ID:" +ID);
                    Console.ReadKey();
                }
            }*/
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }
        }
    }
}
