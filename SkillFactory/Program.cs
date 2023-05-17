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
            ///Unit 4.3.16

            {

                int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

                int sum = 0;

                for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                {
                    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)

                        if (array[i, k] > 0)
                            sum++;
                }

                Console.WriteLine(sum);
                Console.ReadKey();
            }
        }
    }
}