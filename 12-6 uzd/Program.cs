using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
             var randomas new Random();
             var suma = 0;

            for (int i = 0; i < 50; i++)
            {
                var skaicius = randomas.Next(20);
                Console.Write(skaicius + " ");

                suma += skaicius;
            }

            Console.WriteLine();
            Console.WriteLine("suma: " + suma);
        }
    }
}
