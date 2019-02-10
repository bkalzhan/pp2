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
        public static void  Fox()                //создаем функцию 
        {
            StreamReader sr = new StreamReader(@"C:\pp2\week2\task1\input.txt");      //считываем стринг через инпут файл
            string s = sr.ReadToEnd();
            string[] a = s.Split();
            for (int i = 0; i < a.Length / 2; i++)     //проверяем стринг на палиндром и выводим ответ
            {
                if (a[i] != a[a.Length - i - 1])
                {
                    Console.WriteLine("No");
                    return;
                }

            }
            sr.Close();
            Console.WriteLine("Yes");

        }
        static void Main(string[] args)
        {
            Fox();// вызываем функцию
        }
    }
}
