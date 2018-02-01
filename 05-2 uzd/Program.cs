using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo amziu: ");

            var amzius = Convert.ToInt32(Console.ReadLine());

            if (18 <= amzius)
            {
                Console.WriteLine("Jus jau galite balsuoti");
            }

            if (18 > amzius)
            {
                Console.WriteLine("Deja, bet jus dar negalite balsuoti");
            }
            
        }
    }
}
