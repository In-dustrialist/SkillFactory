using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Helper
        {
            static void Swap(ref int x, ref int y)
            {
                int t = x;
                x = y;
                y = t;

            }

            static void Main(string[] args)
            {
                int num1 = 3;
                int num2 = 58;

                Helper.Swap(ref num1, ref num2);
                Console.WriteLine(num1);
                Console.WriteLine(num2);
            }
        }
    }
}