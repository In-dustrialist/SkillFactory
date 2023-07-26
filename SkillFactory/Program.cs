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
        class Triangular
        {
            public int side1;
            public int side2;
            public int side3;

            static int perimeter(int side1, int side2, int side3)
            {
                int result = side1 + side2 + side3;
                return result;
            }
        }
        class Circle
        {
            public double radius;
            static double square(double radius)
            {
                double p = 3.14;
                double s = radius * radius;
                double result = s * p;
                return result;
            }
            
        }
        class Square
        {
            public int side;

            static int perimeter(int side)
            {
                int result = side * 4;
                return result;
            }
        }

        public static void Main(string[] args)
        {

        }

    }
}
