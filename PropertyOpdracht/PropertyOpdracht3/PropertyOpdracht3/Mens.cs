﻿using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        //maak hier een property Leeftijd:
        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (leeftijd < value)
                {
                    leeftijd = value;
                    Console.WriteLine("Huidige leeftijd is " + leeftijd);
                }
                else
                {
                    int possible_leeftijd = value;
                    Console.WriteLine("Dat kan niet oomphie! Je bent " + leeftijd + " en je wilt " + possible_leeftijd + " Worden?!");
                }
            }
        }
		
		//get: returned leeftijd
		//set:
		// deze moet controlleren of de nieuwe leeftijd wel hoger (>) is dan de huidige
		// als deze hoger is dan zet je de waarde op leeftijd
		//als lager, dan Console.WriteLine("dat kan niet!");

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}