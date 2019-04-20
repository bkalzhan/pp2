using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nextone
{
    class Program
    {
        public static bool PressKey { get; private set; }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int num = 0;
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, num, 0, 500);
            int num1 = 0;
            TimerCallback tm1 = new TimerCallback(Cunt);
            Timer timer1 = new Timer(tm1, num1, 0, 225);
            Console.ReadLine();
            cki = Console.ReadKey();
            if (cki.Key==ConsoleKey.Spacebar)
            {
                
            }
        }

        public static void Count(object obj)
        {
            int x = (int)obj;
            
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("---------"); 
            
        }
        public static void Cunt(object obj)
        {
            int x = (int)obj;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------");

        }
    }
}
