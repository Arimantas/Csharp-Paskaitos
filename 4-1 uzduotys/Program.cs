using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo varda: ");
            var vardas = Console.ReadLine();
            Console.Write("Iveskite savo amziu: ");
            var amzius = Convert.To(Console.ReadLine());
            Console.WriteLine("Tavo vardas yra " + vardas + ", tau yra " + amzius + " metu(-ai).");
        }
    }
}
