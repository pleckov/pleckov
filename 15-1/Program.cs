using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1
{


    class Program
    {


        static void Main(string[] args)
        {
            Studentas studentas = new Studentas();

            studentas.Vardas = "kestas";
            studentas.Pavarde = "pavarde";
            studentas.Anmzius = 45;
            studentas.Ugis_cm = 180;

            Console.WriteLine(studentas.Vardas);


            var studentas2 = new Studentas("fg", "gyhum", 56, 89);

            studentas.Isvedimas();
            studentas2.Isvedimas();

        }


    }
}
