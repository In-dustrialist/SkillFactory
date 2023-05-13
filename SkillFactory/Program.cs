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
            ///Task 4.2.13

            Console.WriteLine("Cycle while");
            int t = 0;

           do
            {
             
                Console.WriteLine($"Iteration {t}");
                Console.WriteLine("Write your favorite color");
                
                switch (Console.ReadLine())
                {
               
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        t++;
                        break;


                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        t++;
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        t++;
                        break;

                }
                
           } while (t < 0);
            Console.ReadKey();
        }
    }
}
