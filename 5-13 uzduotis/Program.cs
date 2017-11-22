using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite oro temperatura");
            var temp = Convert.ToInt16(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("{0} < 0C - Ziauriai salta", temp);
            }
            else if (temp < 10)
            {
                Console.WriteLine("{0} < 10C - Labai salta", temp);
            }
            else if (temp < 20)
            {
                Console.WriteLine("{0} < 20C - Salta", temp);
            }
            else if (temp < 30)
            {
                Console.WriteLine("{0} < 30C - Normali temperatura", temp);
            }
            else if (temp < 40)
            {
                Console.WriteLine("{0} < 40C - Karsta", temp);
            }
            else if (temp > 40)
            {
                Console.WriteLine("{0} > 40C - Visiskai degina", temp);
            }
        }
    }
}