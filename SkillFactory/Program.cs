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

            GetCatalogs(); //   Вызов метода получения директорий
            MoveFolder();
        }

        static void GetCatalogs()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\pinae\OneDrive\Рабочий стол");
            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory("testFolder");
        }
        static void MoveFolder()
        {


            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\pinae\OneDrive\Рабочий стол\testFolder");
            dirInfo.Delete(true); // Удаление со всем содержимым
            Console.WriteLine("Dleted");
        }
        }
    }