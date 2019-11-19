using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTest
{    class FunctionTest
    {
        public void abc(int z)

        {
            if (z < 8)
            {
                Console.WriteLine(z);
                z += 2;
                abc(z);
                Console.WriteLine(z);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                FunctionTest obj = new FunctionTest();
                obj.abc(0);
                Console.ReadKey();
        }
    }
}
