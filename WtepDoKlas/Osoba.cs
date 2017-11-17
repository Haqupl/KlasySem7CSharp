using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WtepDoKlas
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        //prop i 2xTab

        public int Wiek { get; private set; } //krutka forma property tylko pobierz

        //modyfikator dostepu
        public Osoba()
        {
            //zawsze się wywołuje przy stworzeniu obiektu klasy
            Console.WriteLine("Konstruktor domyslny");
        }

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void zmienImie(string noweImie)
        {
            imie = noweImie;
        }

        public string PobierzImie //property do zwracania jakiejs zmiennej
        {
            get
            {
                return imie;
            }
        }

        public string PobierzNazwisko // property set i get
        {
            get
            {
                return nazwisko;
            }

            set
            {
                if (value.Length > 3)
                    nazwisko = value;
            }
        }

        public void NadajWiek(int wiek)
        {
            this.Wiek = wiek;
        }

        //przeciazenie operatorow porownania
        public static bool operator ==(Osoba l, Osoba P)
        {
            return l.PobierzNazwisko == P.PobierzNazwisko;
        }

        public static bool operator !=(Osoba l, Osoba P)
        {
            return l.PobierzNazwisko != P.PobierzNazwisko;
        }

        //przeciazenie operatorow dodania
        public static int operator +(Osoba L, Osoba P)
        {
            return L.Wiek + P.Wiek;
        }

    }
}
