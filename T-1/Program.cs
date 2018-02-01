using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var amzius = 39;
            var sk = 25;
            var zv = '*';

            //automobilis
            var pavad = "opel";
            var marke = "astra";
            var kubat = 1.9;
            var metai = 2007;
            var rida = 211367;

            //matematika
            var keturi = 4;
            var penki = 5;
            var suma = 5 * 5;

            Console.Write(" Audrius \n");
            Console.WriteLine("Audriaus amzius yra: {0}", amzius);

            Console.WriteLine("{0}{1}{2}{3}{4}", sk, sk, sk, sk, sk);
            Console.WriteLine(+sk+ ""+sk+""+sk);

            Console.WriteLine("{0} {1} {2} {3} {4}", sk, sk, sk, sk, sk);
            Console.WriteLine();

            Console.WriteLine(zv+"" + zv + "" + zv + "" + zv + "" + zv);
            Console.WriteLine();
            Console.WriteLine(zv + "   " + zv);
            Console.WriteLine();
            Console.WriteLine(zv + "   " + zv);
            Console.WriteLine();
            Console.WriteLine(zv + "" + zv + "" + zv + "" + zv + "" + zv);

            //automobilis
            Console.WriteLine("Automobilis: {0} {1} {2} ({3}m.) rida:{4}km", pavad, marke, kubat, metai, rida);

            //matematika
            var suma1 = -1 + 4 * 6;
            var suma2 = (35 + 5) % 7;
            var suma3 = 14 + -4 * 6 / 11;
            var suma4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(keturi + penki);
            Console.WriteLine(keturi - penki);
            Console.WriteLine(suma);
            Console.WriteLine(suma*suma*suma);
            Console.WriteLine(suma1);
            Console.WriteLine(suma2);
            Console.WriteLine(suma3);
            Console.WriteLine(suma4);

            Console.WriteLine(Math.Pow(penki, 3));

            Console.ReadLine();
            //duomenu ivedimas
            
            Console.Write("Iveskite savo varda: ");
            var jvardas = Console.ReadLine();
            Console.WriteLine("Jusu vardas yra: " + jvardas);
            Console.ReadLine();

            //pazymiu vidurkis
            Console.WriteLine("Suveskite pazymius: ");
            var p1 = Convert.ToDouble(Console.ReadLine());
            var p2 = Convert.ToDouble(Console.ReadLine());
            var p3 = Convert.ToDouble(Console.ReadLine());
            var vidurkis = (p1 + p2 + p3) / 3;
            Console.WriteLine("Pazymiu vidurkis yra: " + vidurkis);
            Console.ReadLine();

        }
    }
}
