﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoursSeconds
{
    class Time
    {
        double seconds;
        public double Hours
        {
            get
            {
                return seconds / 3600;
            }
            set
            {
                if(value<0||value>24)
                {
                    throw new Exception("value must be between 0 and 24");
                }
                seconds = value * 3600;
            } 
        }
        public void showSeconds()
        {
            Console.WriteLine("seconds:" + seconds);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Hours = 15;
            Console.WriteLine("hours:{0}", t.Hours);
            t.showSeconds();
            Console.ReadKey();
        }
    }
}
