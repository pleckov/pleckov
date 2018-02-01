using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 111;
            for (int i = 1; i < sk; i++)
            {
                //Console.WriteLine("["+i+"]");
                if (i % 2 == 0)
                {
                    Console.WriteLine("skaicius lyginis: " + i);
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine("skaicius nelyginis: " + i);
                }
            }
        }
    }
}
