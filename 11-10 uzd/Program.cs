﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 30;
            for (int i = 30; i < 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
                //suma += i;
            }
            Console.WriteLine("atsakymas " + suma);
        }
    }
}
