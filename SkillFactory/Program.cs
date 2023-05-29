using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

        /// Unit 5.5.3

        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.Write("Write something: ");

                var str = Console.ReadLine();

                Console.Write("Specify echo depth: ");

                var deep = int.Parse(Console.ReadLine());

                for (int i = 0; i < deep; i++)
                {
                    if (str.Length > 2)
                    {
                        str = str.Remove(0, 2);
                        Echo("..." + str);
                    }
                    
                }
            }

            static void Echo(string saidword)
            {
                Console.WriteLine(saidword);
            }
        }
    }
}