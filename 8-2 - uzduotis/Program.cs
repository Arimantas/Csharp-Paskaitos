using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 15.3, 14.5, 14.2, 10.1, 9.5, 8.3, 7.5 };
            var zemiausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }
            }
            Console.WriteLine("Zemiausia temperatura " + zemiausia);

            var auksciausia = temperaturos[0];
            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] > auksciausia)
                {
                    auksciausia = temperaturos[i];
                }
            }
            Console.WriteLine("Auksciausia temperatura " + auksciausia);

            var suma = 0.0;
            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }
            var vidurkis = Math.Round(suma / temperaturos.Length, 1);
            Console.WriteLine("Vidutine temperatura " + vidurkis);

            var kiekZemiau = 0;
            foreach (var temperatura in temperaturos)
            {
                if (vidurkis > temperatura)
                {
                    kiekZemiau += 1;
                }
            }
            Console.WriteLine("Temperaturu zemiau uz {0} yra: {1}", vidurkis, kiekZemiau);

            var kiekAuksciau = 0;
            foreach (var temperatura in temperaturos)
            {
                if (vidurkis < temperatura)
                {
                    kiekAuksciau += 1;
                }
            }
            Console.WriteLine("Temperaturu auksciau uz {0} yra: {1}", vidurkis, kiekAuksciau);
        }
    }
}
