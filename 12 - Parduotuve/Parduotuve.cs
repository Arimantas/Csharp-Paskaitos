using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; }

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>();

            Console.WriteLine("1 - generuoti prekes");
            Console.WriteLine("2 - suvesti prekes");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    SugeneruotiPrekes();
                    break;

                case 2:
                    SuvestiPrekes();
                    break;

                default:
                    SugeneruotiPrekes();
                    break;
            }

        }

        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = prekes;

        }

        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1, 20);

            var sakinys = "Pellentesque Suscipit Suscipit Lorem Nec Luctus Elit Laoreet Eu Donec Et Mollis Lectus Aenean Id Tempus Mauris Aliquam Efficitur Turpis";
            var zodziai = sakinys.Split(' ');

            for (int i = 0; i < kiekPrekiu; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(111111, 11111111).ToString();
                var kaina = rnd.Next(40, 100);
                var savikaina = rnd.Next(1, 40);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas {0}", Pavadinimas);
            Console.WriteLine("Adresas {0}", Adresas);
            Console.WriteLine("Prekiu kiekis: {0}", Prekes.Count());
            Console.WriteLine();

            foreach (var preke in Prekes)
            {
                preke.Isvedimas();
            }

            Console.WriteLine("Skaiciavimai:");
            Console.WriteLine("Visu prekiu kainu suma: {0} eur.", KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma: {0} eur.", SavikainuSuma());
            Console.WriteLine("Visos pajamos pardavus prekes: {0} eur.", PajamosVisuPrekiu());
            Console.WriteLine("Pelnas pardavus prekes: {0} eur.", Pelnas());
            Console.WriteLine();
            Console.WriteLine("Preke kurios parduotuveje yra maziausiai:");
            MaziausiasKiekis().Isvedimas();
            Console.WriteLine("Preke kurios parduotuveje yra daugiausiai:");
            DidziausiasKiekis().Isvedimas();
            Console.WriteLine("Pigiausia preke:");
            PigiausiaPreke().Isvedimas();
            Console.WriteLine("Brangiausia preke:");
            BrangiausiaPreke().Isvedimas();
        }

        public void SuvestiPrekes()
        {
            Console.Write("Kiek prekiu suvesti: ");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.Write("Prekes pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("Prekes kodas: ");
                var kodas = Console.ReadLine();
                Console.Write("Prekes kaina: ");
                var kaina = Convert.ToDouble(Console.ReadLine());
                Console.Write("Prekes savikaina: ");
                var savikaina = Convert.ToDouble(Console.ReadLine());
                Console.Write("Prekes kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }

        }

        public double KainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina;
            }
            return suma;
        }

        public double SavikainuSuma()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Savikaina;
            }
            return suma;
        }

        public double PajamosVisuPrekiu()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina * preke.Kiekis;
            }
            return suma;
        }

        public double SavikainaVisuPrekiu()
        {
            var suma = 0.0;
            foreach (var preke in Prekes)
            {
                suma += preke.Savikaina * preke.Kiekis;
            }
            return suma;
        }

        public double Pelnas()
        {
            return PajamosVisuPrekiu() - SavikainaVisuPrekiu();
        }

        public Preke MaziausiasKiekis()
        {
            var maziausia = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kiekis < maziausia.Kiekis)
                {
                    maziausia = preke;
                }
            }
            return maziausia;
        }

        public Preke DidziausiasKiekis()
        {
            var didziausias = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kiekis > didziausias.Kiekis)
                {
                    didziausias = preke;
                }
            }
            return didziausias;
        }


        public Preke PigiausiaPreke()
        {
            var pigiausia = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kaina < pigiausia.Kaina)
                {
                    pigiausia = preke;
                }
            }
            return pigiausia;
        }

        public Preke BrangiausiaPreke()
        {
            var brangiausia = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kaina > brangiausia.Kaina)
                {
                    brangiausia = preke;
                }
            }
            return brangiausia;
        }


    }
}
