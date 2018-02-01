using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            //var pirmas = Convert.ToInt32(Console.ReadLine());
            //var antras = Convert.ToInt32(Console.ReadLine());

            var suma = 0;
            for (int i = 20; i < 100; i++)
            {
                suma += 1;
            }

            Console.WriteLine("atsakymas" + suma);
        }
    }
}
