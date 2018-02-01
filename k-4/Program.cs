using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            var pinigai = new List<int>
            {
                650, 99, 105, 367, 78, 68, 42, 78, 89, 2554,
                65, 98, 25, 87, 1000
            };

            //bandom patys isvesti
            Console.WriteLine();

            foreach (var fan in pinigai)
            {
                Console.WriteLine("musu pinigai ir pinigu kiekiai: " + fan);
                suma += fan;
            }
            //rasti min, max, vidurki
            Console.WriteLine();

            var maziausias = pinigai.Min();
            var didziausias = pinigai.Max();
            var vidurkis = pinigai.Average();
            var sumike = pinigai.Sum();


            Console.WriteLine();
            Console.WriteLine("Maziausias pinigas: " + maziausias);
            Console.WriteLine("Didziausiais pinigas: " + didziausias);
            Console.WriteLine("Pinigu vidurkis: " + vidurkis);
            Console.WriteLine("suma " + suma);
            Console.WriteLine("sumike " + sumike);

            Console.WriteLine();


        }
    }
}
