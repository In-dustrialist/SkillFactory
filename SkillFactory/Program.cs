using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillFactory
{
    internal class Program
    {

        abstract class ComputerPart
        {
            public abstract void Work ();
        }
        class Processor : ComputerPart { public override void Work() { } }
        class MotherBoard : ComputerPart { public override void Work() { } }
        class GraphicCard : ComputerPart { public override void Work() { } }


        static void Main(string[] args)
        {

        }

    }
}