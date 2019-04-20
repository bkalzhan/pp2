using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student //создаем класс студент
    {
        public string name; // объявляем переменные 
        public string id;
        public int year;

        public Student(string name, string id)  // создаем конструктор который принимает 2 переменные имя и айди
        {
            this.name = name;
            this.id = id;
        }
        public void plusyear() // функция для добав. года
        {
            year++;
        }
        public void cout() //функция для вывода перемиенных
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
