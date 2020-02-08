using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation2
{
    class product
    {
        public int pid;
       public string name;
        public int price;
        public void getPDetails(int id,string nm,int pr)
        {
            pid = id;
            name = nm;
            price = pr;
        }
    }
    class Category
    {
        int cid;
        string discription;
        product pd;
        public void getCDetails(int id,string dis,product p)
        {
            cid = id;
            discription = dis;
            pd = p;
        }
        public void display()
        {
            Console.WriteLine("Product Id:" +pd.pid);
            Console.WriteLine("Product name:" + pd.name);
            Console.WriteLine("Product name:" + pd.price);
            Console.WriteLine("Category Id:" +cid );
            Console.WriteLine("category discription:" + discription);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product();
            p1.getPDetails(1, "Thumbsup", 20);
            Category c1 = new Category();
            c1.getCDetails(2, "Good", p1);
            c1.display();
            Console.ReadKey();
        }
    }
}
