using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_22_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 1 skaiciu: ");
            var sk1 = Convert.ToInt16(Console.ReadLine());

            if (sk1 > 0)
            {
                Console.WriteLine("{0} yra teigiamas", sk1);
            }
            else if (sk1 < 0)
            {
                Console.WriteLine("{0} yra neigiamas", sk1);
            }
            else
            {
                Console.WriteLine("Jus ivedestas skaicius yra lygus 0", sk1);
            }
        }
    }
}

