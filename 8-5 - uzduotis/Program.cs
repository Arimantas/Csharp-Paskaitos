using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[10];
            fib[1] = 1;
            fib[2] = 1;
            Console.Write("[1] [1] ");

            for (int i = 2; i < fib.Length; i++)
            {
                fib[3] = fib[1] + fib[2];
                Console.Write("[{0}] ", fib[3]);
                fib[1] = fib[2];
                fib[2] = fib[3];
            }
        }
    }
}
