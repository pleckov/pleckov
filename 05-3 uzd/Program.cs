using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaiciu");
            var sk = Convert.ToInt64(Console.ReadLine());

            if (sk < 0)
            {
                Console.WriteLine("Jus ivedete neigiama skaiciu!!!");
            }

            if (sk > 0)
            {
                Console.WriteLine("Aciu uz teigiama skaiciu!");
            }

            if (sk % 2 == 0)
            {
                Console.WriteLine("skaicius yra lyginis");
            }

            if (sk / 4 == 0) // nezinau kaip teisingai patikrinti ar dalinasi
            {
                Console.WriteLine("skaicius dalinasi is keturiu");
            }

            if (sk > 10)
            {
                Console.WriteLine("Jusu skaicius yra didesnis uz 10");
            }


        }
    }
}
