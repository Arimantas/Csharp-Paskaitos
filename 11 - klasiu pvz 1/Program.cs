using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___klasiu_pvz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var knyga1 = new Knyga(); // objektas 
            knyga1.Pavadinimas = "Haris Floperis ir Sviesa Tamsoje";
            knyga1.Autorius = "Tyli Sviesa";
            knyga1.Metai = 2012;
            knyga1.PslSkaicius = 398;
            knyga1.Isvedimas();
            var knyga2 = new Knyga("Voldemorto Sunkumai Suvirintoju Profkeje", "Jis", 954, 2015);
            knyga2.Isvedimas();

            var knygos = new List<Knyga> {

            new Knyga("Kaip ismokti programuoti", "Kazkoks coderis", 9989461, 2001),
            new Knyga("Anyksciu silelis", "A. Baranauskas", 345, 1987),
            new Knyga("Sudeges silelis (perdege kineskopas)", "A. Jabanauskas", 125, 2004),
        };

            foreach (var knyga in knygos)
            {
                knyga.Isvedimas();
            }

        }
    }
}