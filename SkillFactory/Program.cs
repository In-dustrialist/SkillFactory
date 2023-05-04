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

            Console.ReadKey();
        }
    }
}
