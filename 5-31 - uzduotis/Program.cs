using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_31___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());
            var sk3 = Convert.ToInt16(Console.ReadLine());

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("{0} yra didziausias", sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine("{0} yra didziausias", sk2);
            }
            else if (sk3 > sk1 && sk3 > sk1)
            {
                Console.WriteLine("{0} yra didziausias", sk3);
            }
            else
            {
                Console.WriteLine("Visi skaiciai lygus");
            }
        }
    }
}
