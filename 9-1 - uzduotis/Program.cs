using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            var rnd = new Random();
            var kiekSugeneruoti = rnd.Next(1, 100);

            for (int i = 0; i < kiekSugeneruoti; i++)
            {
                skaiciai.Add(rnd.Next(1, 100));
                Console.Write(skaiciai[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kiek yra skaiciu: " + skaiciai.Count());
            Console.WriteLine("Koks yra maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("Koks yra didziausis skaicius: " + skaiciai.Max());
            Console.WriteLine("Koks yra skaiciu vidurkis: " + Math.Round(skaiciai.Average(), 2));

            var kiekZemesniu = 0;
            foreach (var skaicius in skaiciai)
            {
                if (kiekZemesniu < skaiciai.Average())
                {
                    kiekZemesniu++;
                }
            }
            Console.WriteLine("Skaiciu zemesniu uz vidurki: " + kiekZemesniu);

            var lyginiai = 0;
            foreach (var skaicius in skaiciai)
            {
                if (skaicius % 2 == 0)
                {
                    lyginiai += skaicius; ;
                }
            }
            Console.WriteLine("Lyginiu skaiciu suma: " + lyginiai);
        }
    }
}
