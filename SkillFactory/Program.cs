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
        class Obj
        {
            public int Value;

            public static Obj operator +(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}