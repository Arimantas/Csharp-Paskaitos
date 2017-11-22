using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());
            var sk3 = Convert.ToInt16(Console.ReadLine());

            switch (sk1)
            {
                case 1:
                    Console.WriteLine("{0} + {1} + {2} = {3}", sk1, sk2, sk3, sk1 + sk2 + sk3);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", sk1, sk3, sk1 - sk3);
                    break;
                case 3:
                    Console.WriteLine("{0} x {1} = {2}", sk2, sk3, sk2 * sk3);
                    break;
                default:
                    Console.WriteLine("Pirmas skaicius nera lygus 1, 2 arba 3");
                    break;
            }
        }
    }
}
