using System;
using System.Text;

namespace BeerSong
{
    public abstract class Line : ILine
    {
        public int NumberOfBottles { get; private set; }
        public string Text { get; protected set; }

        protected Line(int numberOfBottles)
        {
            NumberOfBottles = numberOfBottles;
        }

        protected abstract string FirstSection();

        protected abstract string SecondSection();

        protected string PluralEnding { get { return NumberOfBottles == 1 ? "" : "s"; } }

        protected string StringNumberOfBottlesOnTheWall(bool capitalise = false)
        {
            if (NumberOfBottles == 0)
                if (capitalise)
                    return "No more";
                else
                    return "no more";
            else
                return NumberOfBottles.ToString();
        }

    }
        
}