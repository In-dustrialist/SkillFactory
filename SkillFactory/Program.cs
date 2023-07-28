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
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }
        class ProjectManager : Employee
        {public string ProjectName; }

        class Developer : Employee
        { public string ProgrammingLanguage; }
    }
    }

