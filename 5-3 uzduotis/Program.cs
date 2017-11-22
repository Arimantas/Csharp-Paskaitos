using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite bet koki teigiama skaiciu: ");
            var sk = Convert.ToInt16(Console.ReadLine());

            if (sk < 0)
            {
                Console.WriteLine("Jusu ivestas skaicius nera teigiamas.");
            }

            if (sk > 0)
            {
                Console.WriteLine("Sveikinu, tu esi pakankamai gabus eiti i seima su Darbo partija");
            }

            if (sk % 2 == 0 && sk > 0) // tikrina ar nera neigiamas
            {
                Console.WriteLine("Tavo ivestas skaicius yra lyginis");
            }

            if (sk % 4 == 0 && sk > 0) // tikrina ar nera neigiamas
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

            if (sk > 10)
            {
                Console.WriteLine(sk + " > 10");
            }
        }
    }
}
