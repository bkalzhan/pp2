﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // цифры инпут
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
