using System;
using System.IO;

namespace File_Management
{
    internal class Program
    {
        static FileManager fileManager;
        static void Main(string[] args)
        {
            fileManager = new FileManager();
            string oneOfCases;
            bool dependsOnCase = false;
            Console.WriteLine("1. Выявить изменения");
            Console.WriteLine("2. Создание резервной копии существующих файлов");
            Console.WriteLine("3. Выход");

            while (true)
            {
                Console.WriteLine("Выберите какой-то один пункт, что необходимо сделать");
                do
                {
                    oneOfCases = Console.ReadLine();
                    if (oneOfCases == "1" || oneOfCases == "2" || oneOfCases == "3")
                    {
                        dependsOnCase = true;
                    } else
                    {
                        Console.WriteLine("Выберите какой-то один пункт(1-3).");
                    }
                } while (dependsOnCase == false);

                switch (oneOfCases)
                {
                    case "1":
                        fileManager.Start();
                        Console.ReadLine();
                        break;
                    case "2":
                        DoCopy();
                        break;
                    case "3":
                        return;
                    default:
                        break;

                }
            }

                   
        }
        
        
        static void DoCopy()
        {
            bool copyCase = false;
            string[] copies = fileManager.GetCopy();
            for(int i =0; i< copies.Length; i++)
            {
                Console.WriteLine($"{i} - {copies[i]}");
            }
            while(copyCase == false)
            {
                string str = Console.ReadLine();
                copyCase = int.TryParse(str, out int i);
                if (i >= 0 || i <= copies.Length)
                {
                    fileManager.DoCopy(copies[i]);
                } 
                else
                {
                    Console.WriteLine("Значение введено неверно. Попробуйте еще раз");
                    copyCase = false;
                }

            }
        }
    }
    class FileManager
    {

        // метод получения изменений в файлах
        public void Start()
        {
            string folder = new FileSystemWatcher();
        }
        
    }
}
