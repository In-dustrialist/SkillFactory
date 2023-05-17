using System;
using System.Collections.Generic;
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
            ///Unit 4.3.12

            {

                var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

                int x;

                for (int i = 0; i < arr.Length; i++)

                {

                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] > arr[k])
                        {
                            x = arr[i];
                            arr[i] = arr[k];
                            arr[k] = x;
                        }
                    }

                }
                foreach (int NewArr in arr)
                {
                    Console.Write(NewArr);
                }
            }
            Console.ReadKey();
        }
    }
}