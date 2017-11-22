using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_33___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 egzaminu rezultatus: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());
            var sk3 = Convert.ToInt16(Console.ReadLine());
            var vid = Math.Round(((double)sk1 + sk2 + sk3) / 3,1);

            if (vid >= 8 && vid <= 10)
            {
                Console.WriteLine("Vidurkis tarp 8 ir 10  [{0}]", vid);
            }
            else if (vid < 8 && vid >= 5)
            {
                Console.WriteLine("Vidurkis yra tarp 5 ir 7  [{0}]", vid);
            }
            else if (vid < 5)
            {
                Console.WriteLine("Vidurkis yra mazesnis nei 5  [{0}]", vid);
            }
        }
    }
}
