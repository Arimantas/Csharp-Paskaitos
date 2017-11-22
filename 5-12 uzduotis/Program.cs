using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite egzamino rezultata (0 - 100)");
            var rez = Convert.ToInt16(Console.ReadLine());
            if (rez == 100)
            {
                Console.WriteLine("Gavai 100, sveikinu!");
            }
            else if (100 > rez && rez >= 80)
            {
                Console.WriteLine("100 > " + rez + " >= 80");
            }
            else if (80 > rez && rez >= 50)
            {
                Console.WriteLine("80 > " + rez + " >= 50");
            }
            else if (50 > rez && rez >= 20)
            {
                Console.WriteLine("50 > " + rez + " >= 20");
            }
            else if (rez < 20)
            {
                Console.WriteLine("20 > " + rez);
            }

        }
    }
}
