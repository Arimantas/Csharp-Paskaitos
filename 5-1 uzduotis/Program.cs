using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 sveikuosius skaicius: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());

            if (sk1 == sk2)
            {
                Console.WriteLine("Skaicius {0} yra lygus skaiciui {1}", sk1, sk2);
            }

            if (sk2 == sk3)
            {
                Console.WriteLine("Skaicius {0} yra lygus skaiciui {1}", sk2, sk3);
            }

            if (sk1 > sk2)
            {
                Console.WriteLine("Skaicius {0} > {1}", sk1, sk2);
            }

            if (sk2 > sk3 * 2)
            {
                Console.WriteLine("Skaicius {0} > {1} x 2 = {2}", sk2, sk3, sk3 * 2);
            }

            if (sk1 % 2 == 0)
            {
                Console.WriteLine("Skaicius {0} yra lyginis", sk1);
            }

            if (sk2 % 2 != 0)
            {
                Console.WriteLine("Skaicius {0} yra nelyginis", sk2);
            }

            if (sk3 >= 0)
            {
                Console.WriteLine("Skaicius {0} yra teigiamas", sk3);
            }

            if (sk3 < 0)
            {
                Console.WriteLine("Skaicius {0} yra neigiamas", sk3);
            }

        }
    }
}
