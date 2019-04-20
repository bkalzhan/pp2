using System;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream men = new FileStream(@"C:\pp2\week2\task4\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string path2 = Console.ReadLine();//для второго файла (
            string name2 = "output.txt";//название второго фай
            path2 = Path.Combine(path2, name2);
            string path = @"C:\pp2\week2\task4\input.txt";
            File.Copy(path, path2);
            File.Delete(path);

            /* string path = (@"C:\pp2\week2\task4");// для первого файла
             string name = "input.txt";//название первого файла
             string path2 = Console.ReadLine();//для второго файла 
             string name2 = "output.txt";//название второго файла
             path = Path.Combine(path, name);
             path2 = Path.Combine(path2, name2);
             File.WriteAllText(path, "Good Luck for me!");//писать в файл
             File.Copy(path, path2, false);//копироват с одного в другой файл
             File.Delete(path);//удалить оригинала*/
        }
    }
}
