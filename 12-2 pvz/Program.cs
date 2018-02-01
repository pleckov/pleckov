using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //duomenys jau zinomi kiek turime ir t.t.

            var pinigai = new List<int>
            {
                650, 99, 105, 367, 78, 68, 42, 78, 89, 2554,
                65, 98, 25, 87
            };
            
            //bandom patys isvesti
            Console.WriteLine();

            foreach (var fan in pinigai)
            {
                Console.WriteLine("musu pinigai ir pinigu kiekiai: " + fan);
            }
            //rasti min, max, vidurki
            Console.WriteLine();

            var maziausias = pinigai.Min();
            var didziausias = pinigai.Max();
            var vidurkis = pinigai.Average();

            Console.WriteLine();
            Console.WriteLine("Maziausias pinigas: " + maziausias);
            Console.WriteLine("Didziausiais pinigas: " + didziausias);
            Console.WriteLine("Pinigu vidurkis: " + vidurkis);

            Console.WriteLine();

            //atrinkti i kita sarasa mazesnius i vidurki

            var mazUzVid = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas<vidurkis)
                {
                    mazUzVid.Add(pinigas);
                }
            }

            Console.WriteLine("mazesnis uz vidurki: ");

            foreach (var i in mazUzVid)
            {
                Console.WriteLine(i + ", ");
            }

            Console.WriteLine();

            // atrinkti i kita sarasa ligynius skaicius

            var lyginis = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas % 2 == 0)
                {
                    lyginis.Add(pinigas);
                }
            }

            Console.WriteLine("lyginiai skaiciai: ");

            foreach (var i in lyginis)
            {
                Console.WriteLine(i + ", ");
            }

            Console.WriteLine();

            //atrinti i kita sarasa skaicius tarp 30 ir max

            var minpin = new List<int>();

            foreach (var i in minpin)
            {

            }
        }
    }
}
