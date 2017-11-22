using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ivesti betkoki teksta: ");
            Console.WriteLine("Ivestas tekstas: " + Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Iveskite betkoki skaiciu: ");
            Console.WriteLine("Ivestas skaicius: " + Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("");
            Console.Write("Pasirinkimas (true / false): ");
            var pasirinkimas = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Tavo pasirinkimas: " + pasirinkimas);
            Console.WriteLine("");
            Console.WriteLine();
            Console.Write("Testi programos darba? (y/n) ");
            var pasirinkimas1 = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("");
            Console.WriteLine("Pasirinkimas: " + pasirinkimas1);
        }
    }
}
