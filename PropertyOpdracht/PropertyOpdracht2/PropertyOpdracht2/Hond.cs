namespace PropertyOpdracht1
{
    internal class Hond
    {
        //maak hier een property Naam, de set moet private zijn!
        private string naam;
        public string Naam
        { 
            get
            {
                return naam;
            }
            private set
            {
                naam = value;
            }
        }


        public Hond(string naam)
        {
            this.Naam = naam;
        }

    }
}