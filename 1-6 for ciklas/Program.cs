using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_for_ciklas
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk = 11;
            for (int i = 1; i < sk; i++)
            {
                //Console.WriteLine("["+i+"]");
                if (i % 2 == 0)
                {
                    Console.WriteLine("skaicius lyginis: " + i);
                }
            }
        }
    }
}
