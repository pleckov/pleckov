using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite zodi arba exit: ");
            var zodis = "akjhkjhkj";
            var visi = "";

            while (zodis != "exit")
            {
                Console.Write("iveskite kita zodi: ");
                zodis = Convert.ToString(Console.ReadLine());

                if ( zodis != "exit" )
                    
                {
                    visi = visi + " " + zodis;
                }
            }
            Console.WriteLine(visi);
        }
    }
}
