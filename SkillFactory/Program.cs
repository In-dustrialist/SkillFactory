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
            ///Unit 4.3.13

            {

                int[][] array = new int[3][];

                array[0] = new int[2] { 1, 2 };
                array[1] = new int[3] { 1, 2, 3 };
                array[2] = new int[5] { 1, 2, 3, 4, 5 };

                foreach (var i in array)
                {
                    foreach (var j in i)
                    {
                        Console.Write(j + " ");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}