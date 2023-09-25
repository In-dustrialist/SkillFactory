using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        }

        static void GetCatalogs()
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\NFolder");
            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory("NewFolder");

            string dirName = "C:\\"; // Прописываем путь к корневой директории Windows "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Folders:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                int amountFolders = dirs.Length;
                Console.WriteLine(amountFolders);

                Console.WriteLine();
                Console.WriteLine("Files:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога
                int amountFiles = files.Length;

                Console.WriteLine(amountFiles);
                Console.WriteLine();

                DirectoryInfo dirInfoDelte = new DirectoryInfo("C:\\NFolder");
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Deleted");
            }
            
        }
    }
}