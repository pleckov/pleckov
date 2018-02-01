using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var randObj = new Random();
            var atsitiktinis_skaicius1 = randObj.Next(1, 10);
            var sk = 11;

            while (atsitiktinis_skaicius1 != sk)
            {
                //atsitiktinis_skaicius1 = randObj.Next(1, 10);
                Console.WriteLine("Iveskite skaiciu: " /*+ atsitiktinis_skaicius1*/);
                sk = Convert.ToInt32(Console.ReadLine());

                if (atsitiktinis_skaicius1 > sk)
                {
                    Console.WriteLine("skaicius yra didesnis: ");
                }
                else
                {
                    Console.WriteLine("skaicius yra mazesnis");
                }
            }

            Console.WriteLine("jus atspejote: " + sk);
        }
    }
}
