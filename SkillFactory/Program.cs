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

        /// Unit 5.2.18

        public static void Main(string[] args)
        {
            int[] array = new int[10];
            GetArrayFromConsole(array);
            ShowArray(array);

        }

        static void ShowArray(int[] array, bool Sort = false) 
        {
            var temp = array;
            if (Sort == false)
            { 
                temp = SortArray(array); 
            }
        }

        static int[] GetArrayFromConsole(int[] result)

        {

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