using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, Ivesk betkoki skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", skaicius);
            Console.WriteLine("{0}{0}{0}", skaicius);
            Console.WriteLine("{0}{0}{0}", skaicius);

            Console.WriteLine("Skaiciaus kvadratas yra: "+ Math.Pow(skaicius, 2));
            Console.ReadLine();

            //trys skaiciai
            Console.WriteLine("Iveskite 3 skaicius: ");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            var sk2 = Convert.ToInt32(Console.ReadLine());
            var sk3 = Convert.ToInt32(Console.ReadLine());
            var suma1 = sk1 + sk2 + sk3;
            var suma2 = sk1 - sk2 - sk3;
            var suma3 = sk1 * sk2 * sk3;
            var suma4 = sk1 / sk2 / sk3;
            Console.WriteLine(sk1 + "+" + sk2 + "+" + sk3 + "=" + suma1);
            Console.WriteLine(sk1 + "-" + sk2 + "-" + sk3 + "=" + suma2);
            Console.WriteLine(sk1 + "*" + sk2 + "*" + sk3 + "=" + suma3);
            Console.WriteLine(sk1 + "/" + sk2 + "/" + sk3 + "=" + suma4);
            //Console.WriteLine("{0} + {1} + {2} = ", (sk1+sk2+sk3));
            //Console.WriteLine("{0} {1} {2}", sk1, sk2, sk3);
            //Console.WriteLine("{0} {1} {2}", sk1, sk2, sk3);


        }
    }
}
