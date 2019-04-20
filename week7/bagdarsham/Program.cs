using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bagdarsham
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, num, 0, 6000);
           
            int num1 = 0;
            TimerCallback tm1 = new TimerCallback(Count1);
            Timer timer1 = new Timer(tm1, num1, 2000, 6000);
           
            int num2 = 0;
            TimerCallback tm2 = new TimerCallback(Count2);
            Timer timer2 = new Timer(tm2, num2, 4000, 6000);
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Spacebar)
            {
               
            }
            Console.ReadKey();
            
        }
        public static void Count(object obj)
        {
            Console.Clear();
            int x = (int)obj;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.WriteLine();
        }
        public static void Count1(object obj)
        {
            Console.Clear();
            int x = (int)obj;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.WriteLine();
        }
        public static void Count2(object obj)
        {
            Console.Clear();
            int x = (int)obj;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("O");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O");
            Console.WriteLine();
        }
    }
}
