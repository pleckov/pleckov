using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //leisti pasirinkti skaicius ir suvesti i masyva: rasti vidurki, min max 
            //Abieju masyvu duomenys isvesti
            //perziureti video kad israsyti salyga

            Console.WriteLine("Kiek temperaturos norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var temperaturos = new int[kiek];

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite {0}-aja temperatura: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ivesti duomenys");
            foreach (var temperatura in temperaturos)
            {
                Console.Write("[{0}] ", temperatura);
            }
            Console.WriteLine();

            //suma

            var suma = 0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
                //suma = sume + temp
            }
            Console.WriteLine("suma: " + suma);

            //vidurkis

            var vidurkis = (double)suma / temperaturos.Length;
            Console.WriteLine("vidurkis: " + vidurkis);

            //maziausias temp

            var maziausiais = temperaturos[0];

            foreach (var temp in temperaturos)
            {
                if (temp<maziausiais)
                {
                    maziausiais = temp;
                }
            }
            Console.WriteLine("maziausias: "+ maziausiais);

            //didziausiai temperatura

            var didziausiais = 0;

            foreach (var temp in temperaturos)
            {
                if (temp > didziausiais)
                {
                    didziausiais = temp;
                }
            }
            Console.WriteLine("didziausiais: " + didziausiais);

            //temperaturos, kurios didesnes uz vidurki

            var atrinkta = new int[kiek];
            var KiekAtrinkta = 0;

            foreach (var temp in temperaturos)
            {
                if (temp>vidurkis)
                {
                    atrinkta[KiekAtrinkta] = temp;
                    KiekAtrinkta++;
                }
            }
            Console.WriteLine("Atrinkti duomenys");

            for (int i = 0; i < KiekAtrinkta; i++)
            {
                Console.Write("[{0}]", atrinkta[i]);
            }

            Console.WriteLine();
        }
    }
}
