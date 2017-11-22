using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_34___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());

            if (sk1 > sk2 || sk1 == 0)
            {
                Console.WriteLine("Skaicius {0} > {1} arba lygus 0", sk1, sk2);
            }
            if (sk2 > sk1 || sk2 == 5)
            {
                Console.WriteLine("Skaicius {0} > {1} arba lygus 0", sk2, sk1);
            }
            if (sk1 > sk2 && sk1 == 20)
            {
                Console.WriteLine("Skaicius {0} > {1} ir yra lygus 20", sk1, sk2);
            }
            if (sk2 > sk1 && sk2 < 100)
            {
                Console.WriteLine("Skaicius {0} > {1} ir {0} < 100", sk2, sk1);
            }
            if (sk1 == sk2)
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
        }
    }
}
