using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var prideti = 0;

            int[] skaiciai = new int[11];
            skaiciai[0] = 9;
            skaiciai[1] = 8;
            skaiciai[2] = 7;
            skaiciai[3] = 1;
            skaiciai[4] = 92;

            foreach (var mas in skaiciai)
            {
                Console.WriteLine(mas);
            }

        }
    }
}
