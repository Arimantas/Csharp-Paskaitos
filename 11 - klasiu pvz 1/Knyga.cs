using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___klasiu_pvz_1
{
    class Knyga
    {
        public int PslSkaicius;
        public string Autorius;
        public string Pavadinimas;
        public int Metai;

        public Knyga()
        {
            Console.WriteLine("Labas as esu konstruktoriuje");
        }

        public Knyga(string pavadinimas, string autorius, int pslSkaicius, int metai)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PslSkaicius = pslSkaicius;
            Metai = metai;
        }


        public void Isvedimas()
        {
            Console.WriteLine("'{0}' autorius yra {1}, knyga parasyta {2} metais, joje yra {3} puslapliu visiskos nesamones.", Pavadinimas, Autorius, Metai, PslSkaicius);
            Console.WriteLine();
        }


    }
}
