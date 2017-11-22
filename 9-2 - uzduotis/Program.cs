using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek studentu pazymiu norite suvesti i sarasa?");
            var kiekPaz = Convert.ToInt32(Console.ReadLine());
            List<int> pazymiai = new List<int>();
            //  var pradzia = 1;
            var rnd = new Random();

            for (int i = 0; i < kiekPaz; i++)
            {
                Console.WriteLine("Iveskite {0} pazimi: ", i + 1);
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // while (pradzia <= kiekPaz)
            // {
            //     Console.WriteLine("Iveskite {0} pazimi: ", pradzia);
            //     pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            //     pradzia++;
            // }

            Console.WriteLine("Didziausias pazimys: " + pazymiai.Max());
            Console.WriteLine("Maziausias pazimys: " + pazymiai.Min());
            Console.WriteLine("Pazysmiu vidurkis: " + Math.Round(pazymiai.Average(), 2));

            var skaicius = 1;
            var kiekSk = rnd.Next(kiekPaz);
            foreach (var pazimys in pazymiai)
            {
                if (skaicius <= kiekSk)
                {
                    Console.Write(pazimys + " ");
                    skaicius++;
                }
            }
            Console.WriteLine();
        }
    }
}
