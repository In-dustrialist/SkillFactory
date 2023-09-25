using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Visual Studio\SkillFactory\Program.cs"; // Укажем путь 
            
            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}