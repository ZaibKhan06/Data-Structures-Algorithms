using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string str1 = "This is me";
            string str2 = "me";
            int length = str1.Length - str2.Length;
            for (i = 0; i < 8; i++)
            {
                for (j = 0; j < str2.Length; j++) ;
                {
                    if (str2[j] != str1[i + j])
                    {
                        break;
                    }
                }
                if (j == str2.Length)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
