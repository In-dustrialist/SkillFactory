using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {

        class SSD
        {

            public SSD(string Name, long Storage, long freeStorage)
            {
                Name = "Samsung";
                Storage = 500;
                freeStorage = 240;
            }
            public string Name { get; }
            public long Storage { get; }

            public long FreeStorage { get; }
        }
        static void Main(string[] args)
        {


        }
    }
}