using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var p = new Program();
            p.Ivedimas(atlyginimai);
            p.Isvedimas(atlyginimai);
            Console.WriteLine();
            Console.WriteLine("Maziausia alga: " + p.MaziausiaAlga(atlyginimai) + "Eur.");
            Console.WriteLine("Didziausia alga: " + p.DidziausiaAlga(atlyginimai) + "Eur.");
            Console.WriteLine("Vidutine alga: " + p.AlguVidurkis(atlyginimai) + "Eur.");
            Console.WriteLine("Kiek zmoniu gauna didesne nei vidutine alga: " + p.KiekVirsVidurkio(atlyginimai) + " zmones");
            p.TrysDidziausios(atlyginimai);

        }

        public void Ivedimas(List<double> atlyginimai)
        {
            Console.WriteLine("Kiek atlyginimu norima ivesti?");
            var kiekAtlyginimu = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekAtlyginimu; i++)
            {
                Console.WriteLine("Iveskite {0} atlyginima: ", i + 1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> atlyginimai)
        {

            foreach (var atlyginimas in atlyginimai)
            {
                Console.Write("[{0}] ", atlyginimas);
            }
        }

        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }

        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }

        public double AlguVidurkis(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        public double KiekVirsVidurkio(List<double> atlyginimai)
        {
            var kiekDaugiau = 0.0;
            var vidurkis = atlyginimai.Average();
            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas > vidurkis)
                {
                    kiekDaugiau++;
                }
            }
            return kiekDaugiau;
        }

        public void TrysDidziausios(List<double> atlyginimai)
        {
            var didziausia1 = DidziausiaAlga(atlyginimai);
            var didziausia2 = MaziausiaAlga(atlyginimai);
            var didziausia3 = MaziausiaAlga(atlyginimai);

            foreach (var alg in atlyginimai)
            {
                if (didziausia1 > didziausia2 && didziausia2 < alg)
                {
                    if (didziausia1 != alg)
                    {
                        didziausia2 = alg;
                    }
                }

                if (didziausia2 > didziausia3 && didziausia3 < alg)
                {
                    if (didziausia2 != alg)
                    {
                        didziausia3 = alg;
                    }
                }
            }

            Console.WriteLine("Didziausia alga: {0} eur.", didziausia1);
            Console.WriteLine("Antra pagal dydi alga: {0} eur.", didziausia2);
            Console.WriteLine("Trecia paga dydi alga: {0} eur.", didziausia3);

        }
    }
}
