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
            const string MyName = "Eugene";
            
            Console.WriteLine(MyName);
            Console.WriteLine("\t Hello? \n World");
            Console.WriteLine("\t Im 33");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");
            
            Console.WriteLine("GitHub");

            Console.ReadKey();
        }
    }
}
