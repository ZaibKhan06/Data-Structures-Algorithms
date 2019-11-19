using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Linear Search***");
            int n, i, LS, index;
            int[] a = new int[100];
 
            Console.WriteLine("Enter no of elements:");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the elements");
            for (i = 0; i < n; i++)
              {
                  a[i]=Convert.ToInt32(Console.ReadLine());
              }
            Console.WriteLine("Enter element you want to search");
            LS= Convert.ToInt32(Console.ReadLine());

            index = Search(a, n, LS);
                if (index==-1)
                    Console.WriteLine(LS+" is not present in this array ");
                else
                    Console.WriteLine(LS+" is present at the index "+index);

                Console.ReadKey();
        }
        public static int Search(int[] a, int n, int LS)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == LS)
                    return i;
            }
            return -1;
        }
    }
}
