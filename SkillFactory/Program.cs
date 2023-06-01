using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SkillFactory
{
    class Program
    {
        public static void Main(string[] args)
        {
            FillTheForm();
            Console.ReadKey();
        }
        static (string Name, string LastName, int Age) FillTheForm()
        {
            (string Name, string LastName, int Age) User;

            Console.WriteLine("What is your name?");
            User.Name = (Console.ReadLine());

            Console.WriteLine("What is your last name?");
            User.LastName = Console.ReadLine();

            Console.WriteLine("How old are you?");

            do
            {
                User.Age = Convert.ToInt32(Console.ReadLine());
            }
            while (CheckValue(User.Age));

            Console.WriteLine("Do you have a Pet? Yes or No");
            var result = Console.ReadLine();

            if (result == "Yes")
            {
                Console.WriteLine("How many pets do you have?");
                int Pets;
                do
                {
                    Pets = Convert.ToInt32(Console.ReadLine());
                }
                while (CheckValue(Pets));
                GetInfo(Pets);
            }

            Console.WriteLine("How many favorite colors do you have? ");
            int Colors;
            do
            {
                Colors = Convert.ToInt32(Console.ReadLine());
            }
            while (CheckValue(Colors));
            GetInfo(Colors);

            Console.WriteLine($"\n Your Name is: {User.Name} \t  Your Last Name is: {User.LastName} \t You are {User.Age} years old");

            return User;
        }

        static string[] GetInfo(int num)
        {
            var result = new string[num];
            int n = 1;
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0}: ", n);
                n++;
                result[i] = Console.ReadLine();
            }
            return result;
        }

        static bool CheckValue(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("The value is incorrect, please try again!");
                return true;
            }
            else return false;
        }
    }
}