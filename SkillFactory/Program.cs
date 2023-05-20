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
            ///Unit 4.5.5

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
                Console.WriteLine();

                Console.Write("Do you have a Pet? Yes or Not?");
                var Pet = Console.ReadLine();
                if (Pet == "Yes"){ User.HasPet = true; Console.WriteLine("Yes"); }
                if (Pet != "Yes") { User.HasPet = false; Console.WriteLine("No"); }

                Console.Write("Enter your age: ");
                User.Age = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                User.favcolors = new string [3];
                Console.Write("Enter your three favorite colors: ");
                for (int i = 0; i < User.favcolors.Length; i++) { User.favcolors[i] = Console.ReadLine(); }
                Console.WriteLine();


                Console.ReadKey();
            }
        }
    }
}
