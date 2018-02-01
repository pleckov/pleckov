using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite pirma skaiciu: ");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu per kableli: ");
            var antras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu suma bus atlikus matematika: {0} + {1} = {2}", pirmas, antras, pirmas + antras);

            Console.Write("Iveskite savo ugi ir mes paskaiciuosime kiek truksta iki 5 ugio: ");
            var ugis = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Jums iki 5 ugio truksta " + (5-ugis) + " ugio");
        }
    }
}
