using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sudeti i masuva skaicius kurie dalinasi is 5 patenka i rezius 30 - 150

            var skaiciai = new int[120];
            var indeksas = 0;

            for (int i = 30; i <= 150; i++)
            {
                if (i % 5 == 0)
                {
                    skaiciai[indeksas] = i;
                    indeksas++;
                }
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write("[{0}]", skaicius);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < indeksas; i++)
            {
                Console.Write("[{0}]", skaiciai[i]);
            }

            //rasti skaiciu suma, vidurki, didziausia, maziausia, skaicius
            //is turimo masyvo

            //sumos paieskai

            Console.WriteLine();
            Console.WriteLine();

            var suma = 0;

            for (int i = 0; i < indeksas; i++)
            {
                suma += skaiciai[i];
            }

            Console.WriteLine("suma: " + suma);

            // vidurkio paieska

            var vidurkis = (double) suma / indeksas;

            Console.WriteLine("vidurkis: " + vidurkis);

            // didziausio skaiciaus paieska

            var didziausias = skaiciai[indeksas-1];

            Console.WriteLine("didziausias: " + didziausias);

            //maziausio skaiciaus paieska

            var maziausiais = skaiciai[0];

            Console.WriteLine("maziausiai: " + maziausiais);
        }
    }
}
