using Microsoft.Win32;
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

        /// Unit 5.5.8

        class MainClass
        {
            public static void Main(string[] args)
            {
                Console.Write("Number: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Pow Number: ");
                byte PowNumber  = Convert.ToByte(Console.ReadLine());

                Console.Write("Result: ");
                Console.WriteLine(PowerUp(Number, PowNumber));
            }

            private static int PowerUp(int N, byte pow)
            {
                if (pow == 0)
                {
                   return 1;
                }
                else
                {

                    if (pow == 1)
                    {
                        return N;
                    }
                    else
                    {
                        int s = N;
                        for (int i = pow; i > 1; i--)
                        {
                            s = N * s;
                        }
                        Console.WriteLine(s);
                    }
                    Console.ReadKey();
                }
                return N;
            }
        }
    }
}