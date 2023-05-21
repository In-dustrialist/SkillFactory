using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            ///Unit 5.1.4

            {
                Console.WriteLine("Test new Function");
              
                Console.ReadKey();
            }
            
        }
        static void ShowColor()
        {
            Console.WriteLine("Enter your favotite color: ");

            var color = Console.ReadLine();

            switch (Console.ReadLine())
            {
                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
