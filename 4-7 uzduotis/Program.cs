using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite oro temperatura laipsniai: ");
            var temp = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0}C yra {1}K ir {2}F", temp, temp + 273.15, (temp*1.8)+32);
        }
    }
}