using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1._1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new int [] {0, 100, -1, 5, -8, 28, 35, -45, 7, 6, -2, -8, -7, -2, -8, -7 };
            //var min = temp.Min();
            var min = 231270;
            var max = -1000;
            var ave = 0;
            var suma = 0;
            var kiekis = 0;

            foreach (var skirtumai in temp)
            {
                if (min > skirtumai)
                {
                    min = skirtumai;
                }

                if (max < skirtumai)
                {
                    max = skirtumai;
                }

                suma = skirtumai + suma;
                kiekis++;

            }

            ave = suma / kiekis;

            var mazesni = 0;
            var didesni = 0;

            foreach (var kiekiai in temp)
            {
                if (ave > kiekiai)
                {
                    mazesni++;
                }
                else
                {
                    didesni++;
                }
            }
            
            Console.WriteLine("temperaturu min: " + min);
            Console.WriteLine("temperaturu max: " + max);
            Console.WriteLine("temp vidurkis: " + suma / kiekis);
            Console.WriteLine();
            Console.WriteLine(didesni);
            Console.WriteLine(mazesni);


            //Console.WriteLine(min);
            //var maks = temp.Max();
            //Console.WriteLine(maks);
        }
    }
}
