using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int daugyba(int a, int b)
        {
            return a * b;
        }

        public static double dalyba(int a, int b)
        {
            return (double) a / b;
        }

        public static int atimtis(int a, int b)
        {
            return a - b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pasisveikinti();
            Atsisveikinti();

            var programa = new Program(); //objektas kuriamas viena karta
            programa.Pinigai();
            programa.Auto();

            Console.WriteLine(Matematika.Suma(4, 20));
            Console.WriteLine(Matematika.dalyba(4, 20));
            Console.WriteLine(Matematika.atimtis(4, 20));
            Console.WriteLine(Matematika.daugyba(4, 20));
        }

        public static void Pasisveikinti()
        {
            Console.WriteLine("Labas Krabas, koks jusu vardas?");
            Console.WriteLine("labas " + Console.ReadLine());
        }

        public static void Atsisveikinti()
        {
            Console.WriteLine("Viso gero!");
        }

        public void Pinigai()
        {
            Console.WriteLine("ka daro pinigai?");
            var pingai = Console.ReadLine();
            Console.WriteLine("Aciu jusu atsakymas priimtas");
            Console.WriteLine(pingai);
        }

        public void Auto()
        {
            Console.WriteLine("Ka vairuojate?");
            var auto = Console.ReadLine();
            if (auto == "kamaz")
            {
                Console.WriteLine("geras auto");
            }
            if (auto != "ziagas")
            {
                Console.WriteLine("kodel me ziagas");
                Console.WriteLine("Iveskite kita auto");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("geras pasirinkimas");
            }
        }
    }
}
