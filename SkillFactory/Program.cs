using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Unit 4.3.11

            {

                int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

                for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
                {
                    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                        
                        Console.Write(array[k, i] + " ");

                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
