using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_pav
{
    class Program
    {
        static void Main(string[] args)
        {
            //tema masinos

            var nuovatiKilometrai = new List<int>();
            Program programa = new Program();
            //metodai

            //duomenu suvedimui

            programa.Ivedimas(nuovatiKilometrai);

            //duomenu isvedimui

            programa.Isvedimas(nuovatiKilometrai, "PRADINIAI DUOMENYS");

            //skaiciavimu iskvietimu
            //suma
            //min
            //max
            //vidurkis (vikurkies kviecia )
            //atrinkimui i kita sarasa tinkamu duomenu

            programa.Skaiciavimai(nuovatiKilometrai);

            List<int> list = programa.Atrinkimas(nuovatiKilometrai);
            programa.Isvedimas(nuovatiKilometrai, "ATRINKTI DUOMENYS");

            


        }//metodo main pabaiga

        public void Ivedimas(List<int> sarasas)

        {
            var dar = true;

            while (dar)
            {
                Console.WriteLine("Iveskite kilometraza: ");
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("Norite kartoti t/n: ");
                var kartoti = Console.ReadLine();
                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }

        public void Isvedimas(List<int> sarsas, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var km in sarsas)
            {
                //isvedimas
                Console.WriteLine("[{0}]", km);
            }
            Console.WriteLine();
        }

        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }

        public int Maziausiais(List<int> sarasas)
        {
            return sarasas.Min();
        }

        public int Didziausiais(List<int> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List<int> sarasas)
        {
            var vidurkis = (double)Suma(sarasas) / sarasas.Count;
            return vidurkis;
        }

        public void Skaiciavimai(List<int> sarasas)
        {
            Console.WriteLine("Suma: " + Suma(sarasas));
            Console.WriteLine("Min: " + Maziausiais(sarasas));
            Console.WriteLine("Max: " + Didziausiais(sarasas));
            Console.WriteLine("Vidurkis: " + Vidurkis(sarasas));
        }

        public List<int> Atrinkimas(List<int> pradiniai)
        {
            //daugiau nei 300k, laikysim jau kaip graba
            var atrinkti = new List<int>();

            foreach (var km in pradiniai)
            {
                if (km > 300000)
                {
                    atrinkti.Add(km);
                }
            }
            return atrinkti;
        }

    }// class programm pabaiga
}
