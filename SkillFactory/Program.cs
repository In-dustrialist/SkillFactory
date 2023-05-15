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
            ///Unit 4.3.7

            {
                Console.WriteLine("What is your name?");

                var name = Console.ReadLine();

                Console.WriteLine("Spell your name from the other end: ");

                int i = name.Length;

                while (i != 0)

                {
                    Console.Write("{0} ", name[i - 1]);
                    i--;
                }

            }
            Console.ReadKey();
        }
    }
}
