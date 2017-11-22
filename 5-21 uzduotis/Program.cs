using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_21_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());
            var sk2 = Convert.ToInt16(Console.ReadLine());

            if (sk1 > sk2)
            {
                Console.WriteLine("{0} > {1}", sk1, sk2);
            }
            else if (sk1 < sk2)
            {
                Console.WriteLine("{0} < {1}", sk1, sk2);
            }
            else
            {
                Console.WriteLine("{0} = {1}", sk1, sk2);
            }
        }
    }
}
