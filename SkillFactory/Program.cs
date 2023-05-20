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
            ///Unit 4.5.6

            {
                for (int anketa = 0; anketa < 3; anketa++)
                {

                    (string FirstName, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;

                    Console.WriteLine("Enter your first name: ");
                    User.FirstName = (Console.ReadLine());


                    Console.WriteLine("Enter your last name: ");
                    User.LastName = (Console.ReadLine());


                    Console.WriteLine("Enter your login: ");
                    User.Login = (Console.ReadLine());


                    int LoginLength = User.Login.Length;
                    Console.WriteLine("Your login length: {0}", LoginLength);


                    Console.WriteLine("Do you have a Pet? Yes or Not?");
                    var Pet = Console.ReadLine();
                    if (Pet == "Yes") { User.HasPet = true; }
                    if (Pet != "Yes") { User.HasPet = false; }

                    Console.WriteLine("Enter your age: ");
                    User.Age = Convert.ToDouble(Console.ReadLine());


                    User.favcolors = new string[3];
                    Console.WriteLine("Enter your three favorite colors: ");
                    for (int i = 0; i < User.favcolors.Length; i++) { User.favcolors[i] = Console.ReadLine(); }

                }

                Console.ReadKey();
            }
        }
    }
}
