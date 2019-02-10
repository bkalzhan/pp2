using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static bool Pr(int n) // создаем функцию для проверки прайм
        {
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\pp2\week2\task2\input.txt"); // считываем через инпут файл
            string[] s = sr.ReadLine().Split(); //делим стринг в массив
            sr.Close();
            string s1 = ""; // стрингдля ответа
            for(int i=0; i< s.Length; i++) // пробегаемся по массиву
            {
                int c = int.Parse(s[i]); //парсим каждый элемент в инт
                if (Pr(c) == true) s1 +=s[i] + " "; // если прайм, добавляем в стрин ответа
            }
            StreamWriter sw = new StreamWriter(@"C:\pp2\week2\task2\output.txt");// через оутпут файл выводим ответ
            sw.WriteLine(s1);
            sw.Close();
        }
    }
}
