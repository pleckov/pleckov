using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo penkis pazymius");
            var a = Convert.ToInt16(Console.ReadLine());
            var b = Convert.ToInt16(Console.ReadLine());
            var c = Convert.ToInt16(Console.ReadLine());
            var d = Convert.ToInt16(Console.ReadLine());
            var f = Convert.ToInt16(Console.ReadLine());
            var vidurkis = (a + b + c + d + f) / 5;

            //Console.WriteLine((a+b+c+d+f)/5);

            if (vidurkis > 5)
            {
                Console.WriteLine("Jusu vidurkis yra aukstesnis uz 5");
            }

            if (vidurkis < 5)
            {
                Console.WriteLine("Jusu vidurkis yra zemas");
            }

            if (vidurkis == 5)
            {
                Console.WriteLine("Jusu vidurkis yra lygus 5");
            }
        }
    }
}
