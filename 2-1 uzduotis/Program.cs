using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_uzduotis

// 1. Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.

// 2. Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi: 
// “Įvestas amžius: {amžius}”. Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje turi būti įstatyta.

// 3. Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje be tarpų tarp šių skaičių
// (skaičius - 25, išvedimas - 2525252525).

// 4. Susikurkite skaičiaus kintamąjį, kurį išveskite penkis kartus toje pačioje eilutėje su tarpais tarp šių skaičių 
// (skaičius - 25, rezultatas - 25 25 25 25 25).

{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Arimantai";
            var amzius = 28;
            var skaicius = 25;
            var marke = "VAZ";
            var modelis = 2101;
            var metai = 1968;
            var rida = 453200;

            Console.WriteLine("Labas " + vardas);
            Console.WriteLine("");
            Console.WriteLine("Ivestas amzius: {0}", amzius);
            Console.WriteLine("");
            Console.WriteLine("{0}{0}{0}{0}{0}", skaicius);
            Console.WriteLine("");
            Console.WriteLine("{0} {0} {0} {0} {0}",skaicius);
            Console.WriteLine("");
            Console.WriteLine("****");
            Console.WriteLine("*  *");
            Console.WriteLine("*  *");
            Console.WriteLine("****");
            Console.WriteLine("");
            Console.WriteLine("Automobilis: {0} {1} ({2} m.) Rida: {3} km.", marke, modelis, metai, rida);

        }
    }
}
