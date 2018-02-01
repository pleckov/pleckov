using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.
            Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę.Raskite:
            2.1.didžiausią pažymį;
            2.2.mažiausią pažymį;
            2.3.vidurkį;
            2.4.išveskite atsitiktinį skaičių iš šio sąrašo.*/

            Console.WriteLine("Kiek noresite ivesti pazymiu? ");
            var paz_kiekis = Convert.ToInt32(Console.ReadLine());
            var kartai = 0; 
            var min_paz = 10;
            var max_paz = -10;
            var vid_paz = 0;
            var pazymys = 0;
            var suma = 0;
            var ran_paz = 0;

            var ats_obj = new Random();
            var ats_skc = ats_obj.Next(1, paz_kiekis);


            List<int> mok_paz = new List<int>();

            while (paz_kiekis > kartai)
            {
                Console.Write("Iveskite pazymi:  " + (kartai+1) + " ");
                pazymys = Convert.ToInt32(Console.ReadLine());
                mok_paz.Add(pazymys); //kelimas i lista

                if (max_paz < pazymys)
                {
                    max_paz = pazymys;
                }

                if (min_paz > pazymys)
                {
                    min_paz = pazymys;
                }

                if (ats_skc == kartai) //randominis ifas
                {
                    ran_paz = pazymys;
                }

                suma += pazymys;

                kartai++; // turi buti gale, kad vyktu skaiciavimai 
            }

            Console.WriteLine("max paz yra " + max_paz);
            Console.WriteLine("min paz yra " + min_paz);
            Console.WriteLine("paz vid yra " + suma / kartai);

            Console.WriteLine("random pazymy " + ran_paz);

            foreach (var paz in mok_paz)
            {
                Console.WriteLine(paz);
            }

            Console.WriteLine();
            Console.WriteLine();
            

        }
    }
}
