using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = Math.Round(((float)sk1 + sk2 + sk3) / 3, 2); // suapvalina, paliekant 2 vietas po kablelio
            Console.WriteLine("Skaiciu {0}, {1} ir {2} vidurkis yra lygus {3}", sk1, sk2, sk3, vidurkis);
        }
    }
}
