using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Unit 4.3.6
           
            {
                Console.WriteLine("What is your name?");

                var name = Console.ReadLine();

                Console.WriteLine("Spell your name : ");

                foreach (var ch in name)
                {
                    Console.Write(ch + " ");
                }

                Console.WriteLine("Last char in your name: {0}", name[0]);

            }
            Console.ReadKey();
            }
    }
}
