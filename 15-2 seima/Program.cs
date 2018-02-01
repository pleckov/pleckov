using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_seima
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmogus1 = new Zmogus();
            zmogus1.Isvedimas();

            var zmogus2 = new Zmogus("Jonas", "Petras", 190, 50, "v");
            zmogus2.Isvedimas();

            var seima = new Seima();
            seima.Isvedimas();

        }
    }
}
