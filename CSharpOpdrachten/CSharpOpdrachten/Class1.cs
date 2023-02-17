namespace CSharpOpdrachten
{
    internal class ProgramTwo
    {
        public void Run()
        {
            var number = 5;
            var plus = 60;
            var numberTwo = number + plus;
            Console.WriteLine(numberTwo);

            if (true)
            {
                Console.WriteLine(numberTwo.ToString() + 
                    " is " + 
                    number.ToString() + 
                    " + " + plus.ToString());
            }
        }
    }
}
