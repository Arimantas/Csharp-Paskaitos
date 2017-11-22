using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu sekos pradzia ir pabaiga");
            var start = Convert.ToInt32(Console.ReadLine());
            var finish = Convert.ToInt32(Console.ReadLine());

            if (start <= finish)
            {
                for (int i = start; i < finish; i++)
                {
                    Console.WriteLine("{0} - {0}^2 = {1}", i, i * i);
                }
            }
            else
            {
                Console.WriteLine("Pabaiga yra didesne uz pradzia, tokia seka negalima");
            }
        }
    }
}
