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
        class A
        {
        public virtual void Display() => Console.WriteLine("A");
        }
        class B : A
        {
            public new void Display() => Console.WriteLine("B");
        }
        class C : A
        {
            public override void Display() => Console.WriteLine("C");
        }
        class D : B
        {
            public new void Display() => Console.WriteLine("D");
        }
        class E : C
        {
            public new void Display() => Console.WriteLine("E");
        }

        static void Main(string[] args)
        {
            A a = new A(); a.Display(); 
            B b = new B(); b.Display(); 
            C c = new C(); c.Display(); 
            D d = new D(); d.Display(); 
            E e = new E(); e.Display();

            Console.ReadKey();
        }
    }
}