using System;

namespace FunctionOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program= new Program();
            int nummer = program.MijnFavorietNummer();//deze werkt nu niet, pas de code onder aan om het te laten werken

            Console.WriteLine($"mijn favoriete nummer is {nummer}");
        }

        //laat deze function een 'int' teruggeven
        private int MijnFavorietNummer()
        {

            //maak hier een variable van het type 'int' en geef die een waarde
            int num = 107;
            //geef hier de variable terug
            return num;
        }

    }
}