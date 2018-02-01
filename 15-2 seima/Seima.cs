using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_seima
{
    class Seima
    {
        public string Adresas { get; private set; }
        public List<Zmogus> Zmones { get; private set; }

        public Seima(string adresas, List<Zmogus> zmones)
        {
            Adresas = adresas;
            Zmones = zmones;
        }

        public void Isvedimas()
        {
            Console.WriteLine();
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite adrea: ");
            Adresas = Console.ReadLine();

            //klausti kiek zmoniu suvesti

            Console.WriteLine("Kiek zmoniu seimoje: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            // sukurti for cikla tiek kiek kartu reikia

            for (int i = 0; i < kiek; i++)
            {
                //kurti tuscia zmogaus objekta naudojant () - tuscia konstruktoriu
                var zmogus = new Zmogus(); // zmogaus konstruktorius iskvies ivedimo metoda

                // zmogaus obljekta ikelti i zmoniu sarasa

            


            }

        }
    }
}
