using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Eugene";
            byte MyAge = 33;
            bool HaveIApet = false;
            double MyShoeSize = 42.5;
           
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            
            Console.WriteLine("\t Hello,\n World!"); //Task 3.5.2
            Console.WriteLine();

            Console.WriteLine($"Im {MyAge}"); //Task 3.5.3
            Console.WriteLine();

            var name = "Jane"; //Task 3.5.4
            var age = 27;
            var favcolor = "black";
            Console.WriteLine("{0} \n {1} \n {2}", name, age, favcolor);
            Console.WriteLine();

            string str = Console.ReadLine(); //Task 3.5.5
            Console.WriteLine();

            Console.ReadKey();
        }
        enum ProgramData //Task 3.4.3
        {
            Red = 100, 
            Yellow = 200, 
            Green = 300
        }
       
    }

}
