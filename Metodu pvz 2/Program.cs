using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodu_pvz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite staciakampio krastiniu ilgius: ");
            var krastine1 = Convert.ToInt32(Console.ReadLine());
            var krastine2 = Convert.ToInt32(Console.ReadLine());
            var plotas = StacPlotas(krastine1, krastine2);
            var perimetras = StacPerimetras(krastine1, krastine2);
            Console.WriteLine("Plotas: {0}m2", plotas);
            Console.WriteLine("Perimetras: {0}m", perimetras);
            Console.WriteLine();
            Console.WriteLine("Iveskite trikampio krastiniu ilgius: ");
            var aukstis = Convert.ToInt32(Console.ReadLine());
            var plotis = Convert.ToInt32(Console.ReadLine());
            var trikPlotas = TrikPlotas(aukstis, plotas);
            Console.WriteLine("Trikampio plotas: {0}m2", trikPlotas);
        }

        private static int StacPlotas(int a, int b)
        {
            return a * b; 
        }

        private static int StacPerimetras(int a, int b)
        {
            return a * 2 + b * 2;
        }

        private static double TrikPlotas(int a, int b)
        {
            return 0.5 * (a * b);
        }
    }
}
