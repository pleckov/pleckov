using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ar Jusu turite nuolatini bileteli? ");
            var nuolatinis = Convert.ToBoolean(Console.ReadLine());

            if (nuolatinis)
            {
                Console.WriteLine("galite vaziuoti ir gero kelio");
            }
            else
            {
                Console.WriteLine("eikite peskom jus neturite bilieto!");
            }
        }
    }
}
