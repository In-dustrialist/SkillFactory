using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillFactory
{
    internal class Program
    {
        class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Method BaseClass");
            }
        }

        class DerivedClass : BaseClass
        {
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Method DerivedClass");
            }
        }

        static void Main(string[] args)
        { 
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Display();

            Console.ReadKey();
        }
    }
}
