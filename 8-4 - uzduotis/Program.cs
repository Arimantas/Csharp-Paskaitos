using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4___uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var kuroSanaudos = 7;
            int[] keliones = { 152, 324, 20, 18, 359, 598, 12, 5 };

            var trumpKelione = keliones[0];
            foreach (var kelione in keliones)
            {
                if (trumpKelione > kelione)
                {
                    trumpKelione = kelione;
                }
            }
            Console.WriteLine("Trumpiausia kelione: " + trumpKelione);

            var ilgKelione = keliones[0];
            foreach (var kelione in keliones)
            {
                if (ilgKelione < kelione)
                {
                    ilgKelione = kelione;
                }
            }
            Console.WriteLine("Ilgiausia kelione: " + ilgKelione);

            var visiKm = 0;
            foreach (var kelione in keliones)
            {
                visiKm += kelione;
            }

            var kiekKuro = (visiKm / 100) * kuroSanaudos;
            Console.WriteLine("Nuvaziuotas atstumas: " + visiKm + "km.");
            Console.WriteLine("Kuro kiekis kurio prireike nuvaziuoti {0}km yra: {1} litru(-ai)", visiKm, kiekKuro);
        }
    }
}
