using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumos_paieska
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                suma += i;
            }
            Console.WriteLine("atsakymas " + suma);
        }
    }
}
