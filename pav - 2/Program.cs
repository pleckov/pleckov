using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pav___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Iveskite skaiciu:  ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var mas_duo in skaiciai)
            {
                Console.Write(mas_duo + " ");
            }
        }
    }
}
