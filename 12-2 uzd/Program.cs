using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite neigiama sveika skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius < 1)
            {
                //Console.WriteLine(skaicius);
                //skaicius--;
                //skaicius = skaicius - 1;
                //Console.WriteLine("Jus ivedete teigima skaiciu, prasau ivesti neigiama skaiciu");
                //skaicius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(skaicius++);
            }
        }
    }
}
