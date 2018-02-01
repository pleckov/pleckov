using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda:");
            var vardas = Console.ReadLine();

            Console.WriteLine("Iveskite Amziu: ");
            var amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Jusus varda {0}, o amzius {1}.", vardas, amzius);

            Console.ReadLine();



        }
    }
}
