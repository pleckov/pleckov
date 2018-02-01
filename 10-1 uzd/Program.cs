using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1-kate, 2-suo, 3-ziurkenas");
                `pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 2)
                {
                    Console.WriteLine("blogas pasirinkimas");
                }
            } while (pasirinkimas <1 || pasirinkimas > 2);
            Console.WriteLine("pasrinkimas: " + pasirinkimas);
        }
    }
}
