using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var a = 1;
            var b = 1;

            while (a != 0 || b != 0)
            {
                Console.WriteLine("skaiciuotuvas");
                Console.WriteLine("iveskite du skaicius");

                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);

            }
            
        }
    }
}
