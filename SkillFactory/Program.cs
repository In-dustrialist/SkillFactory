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
            ///Unit 5.1.5

            {
                string[] favcolors = {"","",""};

                for (int i = 0; i < favcolors.Length; i++)
                {
                    favcolors[i] = ShowColor();
                }

                foreach (string each in favcolors)
                { Console.WriteLine(each);  }
                

                Console.ReadKey();
            }

        }
        static string ShowColor()
        {
            Console.WriteLine("Enter your favotite color: ");

            var color = Console.ReadLine();

            switch (color)
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

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
            }
            return color;
        }

    }

}
