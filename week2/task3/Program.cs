using System;
using System.IO;
namespace task3
{
    class Program
    {
        public static void Probely(int lvl)             //функция для вывода имени каждого файла и директори
        {
            for (int i = 0; i < lvl; i++)
            {
                Console.Write("    ");
            }
        }
        public static void Direc(DirectoryInfo dir, int lvl)        //функция для вывода имени каждого файла и директори 
        {
            foreach (FileInfo f in dir.GetFiles())      //взять файлы из директори и показать
            {
                 Probely(lvl);
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())  //взять директориес из директори и показать
            {
                Probely(lvl);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(d.Name);
                Direc(d, lvl + 1);        //путем рекурсии вызовим метод Direc, чтобы показать другие файлы и каталоги
            }
            
        }

        static void Main(string[] args)
        {
            string path = Console.ReadLine();  
            DirectoryInfo dirr = new DirectoryInfo(path);
            Direc(dirr, 0);
            Console.ReadKey();
        }
    }
}
