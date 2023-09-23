using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class ElectricEngine { }

        class GasEngine { }

        class Battery { }

        class Differential { }

        class Wheel { }

        class Car<T1>
        {
            public T1 Engine;

            public virtual void ChangePart<T2>(T2 newPart)
            {

            }
        }

        static void Main(string[] args)
        {


        }
    }
}