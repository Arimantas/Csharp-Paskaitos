using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 5 savo pazymius: ");
            var paz1 = Convert.ToInt16(Console.ReadLine());
            var paz2 = Convert.ToInt16(Console.ReadLine());
            var paz3 = Convert.ToInt16(Console.ReadLine());
            var paz4 = Convert.ToInt16(Console.ReadLine());
            var paz5 = Convert.ToInt16(Console.ReadLine());
            var vidurkis = Math.Round(((float)paz1 + paz2 + paz3 + paz4 + paz5) / 5, 1);

            if (vidurkis > 5)
            {
                Console.WriteLine("Tavo pazymiu vidurkis yra lygus {0}, jis yra didesnis uz 5", vidurkis);
            }
            else { Console.WriteLine("Tavo vidurkis yra lygus {0}, jis yra mezesnis uz 5", vidurkis); }
        }
    }
}
