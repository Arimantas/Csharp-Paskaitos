using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite per valanda kepalu gali iskepti darbuotojas: ");
            var kepaluSkPerValanda = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darbuotoju skaicius: ");
            var darbSk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vieno kepalo savikaina: ");
            var savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vieno kepalo pardavimo kaina: ");
            var kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kiek kepykla turi uzsakymu siai dienai: ");
            var uzsakymuSk = Convert.ToDouble(Console.ReadLine());

            var darboDiena = 8;
            var kepaluPerDiena = kepaluSkPerValanda * darbSk * darboDiena;
            var savikainaKep = kepaluPerDiena * savikaina;
            var pajamos = kepaluPerDiena * kaina;
            var pelnas = pajamos - savikainaKep;

            Console.WriteLine("Kepykla iskeps: {0} kepalus.", kepaluPerDiena);
            Console.WriteLine("Visu kepalu savikaina: " + savikainaKep + "eur.");

            if (kepaluPerDiena >= uzsakymuSk)
            {
                Console.WriteLine("Kepykla spes iskepti visus sios dienos uzsakymus");
            }
            else
            {
                Console.WriteLine("Kepykla nespes ivykdyti visu dienos uzsakymu, prituks {0} kepalu.", (uzsakymuSk - kepaluPerDiena));
            }

            Console.WriteLine("Pajamos pardavus visu kepalus: " + pajamos + "eur.");
            Console.WriteLine("Visas gautas pelnas: " + pelnas + "eur.");

            
        }
    }
}
