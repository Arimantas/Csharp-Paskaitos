using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gyvuno rusi: ");
            var rusis = Console.ReadLine();

            switch (rusis)
            {
                case "suo":
                    Console.WriteLine("Ivestas gyvunas yra suo");
                    break;
                case "kate":
                    Console.WriteLine("Ivestas gyvunas yra kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Ivestas gyvunas yra ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("Ivestas gyvunas yra triusis");
                    break;
                case "papuga":
                    Console.WriteLine("Ivestas gyvunas yra papuga");
                    break;
                default:
                    Console.WriteLine("Ivestas gyvunas yra kitos rusies");
                    break;
            }
        }
    }
}
