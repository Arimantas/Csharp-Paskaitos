using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius: ");
            // Kad nereiktu spaust enter po ivedimo (kazkas negerai su nuskaitymu)
            // var sk1 = Convert.ToInt32((char)Console.ReadKey().KeyChar);
            // Console.WriteLine();
            // var sk2 = Convert.ToInt16(Console.ReadKey().KeyChar);
            // Console.WriteLine();
            // var sk3 = Convert.ToInt16(Console.ReadKey().KeyChar);
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} + {1} + {2} = {3}", sk1, sk2, sk3, sk1+sk2+sk3);
            Console.WriteLine("{0} - {1} - {2} = {3}", sk1, sk2, sk3, sk1-sk2-sk3);
            Console.WriteLine("{0} x {1} x {2} = {3}", sk1, sk2, sk3, sk1*sk2*sk3);
            Console.WriteLine("{0} / {1} / {2} = {3}", sk1, sk2, sk3, (float)sk1/sk2/sk3);
        }
    }
}