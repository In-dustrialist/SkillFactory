using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Program
    {
        enum DaysOfWeek : byte
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            ///Task 4.1.5

            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
