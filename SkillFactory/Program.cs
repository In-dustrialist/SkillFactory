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

namespace SkillFactory
{
    internal class Program
    {

        /// Unit 5.2.15 

        public static void Main(string[] args)
        {
            GetArrayFromConsole();
            Console.WriteLine("NEW ARRAY");
            SortArray(GetArrayFromConsole());
            Console.ReadKey();

            var array = GetArrayFromConsole();
            var sortedarray = SortArray(array);
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Enter the array element {0} ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            
            return result;
        }

        
        
        static int[] SortArray(int[] result)
        {

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            foreach (var el in result)
            {
                Console.WriteLine(el);
            }
        
            return result;
        } 

    }
}