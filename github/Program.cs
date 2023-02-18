﻿using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko pudelko1 = new Pudelko(); // definicja obiektu1 typu Pudelko
            Pudelko pudelko2 = new Pudelko(); // definicja obiektu2 typu Pudelko
            // spefyfikacja 1
            pudelko1.UstawDlugosc(5.5);
            pudelko1.UstawWysokosc(6.0);
            pudelko1.UstawSzerokosc(3.0);
            // spefyfikaja 2
            pudelko2.UstawDlugosc(3.5);
            pudelko2.UstawWysokosc(2.0);
            pudelko2.UstawSzerokosc(1.0);
            // Objetosc 1
            double obj1 = pudelko1.ObliczObjetosc();
            Console.WriteLine("Objetość pudełka nr 1: {0}", obj1);
            // Objetosc 2
            // Obliczenie bez użycia powyższej metody
            double obj2 = pudelko2.ObliczObjetosc();
            Console.WriteLine("Objetość pudełka nr 2: {0}", obj2);
            Console.ReadKey();
            // Wynik działania programu
            //Objetosc pudelka nr 1: 99
            //Objetosc pudelka nr 2: 7
        }
    }
    class Pudelko
    {
        private double dlugosc; // pole dostepne tylko z wnetrza klasy
        private double szerokosc; // pole dostepne tylko z wnetrza klasy
        private double wysokosc; // pole dostepne tylko z wnetrza klasy
        // definiujemy metody, które mają dostęp do tych pól oraz są publiczne
        public void UstawDlugosc(double dl)
        {
            dlugosc = dl;
        }
        public void UstawSzerokosc(double szer)
        {
            szerokosc = szer;
        }
        public void UstawWysokosc(double wys)
        {
            wysokosc = wys;
        }
        // Metoda do obliczania objetosci w innej postaci niż w pierwszym przykladzie
        // Składowe klasy maja już swoje wartości, mozemy obliczyć objętosc
        public double ObliczObjetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }
    }
}