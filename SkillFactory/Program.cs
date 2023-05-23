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
using System.Xml.Schema;

namespace SkillFactory
{
    internal class Program
    {
        
        /// Unit 5.1.6
        
        static void Main(string[] args)
        { }
        static int[] GerArrayConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Enter the array element number: {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int x = 0;

            for (int i = 0; i < result.Length; i++)
            {

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        x = result[i];
                        result[i] = result[j];
                        result[j] = x;
                    }
                }
            }
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            return result;
        }
    } 
}