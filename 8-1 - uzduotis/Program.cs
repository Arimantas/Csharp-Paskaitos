using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 7, 5, 3, 8, 9 };

            string[] markes = new string[5];
            markes[0] = "BMW";
            markes[1] = "Audi";
            markes[2] = "Mercedes";
            markes[3] = "Opel";
            markes[4] = "Kia";

            string[] masyvas = new string[4];
            masyvas[0] = "Cia";
            masyvas[1] = "yra";
            masyvas[2] = "mano";
            masyvas[3] = "masyvas";

            Console.WriteLine("Masyvu dydziai");
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine(markes.Length);
            Console.WriteLine(masyvas.Length);
            Console.WriteLine();
            Console.WriteLine(pazymiai.First());
            Console.WriteLine(pazymiai.Last());
            Console.WriteLine(pazymiai[pazymiai.Length-1]);


            var skaiciai = new int[5];
            Console.WriteLine("Iveskite skaicius");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " - ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + " ");
            }
        }
    }
}
