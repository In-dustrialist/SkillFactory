using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace SkillFactory
{
    internal class Program
    {

        /// Unit 5.2.7 

        public static void Main(string[] args)
        {

            var (name, age) = ("Eugene", 33);

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);


            Console.Write("Enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("How old are you: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);

            var favcolors = new string[3];


            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Your favorite color: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();

        }
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("Your name is: {0} and Your age is: {1} \n Write your favorite color: ", username, userage);
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

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
    }
}