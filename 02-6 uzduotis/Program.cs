using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "Jonas";
            //====
            var ask = 10;
            var bsk = 20;
            //====
            var pavadinimas = "sniegena";
            var eilerastis = "Vaikas smegeneles pasisiuvo \n sau palei tvora";
            var zodziu_skaicius = 5;

            Console.WriteLine("Tekstas vienoje eiluteje");
            Console.Write("Tekstas toje ");
            Console.WriteLine("pacioje eiluteje");
            Console.WriteLine("Atsakymai:\n...");
            //sakinys
            Console.Write("Vienas ");
            Console.Write("zodis ");
            Console.Write("nesudaro ");
            Console.Write("sakinio ");
            Console.Write("vieno...\n");
            Console.WriteLine("Tekstas naujoje eiluteje\n");
            //vardas plius
            Console.WriteLine(vardas);
            Console.WriteLine("Studento vardas:" + vardas);

            //skiaciai
            Console.WriteLine("a={0}, b={1}", ask, bsk);

            //zodziu skaicius
            Console.WriteLine("Eilerastis" + pavadinimas);
            Console.WriteLine();
            Console.WriteLine(pavadinimas);
            Console.WriteLine();
            Console.WriteLine("Eilerastyje zodziu skaicius " + zodziu_skaicius);

            //skaiciu kitoks isvedimas
            Console.WriteLine("a={0}", ask);
            Console.WriteLine("a={0}", bsk);

            //Console.WriteLine();
            Console.ReadKey();
        }
    }
}
