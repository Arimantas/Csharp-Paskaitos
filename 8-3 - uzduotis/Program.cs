using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = {5, 4, 6, 6, 7, 8, 9, 10, 7, 5, 6, 7, 8, 10, 8, 3, 2, 4, 6, 5, 1};
            var geriausias = 0;
            foreach (var pazimys in pazymiai)
            {
                if (geriausias < pazimys)
                {
                    geriausias = pazimys;
                }
            }
            Console.WriteLine("Geriausias pazimys: " + geriausias);

            var kiekGavoMax = 0;
            foreach (var pazimys in pazymiai)
            {
                if (pazimys == geriausias)
                {
                    kiekGavoMax++;
                }
            }
            Console.WriteLine("Mokiniu skaiciu kurie gavo didziausia ivertinima: " + kiekGavoMax);

            var kiekDesimt = 0;
            foreach (var pazimys in pazymiai)
            {
                if (pazimys == 10)
                {
                    kiekDesimt ++;
                }
            }
            Console.WriteLine("Mokiniu skaiciu kurie gavo 10: " + kiekDesimt);

            var kiekNeigiama = 0;
            foreach (var pazimys in pazymiai)
            {
                if (pazimys < 4)
                {
                    kiekNeigiama++;
                }
            }
            Console.WriteLine("Mokiniu skaiciu kurie neigiama ivertinima (maziau nei 4): " + kiekNeigiama);

            var suma = 0;
            foreach (var pazimys in pazymiai)
            {
                suma += pazimys;
            }
            var vidurkis = Math.Round((double)suma / pazymiai.Length,2);
            Console.WriteLine("Pazymiu vidurkis yra: " + vidurkis);
        }
    }
}
