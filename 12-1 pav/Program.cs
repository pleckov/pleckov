using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_pav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu, kuris patenka tarp [0 - 100]");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius < 0 || skaicius > 100)
            {
                Console.WriteLine("Blogai ivestas skaicius. Bandykite dar karta!");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Jusu ivestas skaicius yra: " + skaicius);
        }
    }
}
