using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite betkoki skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(skaicius + "^2 = " + (skaicius*skaicius) );
        }
    }
}
