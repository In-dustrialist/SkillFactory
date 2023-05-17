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
                (string name, int age) anketa;

                Console.WriteLine("Your name is:");
                anketa.name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Im: ");
                anketa.age = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            }
        }
    }
}
