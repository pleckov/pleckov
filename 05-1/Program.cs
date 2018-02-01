using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Liepkite vartotojui įvesti tris sveikuosius skaičius. Parašykite šias atskiras if
sąlygas:
1.1. patikrinkite ar pirmas ir antras skaičiai yra lygūs;
1.2. patikrinkite ar antras ir trečias skaičiai yra lygūs;
1.3. patikrinkite ar pirmas skaičius yra didesnis už antrąjį;
1.4. patikrinkite ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę
(trečias skaičius padaugintas iš dviejų);
1.5. patikrinkite ar pirmas skaičius yra lyginis (dalinti per % ir žiūrėti ar gautas
atsakymas yra lygus nuliui);
1.6. patikrinkite ar antras skaičius skaičius yra nelyginis (dalinti per % ir žiūrėti ar
gautas atsakymas nėra lygus nuliui);
1.7. patikrinkite ar trečias skaičius yra teigiamas (daugiau už 0);
1.8. patikrinkite ar trečias skaičius yra neigiamas (mažiau už 0).*/
            Console.WriteLine("Iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a==b)
            {
                Console.WriteLine("pirmas skaicius lygus antram");
            }

            if (b==c)
            {
                Console.WriteLine("antras skaicius lygus treciam");
            }

            if (a>b)
            {
                Console.WriteLine("pirmas skaicius didesnis uz antra");
            }

            if (b>c*2)
            {
                Console.WriteLine("antras skaicius yra didesnis uz trecio sandauga is dvieju");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius yra lyginis");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("antras skaicius yra nelyginis");
            }

            if (c > 0)
            {
                Console.WriteLine("trecias skaicius daugiau uz nuli");
            }

            if (c < 0)
            {
                Console.WriteLine("trecias skaicius yra negiamas");
            }

        }
    }
}
