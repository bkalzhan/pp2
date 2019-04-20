using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public void VV()
        {

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // количество инпут цифр
            int[] array = new int[n];//массив для инпут цифр
            string[] s = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(s[i]);
            }
            int[] array1 = new int[2 * n];// массив для оутпут цифр
            int j = 0;//для элементов первого массива
            for(int i=0; i<2*n; i++)
            {
                array1[i++] = array[j];//2 раза сохранить каждого элемента первого массива 
                array1[i] = array[j];
                j++;
            }
            for(int i=0; i<2*n; i++)
            {
                Console.Write(array1[i] + " ");//выводим результат
            }
            Console.ReadKey();
        }
    }
}
