using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Arimantai");
            programa.Pasisveikinti("Arimantai", "Palavinskai");
            Console.WriteLine();
            programa.Atsisveikinti();
            programa.Atsisveikinti("Arimantai");
            programa.Atsisveikinti("Arimantai", "Palavinskai");
            Console.WriteLine();
            StatinisMetodas();
            Console.WriteLine();
            var sumosAts = programa.Suma(4, 5);
            Console.WriteLine(sumosAts);
            Console.WriteLine();
            Console.WriteLine("8 + 9 = " + programa.Suma(8, 9));
            Console.WriteLine("8 - 9 = " + programa.Skirtumas(8, 9));
            Console.WriteLine("8 x 9 = " + programa.Sandauga(8, 9));
            Console.WriteLine("8 / 9 = " + programa.Dalyba(8, 9));
            Console.WriteLine();
            Console.WriteLine("Iveskite 2 skaicius: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var daugyba = programa.Sandauga(pirmas, antras);
            var dalyba = programa.Dalyba(pirmas, antras);
            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0} x {1} = {2}", pirmas, antras, daugyba);
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, dalyba);
        }

        public void Pasisveikinti()
        {
            Console.WriteLine("Labas");
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas " + vardas);
        }

        public void Pasisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas " + vardas + " " + pavarde);
        }


        public void Atsisveikinti()
        {
            Console.WriteLine("Viso");
        }

        public void Atsisveikinti(string vardas)
        {
            Console.WriteLine("Viso " + vardas);
        }

        public void Atsisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Viso " + vardas + " " + pavarde);
        }

        public static void StatinisMetodas()
        {
            Console.WriteLine("Statinis metodas");
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Skirtumas(int a, int b)
        {
            return a - b;
        }

        public int Sandauga(int a, int b)
        {
            return a * b;
        }

        public double Dalyba(int a, int b)
        {
            return Math.Round((double)a / b, 2);
        }
    }
}
