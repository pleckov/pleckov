using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų
            validu(pradžia turi būti mažesnė nei pabaiga).Jei rėžiai tinkami, tuomet
            vykdyti for, kuris iš duotų skaičių išvestų visus nelyginius skaičius arba tuos,
            kurie dalinasi iš 8.
            7.Dominyko uzduotis: be daugubos veiksmo programoje, sudauginti du skaicius */


            Console.Write("Iveskite reziu pradzia: ");
            var rpradzia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite reziu pabaiga: ");
            var rpabaiga = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rezio pradzia: " + rpradzia);
            Console.WriteLine("Rezio pradzia: " + rpabaiga);

            if (rpradzia < rpabaiga || rpradzia == 0)
            {
                for (int i = rpradzia; i < rpabaiga; i++)
                {
                    //Console.WriteLine("Skaiciaus " + i + " kvadratas: " + Math.Pow(i, 2));
                    //Console.WriteLine(Math.Pow(i, 2));
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine("skaicius nelyginis arba dalinasi is 8 " + i);
                    }
                }
            }
            else
            {
                Console.WriteLine("pirmas skaicius pasirinktas per mazas TOLIAU PROGRAMOS VYKDYTI NEGALIME");
            }
        }
    }
}
