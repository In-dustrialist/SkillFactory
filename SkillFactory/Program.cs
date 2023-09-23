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
        class Engine { }
        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        class CarPart { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }

        class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;

            public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
            {

            }
        }

        static void Main(string[] args)
        {


        }
    }
}