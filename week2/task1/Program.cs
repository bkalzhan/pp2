using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\pp2\week2\task1\input.txt");      //считываем стринг через инпут файл
            string[] s = sr.ReadLine().Split();
            for (int i = 0; i < s.Length / 2; i++)     //проверяем стринг на палиндром и выводим ответ
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            sr.Close();
            Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
