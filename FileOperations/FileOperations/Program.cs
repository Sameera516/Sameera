using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileOperations
{
    class Program
    {
       public string path = @"D:\New Folder\Example2.text";
        public void CreateFile()
        {
            
            if(!File.Exists(path))
             {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Enter your name:");
                    string name=Console.ReadLine();
                    Console.WriteLine("Enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter your ID:");
                    int ID = int.Parse(Console.ReadLine());
                    sw.WriteLine("name="+name);
                    sw.WriteLine("City=" +city);
                    sw.WriteLine("EMP ID=" + ID);
                    Console.ReadKey();

                }
            }

        }
        public void DisplayFile()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }
        }
        public void AppendSomeText()
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("Enter some text");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CreateFile();
            p.DisplayFile();
            p.AppendSomeText();
            p.DisplayFile();
            Console.ReadKey();
        }
    }
}
