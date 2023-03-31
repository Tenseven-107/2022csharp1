using System;
using System.Runtime.CompilerServices;

namespace PropertyOpdracht1
{
    internal class Persoon
    {
        //hier komen je properties
        private string naam;
        public string Naam
        { 
            get
            {
                return naam;
            }
            set
            {
                naam = value;
                Console.WriteLine("Naam: " + naam);
            }
        }

        private int leeftijd;
        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                leeftijd = value;
                Console.WriteLine("Leeftijd: " + leeftijd);
            }
        }

        ////public Persoon()
        ////{
        ////}
    }
}