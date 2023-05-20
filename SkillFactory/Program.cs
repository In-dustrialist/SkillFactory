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
            ///Unit 4.5.3

            {
                (string FirstName, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;

                Console.Write("Enter your first name: ");
                User.FirstName = (Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter your last name: ");
                User.LastName = (Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter your login: ");
                User.Login = (Console.ReadLine());
                Console.WriteLine();
                
                int LoginLength = User.Login.Length;
                Console.Write("Your login length: {0}", LoginLength);
                Console.WriteLine();

               


                Console.ReadKey();
            }
        }
    }
}
