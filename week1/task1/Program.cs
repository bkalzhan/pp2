using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; // to foind numbers of prime
            int n = int.Parse(Console.ReadLine()); //number of input integers
            int[] array = new int[n];// a new array to save prime numbers
            string[] s = Console.ReadLine().Split(); // input integers
            for (int i = 0; i < n; i++)
            {
                int cnt1 = 0; // for counting number of possible dividers without remainder
                int k = int.Parse(s[i]);
                for (int j = 1; j < k; j++)
                {
                    if (k % j == 0) cnt1++;
                }
                if (cnt1 == 1)
                    array[cnt++] = k;
            }
            Console.WriteLine(cnt); // number of prime integers
            for (int i = 0; i < cnt; i++)
                Console.Write(array[i] + " ");//output prime numbers
            Console.ReadKey();
        }
    }
}