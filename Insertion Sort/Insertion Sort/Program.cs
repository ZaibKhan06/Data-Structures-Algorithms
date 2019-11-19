using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Insertion Sort***");
            int temp, i, j;
            int[] array = { 80, 21, 90, 5, 6, 8, 5, 3 };
            for (i = 0; i < array.Length - 1; i++)
            {
                temp = array[i + 1];
                for (j = i; j >= 0 && array[j] > temp; j--)
                {
                    array[j + 1] = array[j];
                }
                array[j + 1] = temp;

            }
            for (i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
         Console.ReadKey();
        }
    }
}
