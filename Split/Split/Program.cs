using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class SplitExam
    {
        public string[] splitString(string[] s1)
        {
            return s1.Split
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "hello", "world", "...." };
            SplitExam s = new SplitExam();
            s.splitString(arr);
        }
    }
}
