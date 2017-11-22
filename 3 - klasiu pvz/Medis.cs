using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___klasiu_pvz
{
    class Medis
    {
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public double Aukstis { get; private set; }

        public Medis()
        {

        }

        public Medis(string rusis, int amzius, double aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Rusis: {0}", Rusis);
            Console.WriteLine("Amzius: {0} metu (-ai)", Amzius);
            Console.WriteLine("Aukstis: {0} m.", Aukstis);
        }

        /*
        public AmziusDienomos()
        {
            var dienomis = Amzius * 365;
            return dienomis;
        }
        */

    }
}
