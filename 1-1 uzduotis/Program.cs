using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Arimantas";
            var pavarde = "Palavinskas";
            var amzius = 28;
            var ugis = 1.82;
            var svoris = 78;
            var aukstojiMokykla = "KTU";
            var akademineGrupe = "ST-8/4";
            var kursas = 10;
            var studijuProgramosPvd = "Statybos inzinerija";
            var atsiskaitytuKredituSk = "Visi";


            Console.WriteLine("Studentas: " + vardas + " " + pavarde + "  Amzius: " + amzius);
            Console.WriteLine("Ugis: " + ugis + " Svoris: " + svoris);
            Console.WriteLine("Aukstoji mokykla: " + aukstojiMokykla + " grupe: " + akademineGrupe + " kursas: " + kursas);
            Console.WriteLine("Studiju programa: " + studijuProgramosPvd + " Atsiskaityta kreditu: " + atsiskaitytuKredituSk);
            //Console.ReadLine();


        }
    }
}
