using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1
{
    class Studentas
    {
        //prop

        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Anmzius { get; set; }
        public int Ugis_cm { get; set; }

        public Studentas()
        {

        }

        public Studentas(string vardas, string pavarde, int amzius, int ugis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Anmzius = amzius;
            Ugis_cm = ugis;
        }


        public void Isvedimas()
        {
            Console.WriteLine(Vardas);
            Console.WriteLine(Pavarde);
            Console.WriteLine(Anmzius);
            Console.WriteLine(Ugis_cm);
        }

    }
}
