using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pav___1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] skaiciai = {8, 7, 4, 6, 4, 3, 9, 4};
            Console.WriteLine(skaiciai[0]);
            Console.WriteLine(skaiciai[2]);
            Console.WriteLine(skaiciai[3]);
            Console.WriteLine(skaiciai[5]);
            Console.WriteLine(skaiciai[4]);*/

            Console.WriteLine();
            var suma = 0;

            char[] raides = { 'a', 'g', 'j', 'y', 'h', 's', 'h', 'k'};
            Console.WriteLine(raides[0]);
            Console.WriteLine(raides[2]);
            Console.WriteLine(raides[3]);
            Console.WriteLine(raides[5]);
            Console.WriteLine(raides[4]);

            int[] skaiciukai = {1, 8, 10, -10, 40};

            var sumike = skaiciukai.Sum();

            Console.WriteLine(sumike);

            foreach (var skaicius in skaiciukai)
            {
                suma += skaicius;
            }
            Console.WriteLine();
            Console.WriteLine(suma);

            //int[] skaiciai = { 8, 7, 4, 6, 4, 3, 9, 4 };
            /*int[] skaiciai = new int[20];
            Console.WriteLine(skaiciai[0]);
            Console.WriteLine(skaiciai[2]);
            Console.WriteLine(skaiciai[3]);
            Console.WriteLine(skaiciai[5]);
            Console.WriteLine(skaiciai[4]);*/

            Console.WriteLine();

            foreach (var raide in raides)
            {
                Console.Write(raide + " ");
            }

        }
    }
}
