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
            public virtual int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {
            public int counterTwo;

            public override int Counter
            {
                get
                {
                    return counterTwo;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Limit numbers below 0");
                    }
                    else
                    {
                        counterTwo = value;
                    }
                }
            }

            static void Main(string[] args)
            {
            }

        }
    }
}
