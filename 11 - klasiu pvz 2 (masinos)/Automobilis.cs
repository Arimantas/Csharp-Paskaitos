using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___klasiu_pvz_2__masinos_
{
    class Automobilis
    {
        public string Marke { get; private set; }  // propg
        public string Modeli { get; private set; }
        public int Metai { get; private set; }
        public double DarbinisTuris { get; private set; }
        public int Galia { get; private set; }
        public int Rida { get; private set; }


        public Automobilis()
        {

        }

        public Automobilis(string marke, string modelis, int metai, double darbinisTuris, int galia, int rida)
        {
            Marke = marke;
            Modeli = modelis;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
            Galia = galia;
            Rida = rida;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilio marke: {0}", Marke);
            Console.WriteLine("Automobilio modelis: {0}", Modeli);
            Console.WriteLine("Automobilio pagaminimo metai: {0} m.", Metai);
            Console.WriteLine("Variklio darbinis turis: {0} l.", DarbinisTuris);
            Console.WriteLine("Variklio galia: {0} kW", Galia);
            Console.WriteLine("Automobilio rida: {0} km.", Rida);
            Console.WriteLine();
        }
    }

}
