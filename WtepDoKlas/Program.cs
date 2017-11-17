using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WtepDoKlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osb = new Osoba("Janek", "NopeKowalski");

            Console.WriteLine(osb.PobierzImie);
            osb.zmienImie("Ala");
            Console.WriteLine(osb.PobierzImie);


            Console.WriteLine(osb.PobierzNazwisko);
            osb.PobierzNazwisko = "Adamski";
            Console.WriteLine(osb.PobierzNazwisko);

            osb.NadajWiek(22);
            Console.WriteLine(osb.Wiek);

            Osoba osb2 = osb; // kopiowanie referencji (kopiuje adress w pamieci ram i przypisuje do osb2)
            osb2.PobierzNazwisko = "Nowe dla 2 osoby";
            Console.WriteLine(osb.PobierzNazwisko + " " + osb2.PobierzNazwisko);

            Osoba osoba3 = new Osoba("Ola", "Nowe dla 2 osoby");
            osoba3.NadajWiek(20);
            bool rowne = osb == osoba3;

            Console.WriteLine(rowne);

            var wynik = osb2 + osoba3;
            Console.WriteLine(wynik);
            //osb.Wiek = "asdas";

            Console.Read();
        }
    }


}
