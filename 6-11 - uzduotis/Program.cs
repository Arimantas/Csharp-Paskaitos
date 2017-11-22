using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite gerima (1 - vanduo, 2 - kava, 3 - arbata)");
            var pasirinkimas = Convert.ToInt16(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }
        }
    }
}