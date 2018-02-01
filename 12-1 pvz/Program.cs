using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("kiek pazymiu suvesti?");
            var pazymiai = new List<int>(); // sarasas

            Console.WriteLine("iveskite pavyzdzius, o noredami sustabdyti parasykite -1"); // papraso suvesti

            int pazymys; // apsirasome kintamaji

            do
            {
                pazymys = Convert.ToInt32(Console.ReadLine()); // duomenu suvedimas i sarasa
                if (pazymys != -1) // jei nelygus -1 vedam
                {
                    pazymiai.Add(pazymys); // pridedam i sarasa
                }
            } while (pazymys != -1); 

            Console.WriteLine();

            foreach (var paz in pazymiai)
            {
                Console.WriteLine(paz);
            }
        }
    }
}
