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

        class IndexingClass
        {
            private int[] array;

            public IndexingClass(int[] array)
            {
                this.array = array;
            }

            public int this[int index]
            {
                get { return array[index]; }
                set { array[index] = value; }
            }
        }

        static void Main(string[] args)
        {

        }

    }
}