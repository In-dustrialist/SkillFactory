using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {

        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();


            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
                Console.WriteLine("Folder is created");
            }
        }
        static void Main(string[] args)
        {


        }
    }
}