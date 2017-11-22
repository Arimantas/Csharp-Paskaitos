using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lyginiai skaiciai nuo 0 iki 10");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
