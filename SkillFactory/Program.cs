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

                int[] arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

                int x = 0;

                {

                    for (int i = 0; i < arr.Length; i++)
                    {
                        x = x + arr[i];
                    }
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}