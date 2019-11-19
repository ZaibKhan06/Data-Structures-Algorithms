using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, BS,index;
            int[] a = new int[100];
            Console.WriteLine("Enter no of elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in sorted order");
            for (i = 0; i < n; i++)
              {
                  a[i]=Convert.ToInt32(Console.ReadLine());
              }

            Console.WriteLine("Enter element you want to search ");
            BS = Convert.ToInt32(Console.ReadLine());

            index = Search(a, n, BS);
            if (index == -1)
                Console.WriteLine(BS + " is not present in this array ");
            else
                Console.WriteLine(BS + " is present at the index " + index);

            Console.ReadKey();


        }
        public static int Search(int[] a, int n, int BS)
        {
            int first = 0, last = n - 1, mid;
            while (first<=last)
                {
                    mid = (first + last) / 2;
                    if (BS < a[mid])
                        last = mid - 1;
                    else if (BS > a[mid])
                        first = mid + 1;
                    else
                        return mid;
                }
            return -1;
        }
    }
}