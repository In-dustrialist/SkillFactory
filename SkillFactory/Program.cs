using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp1
{
    internal class Program
    {
        [Serializable]
        class Sur
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Email { get; set; }

            public Sur(string name, long phoneNumber, string email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }
   
        static void Main(string[] args)
        {
            var Sur = new Sur("Name", 456545, "email@email.com");

            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream("Sur.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Sur);
            }
        }
    }
}