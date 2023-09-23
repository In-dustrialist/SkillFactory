using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Generic<T1, T2>
        {
            public T1 ID; // Поле типа T1

            public T2 Value; // Поле типа T2

            public DateTime Date;
        }
        static void Main(string[] args)
        {


        }
    }
}