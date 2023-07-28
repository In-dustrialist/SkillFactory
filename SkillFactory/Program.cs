using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
        class Food { }

        class Fruit : Food { }

        class Vegetable : Food { }

        class Apple : Fruit { }

        class Banana : Fruit { }

        class Pear : Fruit { }

        class Potato : Vegetable { }

        class Carrot : Vegetable { }
    }
}

