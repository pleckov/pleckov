using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_seima
{
    class Zmogus
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int Ugis { get; private set; }
        public int Amzius { get; private set; }
        public string Lytis { get; private set; }

        public Zmogus(string vardas, string pavarde, int ugis, int amzius, string lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Ugis = ugis;
            Amzius = amzius;
            Lytis = lytis;


        }

        public Zmogus()
        {
            Ivedimas();
        }


        //isvedimas
        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} {2 m.}, kurio ugis {3} yra lytis {4}",
            Vardas, Pavarde, Amzius, Ugis, Lytis);
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite info apie zmogu");
            Console.WriteLine("Vardas ");
            Vardas = Console.ReadLine();

            Console.WriteLine("Pavarde ");
            Pavarde = Console.ReadLine();

            Console.WriteLine("Amzius ");
            Amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ugis ");
            Ugis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lytis ");
            Lytis = Console.ReadLine();
        }

    }
}
