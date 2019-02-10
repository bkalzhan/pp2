using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number of input integers
            int[] array = new int[n]; // array for input integers
            string[] s = Console.ReadLine().Split();
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(s[i]); // string to integer
            }
            WW(array, n);//calling the function and giving the array with integers and number of the integers
            Console.ReadKey();
        }
        static void WW(int[] array, int n)
        {
            int[] array1 = new int[2 * n];// array for output integers
            int j = 0;//for elements of first array
            for(int i=0; i<2*n; i++)
            {
                array1[i++] = array[j];//saving each element of the first array as a 2 elements in a row in the second array
                array1[i] = array[j];
                j++;
            }
            for(int i=0; i<2*n; i++)
            {
                Console.Write(array1[i] + " ");//output the result
            }
        }
    }
}
