using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ifas, iveskite skiaciu");
            var sk = Convert.ToInt32(Console.ReadLine());

            if (sk == 5)
            {
                Console.WriteLine(sk + "yra lygus 5");
            }

            Console.WriteLine("Jusu skaicius yra didesnis negu 5");
        }
    }
}
