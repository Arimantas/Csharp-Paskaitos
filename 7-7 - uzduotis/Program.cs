using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var suma = 1;
            for (int i = suma; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaiciu nuo 1 iki 100 suma yra: " + suma);
        }
    }
}
