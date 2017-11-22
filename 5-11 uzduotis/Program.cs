using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} > {1}", sk1, sk2);
            }
            else if (sk2 > sk3)
            {
                Console.WriteLine("Skaicius {0} > {1}", sk2, sk3);
            }
            else if (sk3 > sk1)
            {
                Console.WriteLine("Skaicius {0} > {1}", sk3, sk1);
            }
            else if (sk1 == sk2 && sk2 == sk3)
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
        }
    }
}
