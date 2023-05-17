using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            ///Unit 4.4.2

            {
                var anketa = (name: "Eugene", age: 33);
                Console.WriteLine("My name is {0} and Im {1}", anketa.name, anketa.age);
                Console.WriteLine();

                Console.Write("Your name is: ");
                anketa.name = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Im: ");
                anketa.age = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            }
        }
    }
}
