using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garazas
{
    class Program
    {
        static void Main(string[] args)
        {
            var garazas = new Garazas("Pas Petra", "Kaunas, kazkur prie visu garazu", 1, new List<Automobilis>
            {
                new Automobilis("Audi", "simtine", 2000, 32000, 66, 1.6, "juoda"),
                new Automobilis("BMW", "troike", 3000, 3265400, 88, 3.6, "balta"),
                new Automobilis("Wv", "pasat", 2011, 78995, 96, 4.6, "zalia"),
                new Automobilis("Mersas", "SEL", 2008, 56566, 106, 5.6, "geltona")
            });

            garazas.Isvedimas();
        }
    }
}
