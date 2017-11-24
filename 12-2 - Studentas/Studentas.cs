using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2___Studentas
{
    class Studentas
    {

        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pravarde { get; private set; }
        public int Amzius { get; private set; }
        public List<int> MatematikosPazymiai { get; private set; }
        public List<int> InformatikosPazymiai { get; private set; }
        public List<int> BiologijosPazymiai { get; private set; }

        public Studentas(string vardas, string pavarde, string praverde, int amzius, List<int> matematikosPazymiai, List<int> informatikosPazymiai, List<int> biologijosPazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pravarde = praverde;
            Amzius = amzius;
            MatematikosPazymiai = matematikosPazymiai;
            InformatikosPazymiai = informatikosPazymiai;
            BiologijosPazymiai = biologijosPazymiai;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentas: {0} '{1}' {2}, {3} (m.)", Vardas, Pravarde, Pavarde, Amzius);
            Console.WriteLine("Matematikos pazymiai:");
            foreach (var pazymiai in MatematikosPazymiai)
            {
                Console.Write(pazymiai + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Informatikos pazymiai:");
            foreach (var pazymiai in InformatikosPazymiai)
            {
                Console.Write(pazymiai + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Biologijos pazymiai:");
            foreach (var pazymiai in BiologijosPazymiai)
            {
                Console.Write(pazymiai + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Studento pazymiu vidurkis: {0}", Vidurkis());
            Console.WriteLine("Didziausias studento pazimys: {0}", Didziausias());
        }

        public double Vidurkis()
        {
            return Math.Round((MatematikosPazymiai.Average() + InformatikosPazymiai.Average() + BiologijosPazymiai.Average()) / 3, 2);
        }

        public int Didziausias()
        {
            var didziausias1 = MatematikosPazymiai.Max();
            var didziausias2 = InformatikosPazymiai.Max();
            var didziausias3 = BiologijosPazymiai.Max();

            if (didziausias1 > didziausias2 && didziausias1 > didziausias3)
            {
                return didziausias1;
            }
            else if (didziausias2 > didziausias1 && didziausias2 > didziausias3)
            {
                return didziausias2;
            }
            else if (didziausias3 > didziausias1 && didziausias3 > didziausias2)
            {
                return didziausias3;
            }
            return didziausias1;
        }


    }
}
