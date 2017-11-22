using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_12___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norimu gauti fibonaciu skaiciu kieki: ");
            var fib = Convert.ToInt32(Console.ReadLine());
            var sk1 = 1;
            var sk2 = 1;
            var sk3 = 2;
            Console.Write("1 1 ");

            for (int i = 2; i < fib; i++)
            {
                sk3 = sk1 + sk2;
                Console.Write(sk3 + " ");
                sk1 = sk2;
                sk2 = sk3;
            }
        }
    }
}
