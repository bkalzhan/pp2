using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Console.ReadLine();
            string name1 = "Zhazylgan.txt";
            path1 = Path.Combine(path1, name1);
            string path2 = Console.ReadLine();
            string name2 = "Bos.txt";
            path2 = Path.Combine(path2, name2);
            File.WriteAllText(path1, "Hello, world!");
            File.Copy(path1, path2);
            File.Delete(path1);
        }
    }
}
