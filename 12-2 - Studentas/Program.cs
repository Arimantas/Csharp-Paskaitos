using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2___Studentas
{
    class Program
    {
        static void Main(string[] args)
        {

            var studentas = new Studentas("Haris", "Potteris", "Opelis", 13,
                new List<int>
                {
                    10, 8, 9, 7, 10, 8, 9
                },
                                new List<int>
                                {
                                    8, 7, 8, 9, 7, 6, 9, 8
                                },
                                                new List<int>
                                                {
                                                    5, 4, 3, 6, 7, 5, 6, 4
                                                });

            studentas.Isvedimas();
        }
    }
}
