using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SkillFactory
{
    internal class Program
    {

        /// Unit 5.3.2

        public static void Main(string[] args)
        {
            //var somename = "Eugene";
            var age = "12";

            //Console.WriteLine(somename);
            Console.WriteLine(age);

            //GetName(somename);
            ChangeAge(age);

            //Console.WriteLine(somename);
            Console.WriteLine(age);
        }

        static void GetName(string name)
        {
            Console.WriteLine("Your name is: ");
            name = Console.ReadLine();

        }

        static void ChangeAge(string age)
        {
            Console.WriteLine("Your age is: ");
            age = Console.ReadLine();

        }

    }


}