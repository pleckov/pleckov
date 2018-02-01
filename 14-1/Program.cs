using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Program
    {
        class Matematika
        {
            public static int Suma(int a, int b)
            {
                return a + b;
            }

            public static int Skirtumas(int a, int b)
            {
                return a - b;
            }

            public static int Daugyba(int a, int b)
            {
                return a * b;
            }

            public static double Dalyba(int a, int b)
            {
                return (double)a / b;
            }
        }
            


        static void Main(string[] args)
        {
            Pasisveikinti();
            Atsisveikinti();

            var programa = new Program(); // Obejektas kuriamas viena karta
            programa.Pinigai();
            programa.Automobilis();

            var suma = Matematika.Suma(5, 4);
            Console.WriteLine(suma);

            Console.WriteLine(Matematika.Suma(4,8));
            Console.WriteLine(Matematika.Skirtumas(15,8));
            Console.WriteLine(Matematika.Daugyba(10, 10));
            Console.WriteLine(Matematika.Dalyba(9,3));

            //iskviesti visus metodus
        }

        /// <summary>
        /// 
        /// </summary>

        public static void Pasisveikinti()
        {
            Console.WriteLine("Labas vakaras, koks tavo vardas ");
            Console.WriteLine("Labas - " + Console.ReadLine());
        }

        public static void Atsisveikinti()
        {
            Console.WriteLine("Viso gero!");
        }

        public void Pinigai()
        {
            Console.WriteLine("Ka daro pinigai? ");
            var pinigai = Console.ReadLine();
            Console.WriteLine("aciu jusu atsakymas priimtas, jis yra: ");
            Console.WriteLine(pinigai);
        }

        public void Automobilis()
        {
            Console.WriteLine("ka vairuojate? ");
            var auto = Console.ReadLine();

            if (auto == "kamaz")
            {
                Console.WriteLine("nice");
            }
        }

    }
}
