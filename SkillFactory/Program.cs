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

        /// Unit 5.3.3

        public static void Main(string[] args)
        {
            var someAge = 1;
            Console.WriteLine(someAge);
            MyAge(ref someAge);
            Console.WriteLine(someAge);

        }

        static void MyAge(ref int age)

        {
            Console.WriteLine();
            age = Convert.ToInt32(Console.ReadLine());

        }
    }
}