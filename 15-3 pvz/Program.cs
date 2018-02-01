using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_pvz
{
    class Automobilis // prop -> tab
    {
        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliaKw { get; set; }

        //apsirasome konstruktoriu, trumpinys // ctor
        //ctor

        public Automobilis()
        {

        }

        public Automobilis(string spalva, string marke, string modelis, int rida, int pavaros, double darbinisTuris, int galiaKw)
        {
            Spalva = spalva;
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Pavaros = pavaros;
            DarbinisTuris = darbinisTuris;
            GaliaKw = galiaKw;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilio duomenys: ");
            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Rida: " + Rida);
            Console.WriteLine("Pavaros: " + Pavaros);
            Console.WriteLine("Modelis: " + Modelis);
            Console.WriteLine("Galia kw: " + GaliaKw);
            Console.WriteLine();
        }

    }//automobilis klases pabaiga

    



    class Program
    {
        static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis(); //objektas
            automobilis.Marke = "AAA";
            automobilis.Modelis = "BBB";
            automobilis.Rida = 300000;
            automobilis.DarbinisTuris = 2.0;
            automobilis.Pavaros = 5;
            automobilis.GaliaKw = 150;

            Console.WriteLine(automobilis.Marke);
            Console.WriteLine(automobilis.Modelis);

            Console.WriteLine();
            automobilis.Isvedimas();
            //...

            var auto2 = new Automobilis
            {
                Marke = "Audi",
                Modelis = "simtine",
                Spalva = "geltona",
                DarbinisTuris = 1.8,
                Rida = 20000,
                Pavaros = 4,
                GaliaKw = 160
            };

            Console.WriteLine();
            Console.Write("auto galis " + auto2.GaliaKw + " modelis: " + auto2.Modelis);
            Console.WriteLine();
            //
            auto2.Isvedimas();



            var auto3 = new Automobilis("juoda", "kiau", "daugiau", 255000, 5, 3, 120);
            Console.WriteLine(auto3.GaliaKw);
            Console.WriteLine(auto3.Marke);
            Console.WriteLine(auto3.Spalva);

            Console.WriteLine();

            auto3.Isvedimas();
        }
    }
}
