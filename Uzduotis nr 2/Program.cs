using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_nr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primizliai = new List<double>();
            var p = new Program();
            p.Ivedimas(primizliai);
            p.Isvedimas(primizliai);
            Console.WriteLine();
            Console.WriteLine("Didziausias primilzis: {0} l.", p.Didziausia(primizliai));
            Console.WriteLine("Maziausias primilzis: {0} l.", p.Maziausia(primizliai));
            Console.WriteLine("Vidurinis primilzis: {0} l.", p.Vidutine(primizliai));
            p.DuDidziausi(primizliai);

            // ivedimo metodas
            // isvedimo metodas
            // min, max, average metodai
            // 2 didziausius
        }

        public void Ivedimas(List<double> primilziai)
        {
            Console.WriteLine("Primilziu kiekis?");
            var kiekPrimilziu = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekPrimilziu; i++)
            {
                Console.WriteLine("Iveskite {0} karves dienos primilzi (litrais): ", i + 1);
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> primilziai)
        {

            foreach (var primilzis in primilziai)
            {
                Console.Write("[{0}] ", primilzis);
            }
        }

        public double Didziausia(List<double> primilziai)
        {
            return primilziai.Max();
        }

        public double Maziausia(List<double> primilziai)
        {
            return primilziai.Min();
        }

        public double Vidutine(List<double> primilziai)
        {
            return Math.Round(primilziai.Average(), 1);
        }

        public void DuDidziausi(List<double> primelziai)
        {
            var didziausia1 = Didziausia(primelziai);
            var didziausia2 = Maziausia(primelziai);

            foreach (var primizlis in primelziai)
            {
                if (didziausia2 < didziausia1 && didziausia2 < primizlis && didziausia1 != primizlis)
                {
                        didziausia2 = primizlis;
                }
            }

            Console.WriteLine("Didziausias primilzis: {0} l." , didziausia1);
            Console.WriteLine("Antras didziausias primilzis: {0} l." , didziausia2);
        }
    }
}
