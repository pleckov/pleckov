using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama sveika skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusu ivestas skaicius yra: " + skaicius);
            while (skaicius > 0)
            {
                //Console.WriteLine(skaicius);
                //skaicius--;
                //skaicius = skaicius - 1;

                Console.WriteLine(skaicius--);
            }
        }
    }
}
