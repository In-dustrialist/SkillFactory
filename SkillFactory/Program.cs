using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            ///Unit 4.3.17

            {

                int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

                int temp;

                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    {

                        for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                        {

                            if (arr[i, j] > arr[i, k])
                            {
                                temp = arr[i, j];
                                arr[i, j] = arr[i, k];
                                arr[i, k] = temp;
                            }

                        }

                    }
                }
                for (int i = 0; i <= arr.GetUpperBound(0); i++)
                {
                    for (int k = 0; k <= arr.GetUpperBound(1); k++)

                        Console.Write(arr[i, k] + " ");

                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
