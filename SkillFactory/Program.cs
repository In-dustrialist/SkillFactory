using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        enum DaysOfWeek : byte
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your age: ");
            byte Age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", Name, Age);

            Console.Write("What is your favorite day of week? ");
            DayOfWeek Day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", Day);

            Console.Write("Enter your birthdate: ");
            var birthdate = (Console.ReadLine());
            Console.WriteLine("Your birthdate is {0}", birthdate);

            Console.ReadKey();
        }
    }

} 
