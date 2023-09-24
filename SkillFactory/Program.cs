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
        abstract class Engine { }

        class ElectricEngine : Engine { }

        class GasEngine : Engine { }

        abstract class CarPart { }

        class Battery : CarPart { }

        class Differential : CarPart { }

        class Wheel : CarPart { }

        abstract class Car<TEngine> where TEngine : Engine
        {
            public TEngine Engine;

            public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
        }

        class ElectricCar : Car<ElectricEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }

        class GasCar : Car<GasEngine>
        {
            public override void ChangePart<TPart>(TPart newPart)
            {

            }
        }
        static void Main(string[] args)
        {


        }
    }
}