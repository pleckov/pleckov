using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaiciuos skaicius nuo 1 iki 10");
            var kintamasis = 1;
            while (kintamasis <= 10)
            {
                Console.WriteLine(kintamasis);
                kintamasis++;

                Console.WriteLine(Math.Pow(kintamasis, 2));

                /*if ()
                {

                }*/
            }
        }
    }
}
