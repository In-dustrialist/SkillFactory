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
            ///Unit 4.4.5

            {
                (string Name, string Type, double Age, int NameCount) Pet;

                Console.Write("Pet name is: ");
                Pet.Name = (Console.ReadLine());
                Console.WriteLine();

                Console.Write("Type of Pet is: ");
                Pet.Name = (Console.ReadLine());
                Console.WriteLine();

                Console.Write("Pet age is: ");
                Pet.Name = (Console.ReadLine());
                Console.WriteLine();

                Console.Write("Pet name count: ");
                Pet.NameCount = Pet.Name.Length;
                Console.WriteLine("{0}", Pet.NameCount);

                Console.ReadKey();
            }
        }
    }
}
