using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_8___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 20;
            Console.WriteLine("Tikrinimas: ");
            for (int i = suma; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
                Console.Write(suma + " "); // tikrinimas ar gerai skaiciuoja
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lyginiu skaiciu nuo 20 iki 50 suma yra lygi: " + suma);
        }
    }
}
