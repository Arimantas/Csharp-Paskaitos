using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo amziu: ");
            var amzius = Convert.ToInt16(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Sveikinu, alkoholi jau gali vartoti legaliai");
            }

        }
    }
}
