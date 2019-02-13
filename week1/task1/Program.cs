using System;
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
            int cnt = 0; // переменные чтобы считать количество прайм чисел 
            int n = int.Parse(Console.ReadLine()); //количество инпут цифр
            int[] array = new int[n]; //новый массив сохранить прайм чисел
            string[] s = Console.ReadLine().Split(); 
            for (int i = 0; i < n; i++)
            {
                int cnt1 = 0;// считать количество делителей
                int k = int.Parse(s[i]);
                for (int j = 1; j < k; j++)
                {
                    if (k % j == 0)
                        cnt1++;
                }
                if (cnt1 == 1)
                    array[cnt++] = k;
            }
            Console.WriteLine(cnt); // колич. прайм чисел
            for (int i = 0; i < cnt; i++) // прайм числы
                Console.Write(array[i] + " ");
            Console.ReadKey();
        }
    }
}
