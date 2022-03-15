using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1
{
    public class Przedmiot
    {
        public int Wartosc { get; set; }
        public int Waga { get; set; }
        public int id { get; set; }

        public Przedmiot(int nr, int waga, int wartosc)
        {
            id = nr;
            Waga = waga;
            Wartosc = wartosc;
        }
        public override string ToString()
        {
            return id + " " + Waga + " " + Wartosc;
        }
    }
    
    public class Plecak
    {
        public int _Rozmiar;
        public int _LiczbaPrzedmiotow;
        public List<Przedmiot> _Przedmioty;
        public long _seed;
        public int WartoscTotal;
        public int WagaTotal;

        public Plecak(int LiczbaPrzedmiotow, int Rozmiar, List<Przedmiot> items)
        {
            _Rozmiar = Rozmiar;
            _LiczbaPrzedmiotow = LiczbaPrzedmiotow;
            _Przedmioty = items;    
        }

        public override string ToString()
        {
            return "Liczba przedmiotow: " + _LiczbaPrzedmiotow;
        }


    }
    
}
