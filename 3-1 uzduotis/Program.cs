using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4;
            var b = 5;
            var c = 6;

            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " + " + b + " = " + (a - b));
            Console.WriteLine(a + " x " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + ((double)a / b));
            Console.WriteLine("");
            Console.WriteLine("{0}^2 = " + (a * a), a);
            Console.WriteLine("{0}^3 = " + (a * a * a), a);
            Console.WriteLine("");
            Console.WriteLine("{0} x {1} x {2} = {3}", a, b, c, a * b * c);
            Console.WriteLine("");
            Console.WriteLine("{0} + {1} x {2} = {3}", -1, 4, 6, -1 + 4 * 6);
            Console.WriteLine("({0} + {1}) % {2} = {3}", 35, 5, 7, (35 + 5) % 7);
            Console.WriteLine("{0} + {1} * {2} / {3} = {4}", 14, -4, 6, 11, (14 + (-4) * 6 / 11));
            Console.WriteLine("{0} + {1} / {2} * {3} - {4} % {5} = {6}", 2, 15, 6, 1, 7, 2, (2 + 15 / 6 * 1 - 7 % 2));
            Console.WriteLine("");

            var d = 0; //pradedam nuo 0 daugint
            Console.WriteLine("Draugybos lentelė iš " + a + ":");
            while (d <= 10) // kol 0 pasiekia 10
            {
                Console.WriteLine("{0} * {1} = {2}", a, d, a * d);
                d++;
            }
            Console.WriteLine("");

            /*
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            Console.WriteLine("{0} * {1} = {2}", a, d, a*d++ );
            */

            var e = 25;
            var f = e / 10;
            var g = e % 10;
            Console.WriteLine("Skaicius: " + e);
            Console.WriteLine("Jo skaitmenu sandauga: {1} * {2} = {3}", e, f, g, f * g);
            Console.WriteLine("");
        }

    }
}
