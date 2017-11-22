using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___klasiu_pvz_2__masinos_
{
    class Program
    {
        static void Main(string[] args)
        {
            // var auto = new Automobilis("VAZ", "2101", 1968, 1.3, 35, 975000);
            // auto.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis("BMW", "318", 1998, 2.5, 118, 470000),
                new Automobilis("Audi", "A6", 2004, 1.9, 92, 425000),
                new Automobilis("Ford", "Sierra", 1988, 2.5, 92, 598050),
                new Automobilis("Opel", "Astra", 2005, 1.3, 72, 298500),
        };

            var p = new Program();
            p.Isvedimas(automobiliai);

            var naujausias = p.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias automobilis:");
            naujausias.Isvedimas();

            var seniausias = p.SeniausiasAuto(automobiliai);
            Console.WriteLine("Seniausias automobilis:");
            seniausias.Isvedimas();

            var didziausiosGalios = p.DidziausiosGaliosAuto(automobiliai);
            Console.WriteLine("Didziausios galios automobilis:");
            didziausiosGalios.Isvedimas();

            var maziausiosRidos = p.MaziausiosRidosAuto(automobiliai);
            Console.WriteLine("Maziausios ridos automobilis:");
            maziausiosRidos.Isvedimas();

        }

        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }


        // naujausias automobilis
        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (laikinas.Metai < auto.Metai)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }

        
        public Automobilis SeniausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (laikinas.Metai > auto.Metai)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }

        
        public Automobilis DidziausiosGaliosAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (laikinas.Galia < auto.Galia)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }


        public Automobilis MaziausiosRidosAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (laikinas.Rida > auto.Rida)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }

    }
}

