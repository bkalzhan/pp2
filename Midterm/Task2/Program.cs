using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread t = new Thread(func);
            t.Start();
            Console.ReadKey();
        }

        static void func()
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int symbol = random.Next(65, 122);
                char ch = (char)(symbol);
                int x = random.Next(1, Console.WindowWidth);
                int y = random.Next(1, Console.WindowHeight);
                int color = random.Next(1, 5);
                if (color == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                if (color == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (color == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (color == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                if (color == 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(x, y);
                Console.Write(ch);
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
