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
            ///Unit 4.3.9

            {

                int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };

                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
