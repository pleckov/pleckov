using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaicius: ");
            var sk = Convert.ToInt32(Console.ReadLine());

            while (sk % 9 != 0)
            {
                Console.Write("Iveskite skaicius: ");
                sk = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Jusu ivestas skaicius dalinasi is 9: " + sk);
        }
    }
}
