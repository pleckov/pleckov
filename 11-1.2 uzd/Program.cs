using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1._2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new int[] {9, 8, 3, 4, 3, 1, 2, 9, 5, 2, 8, 7, 6};
            var geras = 0;
            var pirmunai = 0;
            var dvejetukai = 0;
            var vidurkis = 0;
            var geriausi = 0;
            var blogiausi = 0;
            var kiekis = 0;
            var suma = 0;

            foreach (var skiacius in pazymiai)
            {
                if (geras < skiacius)
                {
                    geras = skiacius;
                }

                if (10 == skiacius)
                {
                    geriausi++;
                }

                if (4 > skiacius)
                {
                    blogiausi++;
                }

                suma = skiacius + suma;
                kiekis++;
            }
            Console.WriteLine("Geriauses pazymys yra: " + geras);
            Console.WriteLine("Geriausiu pazymiu skaicius: " + geriausi);
            Console.WriteLine("Blogiausiu pazymiu skaicius: " + blogiausi);
            Console.WriteLine("vidurkis " + suma / kiekis);
        }
    }
}
