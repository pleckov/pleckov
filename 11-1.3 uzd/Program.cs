using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1._3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {

            var kilometrai = new int[]{10, 258, 380, 110, 547, 23, 78, 100};
            var suma = 0;
            Console.WriteLine("Iveskite automobilio kuro sanaudas 100 km");
            var kursan = Convert.ToDouble(Console.ReadLine());
            var maks = -100000000;
            var mine = 100000000;
            var vidur = 0;

            foreach (var km in kilometrai)
            {
                suma += km;

                if (maks < km)
                {
                    maks = km;
                }

                if (mine > km)
                {
                    mine = km;
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (var san in kilometrai)
            {
                //Console.Write(san + " ");
                Console.WriteLine();
                Console.WriteLine("Nuvaziuota km: " + san + " kuro sanaudos: " + (double)+ san * kursan / 100 + " ltr");
            }

            Console.WriteLine();
            Console.WriteLine("Kilometru suma: " + suma + " km");
            Console.WriteLine("Bendros kuro sanaudos: " + (double)+suma * kursan / 100 + " ltr");
            Console.WriteLine("Ilgiause kelione: " + maks + " (km) kuro sanaudos: " + (double)+maks * kursan / 100 + " (ltr)");
            Console.WriteLine("trumpiause kelione: " + mine + " (km) kuro sanaudos: " + (double) + mine * kursan / 100 + " (ltr)");
        }


    }
}
