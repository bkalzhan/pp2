using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(func);
            t.Start();
            ConsoleKeyInfo cki= Console.ReadKey();
            if (cki.Key == ConsoleKey.Spacebar)
            {
                t.Suspend();
            }
            Console.ReadKey();
        }
        static void func()
        {
            int x = 1, y = 0, z = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.Clear();
                if (x == 1 && y == 0 && z == 0)
                {
                    x = 0;
                    y = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Thread.Sleep(2000);
                }
                else if (x == 0 && y == 1 && z == 0)
                {
                    y = 0;
                    z = 1;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Thread.Sleep(2000);
                }
                else if (x == 0 && y == 0 && z == 1)
                {
                    x = 1;
                    z = 0;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("O");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O");
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
