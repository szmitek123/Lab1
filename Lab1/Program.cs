using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotow: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj pojemnosc plecaka: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj seed: ");
            int seed = int.Parse(Console.ReadLine());

            int suma = 0;

            List<Przedmiot> przedmioty = new List<Przedmiot>();
            List<Przedmiot> items = new List<Przedmiot>();

            Plecak plecak = new Plecak(0, size, items);
            Generator generator = new Generator(n, seed);
            for (int i = 0; i < n; i++) {
                Przedmiot przedmiot = new Przedmiot(i+1, generator.numbers[i], generator.numbers[n-i-1]);
                przedmioty.Add(przedmiot);
                //Console.WriteLine(przedmiot.ToString());
            }

            for (int i = 0; i < n; i++) 
            {
                if(przedmioty[i].Waga < plecak._Rozmiar - suma)
                {
                    plecak._Przedmioty.Add(przedmioty[i]);
                    suma += przedmioty[i].Waga;
                }
            }
            
            Console.WriteLine(generator);
            //Console.WriteLine(string.Join("\n", przedmioty));
            Console.WriteLine(string.Join("\n", plecak._Przedmioty));
            Console.ReadLine();
        }
    }
}
