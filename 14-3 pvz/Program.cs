using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tema: dienu temperaturos

            //kuriant sarasa
            //darot metodus
            //-ivedimui
            //-isvedimui
            //-visu skaiciavimui isvedimui
            //atrinkimui i nauja sarasa

            //var dienuTemperaturos = new List<>();


        }

        public void tempIvedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.Write("Iveskite dienos temperratura: ");
                var temp = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(tm);

                Console.Write("Iveskite ir sekancia temperatura: ");
                var kartoti = Console.ReadLine();
                if (kartoti != "t")
                {
                    dar = false;
                }
            }
        }

        public void tempIsvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            foreach (var tm in sarasas)
            {
                //isvedimas
                Console.Write("[{0}] ", tm);
            }
            Console.WriteLine();
        }  

    }
}
