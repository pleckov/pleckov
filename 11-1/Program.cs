using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sukurti studentu paz
            int[] pazymiai = {10, 8, 3, 5, 8, 7, 9};

            Console.WriteLine(pazymiai[1]); //8
            Console.WriteLine(pazymiai[3]); //5
            Console.WriteLine(pazymiai[5]); //7
            Console.WriteLine(pazymiai[6]); //9

            pazymiai[2] = 4;
            pazymiai[5] = 1;
            pazymiai[0] = 9;

            Console.WriteLine();

            foreach (var pazymys in pazymiai)
            {
                Console.WriteLine(pazymys + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < pazymiai.Length; i++)
            {
                Console.WriteLine(pazymiai[i] + " ");
            }

            Console.WriteLine();

            // vardai

            var vardai = new string[7];
            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine("Iveskite varda: ");
                vardai[i] = Console.ReadLine();
            }
            //pabandom isvesti viska is masyvo
            foreach (var vardas in vardai)
            {
                Console.WriteLine(vardas + ", ");
            }
            Console.WriteLine();

            // pazymaiai

            Console.WriteLine("kiek pazymiu nori suvesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.WriteLine("iveskite {0}-aji: ", i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("ivesti pazymiai:");

            //kazkuris gabalas

            //algoritmas - min pazymys

            var maziausiai = pazymiai2[0];

            foreach (var pazymys in pazymiai)
            {
                if (pazymys < maziausiai)
                {
                    maziausiai = pazymys;
                }
            }

            Console.WriteLine("maziausias: " + maziausiai);
            Console.WriteLine("maziausias: " + pazymiai2.Min());

            // algoritmas - maz pazymys
            // pabandom patys

        }
    }
}
