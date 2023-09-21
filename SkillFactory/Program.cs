using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Obj
        {
            public string Name;
            public string Description;

            public static string Parent;
            public static int DaysInWeek;
            public static int MaxValue;

            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                MaxValue = 2000;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}