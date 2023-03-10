using System;

namespace ClassOpdracht1
{
     
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise
    {
        private readonly string accountName;

        // set account name
        internal ClassStructureExercise(string accountName)
        {
            this.accountName = accountName;
        }


        // show a greeting in the console
        internal void ShowGreetingInConsole()
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }


        // show 1 to 10
        internal void Show1To10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }


        // show distance beteen points
        internal double DistBetweenPoints(int x1, int y1, int x2, int y2)
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }

        // multiply value top the power of 2
        internal int MultiplyToPower2(int value)
        {
            int result = value * value;
            return result;
        }

        // start program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

        }
    }
}