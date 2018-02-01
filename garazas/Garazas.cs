using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garazas
{
    class Garazas
    {
        //pavadinimas
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public int MeistruSkaicius { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }


        public Garazas(string pavadinimas, string adresas, int meistruSkaicius, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            MeistruSkaicius = meistruSkaicius;
            Automobiliai = automobiliai;
            
        }

        //isvedimo metodas

        public void Isvedimas() //garazo isvedimas
        {
            Console.WriteLine("Garazas {0} {1} ad. ({2} mmeistru sk.)", Pavadinimas, Adresas, MeistruSkaicius );

            Console.WriteLine("remontuojamai automobiliai: ");
            for (int i = 0; i < Automobiliai.Count; i++)
            {
                Console.Write(i+1 + " auto: ");
                Automobiliai[i].Isvedimas();
            }
            
            
        }
        public void AtnaujintiPasirinkta()
        {
            Console.Write("Kuri automobili pasirinti: ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pasirinktas automobilis: ");
            Automobiliai[kuris - 1].Isvedimas();

            Console.WriteLine("1 - atsukti rida");
            Console.WriteLine("2 - perdazyti");
            Console.WriteLine("3 - padidinti galia");

            var pasirinktas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinktas)
            {
                case 1:
                    Automobiliai[kuris - 1].AtsuktiRida();
                    break;
                case 2:
                    Automobiliai[kuris - 1].PakeistiSpalva();
                    break;
                case 3:
                    Automobiliai[kuris - 1].Pakeistigalia();
                    break;
            }
            Console.WriteLine("Atnaujintas automobilis: ");
            Automobiliai[kuris -1].Isvedimas();

            public void Skaiciavimai()
            {

            }

        }
    }
}
