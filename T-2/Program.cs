using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 uzd
            Console.WriteLine("Iveskite savo varda ir amziu:");
            Console.WriteLine("Iveskite savo varda: ");
            var vardas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Iveskite savo amziu:");
            var amzius = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();

            Console.WriteLine("Jusu vardas: " + vardas);
            Console.WriteLine("Jusu amzius: " + amzius);





        }
    }
}
