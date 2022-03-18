using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab1;
using Plecak_Forms;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            List<Przedmiot> items = new List<Przedmiot>();

            Plecak plecak = new Plecak(0, 100, items);
            Generator generator = new Generator(10, 1);
            for (int i = 0; i < 10; i++)
            {
                Przedmiot przedmiot = new Przedmiot(i + 1, generator.numbers[i], generator.numbers[10 - i - 1]);
                przedmioty.Add(przedmiot);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int suma = 0;

            List<Przedmiot> przedmioty = new List<Przedmiot>();
            List<Przedmiot> items = new List<Przedmiot>();

            Plecak plecak = new Plecak(0, 100, items);
            Generator generator = new Generator(10, 1);
            for (int i = 0; i < 10; i++)
            {
                Przedmiot przedmiot = new Przedmiot(i + 1, generator.numbers[i], generator.numbers[10 - i - 1]);
                przedmioty.Add(przedmiot);
            }

            for (int i = 0; i < 10; i++)
            {
                if (przedmioty[i].Waga < plecak._Rozmiar - suma)
                {
                    plecak._Przedmioty.Add(przedmioty[i]);
                    suma += przedmioty[i].Waga;
                }
            }
            Assert.IsTrue(suma<=100);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int suma = 0;

            List<Przedmiot> przedmioty = new List<Przedmiot>();
            List<Przedmiot> items = new List<Przedmiot>();

            Plecak plecak = new Plecak(0, 0, items);
            Generator generator = new Generator(10, 1);
            for (int i = 0; i < 10; i++)
            {
                Przedmiot przedmiot = new Przedmiot(i + 1, generator.numbers[i], generator.numbers[10 - i - 1]);
                przedmioty.Add(przedmiot);
            }

            for (int i = 0; i < 10; i++)
            {
                if (przedmioty[i].Waga < plecak._Rozmiar - suma)
                {
                    plecak._Przedmioty.Add(przedmioty[i]);
                    suma += przedmioty[i].Waga;
                }
            }
            Assert.AreEqual(suma,0);
        }
    }
}
