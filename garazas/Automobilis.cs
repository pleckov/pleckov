using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garazas
{
    class Automobilis
    {
        //modelis mar
        // pilnas konstruktorius
        // isvedimo metodas
        public string Modelis { get; set; }
        public string Marke { get; set; }
        public int Metai { get; set; }
        public int Rida { get; set; }
        public double Galia { get; set; }
        public double DarbTuris { get; set; }
        public string Spalva { get; set; }

        public Automobilis(string modelis, string marke, int metai, int rida, double galia, double darbinisTuris, string spalva)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
            Galia = galia;
            DarbTuris = darbinisTuris;
            Spalva = spalva;

        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.)", Modelis, Marke, Metai);
        }

        //nauji metodai
        //-atsukti rida
        //-perdazyti
        //-pakelti galia

        public void AtsuktiRida()
        {
            Console.WriteLine("Dabartine rida: " + Rida);
            Console.WriteLine("Iveskite norima rida: ");
            var naujaRida = Convert.ToInt32(Console.ReadLine());
            Rida = naujaRida;
            Console.WriteLine("Rida pakeisti i: " + Rida);
        }

        public void PakeistiSpalva()
        {
            Console.WriteLine("Nauja spalva: " + Spalva);
            Console.WriteLine("Iveskite norima spalva: ");
            var naujaSpalva = Convert.ToString(Console.ReadLine());
            Spalva = naujaSpalva;
            Console.WriteLine("Spalva pakeisti i: " + Spalva);
        }

        public void Pakeistigalia()
        {
            Console.WriteLine("Dabartine galia: " + Galia);
            Console.WriteLine("Iveskite norima rida: ");
            var naujaGalia = Convert.ToInt32(Console.ReadLine());
            Galia = naujaGalia;
            Console.WriteLine("Nauja galia pakeisti i: " + Galia);
        }

    }// cclass automobilis
}
