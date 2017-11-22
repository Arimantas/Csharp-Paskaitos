using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite betkoki skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var daugiklis = 1;
            Console.WriteLine();
            Console.WriteLine(skaicius + " daugybos lentele:");
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            Console.WriteLine("{0} x {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++ );
            
        }
    }
}
