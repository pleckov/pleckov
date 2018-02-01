using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var maz = 1;
            var didz = 0;
            var atsObj = new Random();
            var random_skaicius = atsObj.Next(1, 100);
            var atssk = 0;
            var min = 1000;
            var max = -1000;
            var suma = 0;
            var vidurkis = 0;
            var mazesniUzVidurki = 0;
            var lyginis = 0;

            List<int> skaiciai = new List<int>();

            while (random_skaicius != maz)
            {
                atssk = atsObj.Next(1, 100);
                skaiciai.Add(atssk);
                maz++;

                if (atssk < min)
                {
                    min = atssk;
                }

                if (atssk > max)
                {
                    max = atssk;
                }

                suma += atssk;

            }

            vidurkis = suma / random_skaicius;

            foreach (var skaiciavimai in skaiciai)
            {
                if (vidurkis < skaiciavimai)
                {
                    mazesniUzVidurki++;
                }
                if (skaiciavimai % 2 == 0)
                {
                    lyginis += skaiciavimai;
                }
            }
            Console.WriteLine("mesniu skaiciu uz vidurki skaicius " + mazesniUzVidurki);
            Console.WriteLine("lyginiu skaiciu suma " + lyginis);


            

            Console.WriteLine("vidurkis " + vidurkis);
            Console.WriteLine(random_skaicius);
            Console.WriteLine(atssk);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
