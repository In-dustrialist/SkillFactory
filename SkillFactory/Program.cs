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

        /// Unit 5.3.13

        public static void Main(string[] args)
        {

        }

        static void SortArray(in int[] result, out int[] sorteddesc, out int[] sortedasc)
        {
            {
                sorteddesc = SortArrayDesc(result);

                sortedasc = SortArrayAsc(result);
            }
        }

        static int[] SortArrayDesc(int[] result)
        {
            int temp = 0;

            for (int i = 0; i > result.Length; i++)
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
            return result;
        }
        static int[] SortArrayAsc(int[] result)
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
            return result;
        }
    }
}